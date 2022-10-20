﻿// <copyright file="LangOpenApi.cs" company="Microsoft Corporation">
//     Copyright (c) Microsoft Corporation. All rights reserved.
//     Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// </copyright>


using System.IO;
using fhirCsR2.Models;
using Microsoft.Health.Fhir.SpecManager.Manager;
using Microsoft.OpenApi.Extensions;
using Microsoft.OpenApi.Models;
using Microsoft.OpenApi.Writers;
using static Microsoft.Health.Fhir.SpecManager.Language.OpenApi.OpenApiCommon;

namespace Microsoft.Health.Fhir.SpecManager.Language.OpenApi;

public class LangOpenApi : ILanguage
{
    /// <summary>FHIR information we are exporting.</summary>
    private FhirVersionInfo _info;

    /// <summary>Options for controlling the export.</summary>
    private ExporterOptions _options;

    /// <summary>Pathname of the export directory.</summary>
    private string _exportDirectory;

    /// <summary>True to export enums.</summary>
    private bool _exportEnums = true;

    /// <summary>Name of the language.</summary>
    private const string _languageName = "OpenApi";

    /// <summary>The single file export extension - requires directory export.</summary>
    private const string _singleFileExportExtension = null;

    /// <summary>(Immutable) Pathname of the relative export directory.</summary>
    private const string _relativeExportDirectory = "";

    /// <summary>Gets the name of the language.</summary>
    /// <value>The name of the language.</value>
    string ILanguage.LanguageName => _languageName;

    /// <summary>
    /// Gets the single file extension for this language - null or empty indicates a multi-file
    /// export (exporter should copy the contents of the directory).
    /// </summary>
    string ILanguage.SingleFileExportExtension => _singleFileExportExtension;

    /// <summary>Gets the FHIR primitive type map.</summary>
    /// <value>The FHIR primitive type map.</value>
    Dictionary<string, string> ILanguage.FhirPrimitiveTypeMap => _primitiveTypeMap;

    /// <summary>Gets the reserved words.</summary>
    /// <value>The reserved words.</value>
    HashSet<string> ILanguage.ReservedWords => _reservedWords;

    /// <summary>
    /// Gets a list of FHIR class types that the language WILL export, regardless of user choices.
    /// Used to provide information to users.
    /// </summary>
    List<ExporterOptions.FhirExportClassType> ILanguage.RequiredExportClassTypes => new()
    {
        ExporterOptions.FhirExportClassType.PrimitiveType,
        ExporterOptions.FhirExportClassType.ComplexType,
        ExporterOptions.FhirExportClassType.Resource,
        ExporterOptions.FhirExportClassType.Interaction,
    };

    /// <summary>
    /// Gets a list of FHIR class types that the language CAN export, depending on user choices.
    /// </summary>
    List<ExporterOptions.FhirExportClassType> ILanguage.OptionalExportClassTypes => new()
    {
        //ExporterOptions.FhirExportClassType.Profile,
    };

    /// <summary>Gets language-specific options and their descriptions.</summary>
    Dictionary<string, string> ILanguage.LanguageOptions => OpenApiOptions.LanguageOptions;

    /// <summary>Export the passed FHIR version into the specified directory.</summary>
    /// <param name="info">           The information.</param>
    /// <param name="serverInfo">     Information describing the server.</param>
    /// <param name="options">        Options for controlling the operation.</param>
    /// <param name="exportDirectory">Directory to write files.</param>
    void ILanguage.Export(
        FhirVersionInfo info,
        FhirCapabiltyStatement serverInfo,
        ExporterOptions options,
        string exportDirectory)
    {
        OpenApiOptions openApiOptions = new OpenApiOptions(options);

        if (serverInfo != null)
        {
            ModelBuilder builder = new(info, openApiOptions, options, serverInfo);

            OpenApiDocument doc = builder.Build();

            if (openApiOptions.MultiFile)
            {
                WriteAsMultiFile(exportDirectory, openApiOptions, doc, FhirPackageCommon.RForSequence(info.FhirSequence));
            }
            else
            {
                WriteAsSingleFile(exportDirectory, openApiOptions, doc, FhirPackageCommon.RForSequence(info.FhirSequence));
            }
        }
        else
        { 
            foreach (FhirCapabiltyStatement cap in info.CapabilitiesByUrl.Values)
            {
                ModelBuilder builder = new(info, openApiOptions, options, cap);

                OpenApiDocument doc = builder.Build();

                if (openApiOptions.MultiFile)
                {
                    WriteAsMultiFile(exportDirectory, openApiOptions, doc, cap.Id);
                }
                else
                {
                    WriteAsSingleFile(exportDirectory, openApiOptions, doc, cap.Id);
                }
            }
        }
    }

    /// <summary>Writes as multi file.</summary>
    /// <param name="exportDirectory">Directory to write files.</param>
    /// <param name="openApiOptions"> Options for controlling the open API.</param>
    /// <param name="completeDoc">            The document.</param>
    /// <param name="fileId">         Identifier for the file.</param>
    private void WriteAsMultiFile(
        string exportDirectory,
        OpenApiOptions openApiOptions,
        OpenApiDocument completeDoc,
        string fileId)
    {
        Dictionary<string, OpenApiDocument> docsByPrefix = new();

        // traverse the paths to discover our root keys (mostly just resources)
        foreach ((string apiPath, OpenApiPathItem pathItem) in completeDoc.Paths)
        {
            string pathKey;
            string titleSuffix;

            if (apiPath.Equals("/", StringComparison.Ordinal) ||
                apiPath.Substring(0, 2).Equals("/_", StringComparison.Ordinal) ||
                apiPath.Substring(0, 2).Equals("/$", StringComparison.Ordinal))
            {
                pathKey = "_Root";
                titleSuffix = "Server Root";
            }
            else
            {
                pathKey = apiPath.Split('/')[1];
                titleSuffix = pathKey;
            }

            if (!docsByPrefix.ContainsKey(pathKey))
            {
                OpenApiDocument doc = new();
                doc.Info = new OpenApiInfo(completeDoc.Info);
                doc.Info.Title += " - " + titleSuffix;

                doc.Components = new();
                doc.Components.Parameters = new Dictionary<string, OpenApiParameter>();
                doc.Components.Schemas = new Dictionary<string, OpenApiSchema>();
                doc.Paths = new();
                doc.Tags = new List<OpenApiTag>();

                docsByPrefix.Add(pathKey, doc);
            }

            docsByPrefix[pathKey].Paths.Add(apiPath, new OpenApiPathItem(pathItem));
        }

        Dictionary<string, OpenApiTag> sourceTags = completeDoc.Tags.ToDictionary(t => t.Name);

        // traverse each partial document, resolve missing references and write
        foreach ((string pathKey, OpenApiDocument doc) in docsByPrefix)
        {
            ResolveContainedRefs(completeDoc, doc, sourceTags);

            WriteAsSingleFile(exportDirectory, openApiOptions, doc, fileId + "_" + pathKey);
        }
    }

    /// <summary>Copies the nested defs.</summary>
    /// <param name="source">Another instance to copy.</param>
    /// <param name="target">Target for the.</param>
    private void ResolveContainedRefs(
        OpenApiDocument source,
        OpenApiDocument target,
        Dictionary<string, OpenApiTag> sourceTags)
    {
        HashSet<string> usedTags = new();

        foreach ((string targetPathKey, OpenApiPathItem targetPath) in target.Paths)
        {
            foreach ((OperationType targetOpKey, OpenApiOperation targetOp) in targetPath.Operations)
            {
                foreach (OpenApiTag targetTag in targetOp.Tags)
                {
                    // only need to resolve references, actual tags were copied
                    if (string.IsNullOrEmpty(targetTag.Reference?.Id ?? null) ||
                        usedTags.Contains(targetTag.Reference.Id))
                    {
                        continue;
                    }

                    target.Tags.Add(sourceTags[targetTag.Reference.Id]);
                    usedTags.Add(targetTag.Reference.Id);
                }

                foreach (OpenApiParameter targetParam in targetOp.Parameters)
                {
                    // only need to resolve references, full parameters were copied
                    if (string.IsNullOrEmpty(targetParam.Reference?.Id ?? null) ||
                        target.Components.Parameters.ContainsKey(targetParam.Reference.Id))
                    {
                        continue;
                    }

                    //target.Components.Parameters.Add(
                    //    targetParam.Reference.Id,
                    //    new OpenApiParameter(source.Components.Parameters[targetParam.Reference.Id]));

                    target.Components.Parameters.Add(
                        targetParam.Reference.Id,
                        source.Components.Parameters[targetParam.Reference.Id]);

                }

                foreach (OpenApiMediaType targetMedia in targetOp.RequestBody?.Content?.Values ?? Array.Empty<OpenApiMediaType>())
                {
                    // only process references, the rest were copied
                    if (string.IsNullOrEmpty(targetMedia.Schema?.Reference?.Id ?? null) ||
                        target.Components.Schemas.ContainsKey(targetMedia.Schema.Reference.Id))
                    {
                        continue;
                    }

                    CopySchemaRecursive(source, target, targetMedia.Schema.Reference.Id);
                }

                foreach (OpenApiResponse targetResponse in targetOp.Responses.Values)
                {
                    foreach (OpenApiMediaType targetMedia in targetResponse.Content.Values)
                    {
                        // only process references, the rest were copied
                        if (string.IsNullOrEmpty(targetMedia.Schema?.Reference?.Id ?? null) ||
                            target.Components.Schemas.ContainsKey(targetMedia.Schema.Reference.Id))
                        {
                            continue;
                        }

                        CopySchemaRecursive(source, target, targetMedia.Schema.Reference.Id);
                    }
                }
            }
        }
    }

    /// <summary>Copies the schema recursive.</summary>
    /// <param name="source">Another instance to copy.</param>
    /// <param name="target">Target for the.</param>
    /// <param name="key">   The key.</param>
    private void CopySchemaRecursive(
        OpenApiDocument source,
        OpenApiDocument target,
        string key)
    {
        if (target.Components.Schemas.ContainsKey(key))
        {
            return;
        }

        target.Components.Schemas.Add(key, source.Components.Schemas[key]);

        //OpenApiSchema src = source.Components.Schemas[key];

        //OpenApiSchema ts = new OpenApiSchema()
        //{
        //    Type = src.Type,
        //    Properties = new Dictionary<string, OpenApiSchema>(),
        //    Description = src.Description,
        //};

        //target.Components.Schemas.Add(
        //    key,
        //    ts);

        //// check inheritance
        //if (src.AllOf != null)
        //{
        //    ts.AllOf = new List<OpenApiSchema>();
        //}

        foreach (OpenApiSchema s in target.Components.Schemas[key].AllOf ?? Array.Empty<OpenApiSchema>())
        {
            //ts.AllOf.Add(s);

            if (string.IsNullOrEmpty(s.Reference?.Id ?? null) ||
                target.Components.Schemas.ContainsKey(s.Reference.Id))
            {
                continue;
            }

            CopySchemaRecursive(source, target, s.Reference.Id);
        }

        // check properties
        foreach (OpenApiSchema s in target.Components.Schemas[key].Properties?.Values ?? Array.Empty<OpenApiSchema>())
        {
            if (string.IsNullOrEmpty(s.Reference?.Id ?? null) ||
                target.Components.Schemas.ContainsKey(s.Reference.Id))
            {
                continue;
            }

            CopySchemaRecursive(source, target, s.Reference.Id);
        }
    }

    /// <summary>Writes an OpenApi Document as single file.</summary>
    /// <param name="exportDirectory">Directory to write files.</param>
    /// <param name="openApiOptions"> Options for controlling the open API.</param>
    /// <param name="doc">            The document.</param>
    /// <param name="fileId">         Identifier for the file.</param>
    private static void WriteAsSingleFile(
        string exportDirectory,
        OpenApiOptions openApiOptions,
        OpenApiDocument doc,
        string fileId)
    {
        string filename = Path.Combine(exportDirectory, $"{_languageName}_{fileId}.{openApiOptions.FileFormat.ToString().ToLowerInvariant()}");

        using (FileStream stream = new FileStream(filename, FileMode.Create))
        using (StreamWriter sw = new StreamWriter(stream))
        {
            IOpenApiWriter writer;

            switch (openApiOptions.FileFormat)
            {
                case OaFileFormat.Json:
                default:
                    writer = new OpenApiJsonWriter(sw, new OpenApiJsonWriterSettings() { Terse = openApiOptions.Minify });
                    break;
                case OaFileFormat.Yaml:
                    writer = new OpenApiYamlWriter(sw);
                    break;
            }

            doc.Serialize(writer, openApiOptions.OpenApiVersion);
        }
    }
}
