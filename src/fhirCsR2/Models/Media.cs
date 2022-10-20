// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;
using fhirCsR2.Serialization;

namespace fhirCsR2.Models
{
  /// <summary>
  /// A photo, video, or audio recording acquired or used in healthcare. The actual content may be inline or provided by direct reference.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<Media>))]
  public class Media : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "Media";
    /// <summary>
    /// The actual content of the media - inline or by direct reference to the media source file.
    /// </summary>
    public Attachment Content { get; set; }
    /// <summary>
    /// The name of the device / manufacturer of the device  that was used to make the recording.
    /// </summary>
    public string DeviceName { get; set; }
    /// <summary>
    /// Extension container element for DeviceName
    /// </summary>
    public Element _DeviceName { get; set; }
    /// <summary>
    /// The duration of the recording in seconds - for audio and video.
    /// </summary>
    public uint? Duration { get; set; }
    /// <summary>
    /// The number of frames in a photo. This is used with a multi-page fax, or an imaging acquisition context that takes multiple slices in a single image, or an animated gif. If there is more than one frame, this SHALL have a value in order to alert interface software that a multi-frame capable rendering widget is required.
    /// </summary>
    public uint? Frames { get; set; }
    /// <summary>
    /// Height of the image in pixels (photo/video).
    /// </summary>
    public uint? Height { get; set; }
    /// <summary>
    /// Identifiers associated with the image - these may include identifiers for the image itself, identifiers for the context of its collection (e.g. series ids) and context ids such as accession numbers or other workflow identifiers.
    /// </summary>
    public List<Identifier> Identifier { get; set; }
    /// <summary>
    /// The person who administered the collection of the image.
    /// </summary>
    public Reference Operator { get; set; }
    /// <summary>
    /// Who/What this Media is a record of.
    /// </summary>
    public Reference Subject { get; set; }
    /// <summary>
    /// Details of the type of the media - usually, how it was acquired (what type of device). If images sourced from a DICOM system, are wrapped in a Media resource, then this is the modality.
    /// </summary>
    public CodeableConcept Subtype { get; set; }
    /// <summary>
    /// Whether the media is a photo (still image), an audio recording, or a video recording.
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// Extension container element for Type
    /// </summary>
    public Element _Type { get; set; }
    /// <summary>
    /// The name of the imaging view e.g. Lateral or Antero-posterior (AP).
    /// </summary>
    public CodeableConcept View { get; set; }
    /// <summary>
    /// Width of the image in pixels (photo/video).
    /// </summary>
    public uint? Width { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      if (!string.IsNullOrEmpty(ResourceType))
      {
        writer.WriteString("resourceType", (string)ResourceType!);
      }


      ((fhirCsR2.Models.DomainResource)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Type))
      {
        writer.WriteString("type", (string)Type!);
      }

      if (_Type != null)
      {
        writer.WritePropertyName("_type");
        _Type.SerializeJson(writer, options);
      }

      if (Subtype != null)
      {
        writer.WritePropertyName("subtype");
        Subtype.SerializeJson(writer, options);
      }

      if ((Identifier != null) && (Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();

        foreach (Identifier valIdentifier in Identifier)
        {
          valIdentifier.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (Subject != null)
      {
        writer.WritePropertyName("subject");
        Subject.SerializeJson(writer, options);
      }

      if (Operator != null)
      {
        writer.WritePropertyName("operator");
        Operator.SerializeJson(writer, options);
      }

      if (View != null)
      {
        writer.WritePropertyName("view");
        View.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(DeviceName))
      {
        writer.WriteString("deviceName", (string)DeviceName!);
      }

      if (_DeviceName != null)
      {
        writer.WritePropertyName("_deviceName");
        _DeviceName.SerializeJson(writer, options);
      }

      if (Height != null)
      {
        writer.WriteNumber("height", (uint)Height!);
      }

      if (Width != null)
      {
        writer.WriteNumber("width", (uint)Width!);
      }

      if (Frames != null)
      {
        writer.WriteNumber("frames", (uint)Frames!);
      }

      if (Duration != null)
      {
        writer.WriteNumber("duration", (uint)Duration!);
      }

      if (Content != null)
      {
        writer.WritePropertyName("content");
        Content.SerializeJson(writer, options);
      }

      if (includeStartObject)
      {
        writer.WriteEndObject();
      }
    }
    /// <summary>
    /// Deserialize a JSON property
    /// </summary>
    public new void DeserializeJsonProperty(ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "content":
          Content = new fhirCsR2.Models.Attachment();
          Content.DeserializeJson(ref reader, options);
          break;

        case "deviceName":
          DeviceName = reader.GetString();
          break;

        case "_deviceName":
          _DeviceName = new fhirCsR2.Models.Element();
          _DeviceName.DeserializeJson(ref reader, options);
          break;

        case "duration":
          Duration = reader.GetUInt32();
          break;

        case "frames":
          Frames = reader.GetUInt32();
          break;

        case "height":
          Height = reader.GetUInt32();
          break;

        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.Identifier objIdentifier = new fhirCsR2.Models.Identifier();
            objIdentifier.DeserializeJson(ref reader, options);
            Identifier.Add(objIdentifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Identifier.Count == 0)
          {
            Identifier = null;
          }

          break;

        case "operator":
          Operator = new fhirCsR2.Models.Reference();
          Operator.DeserializeJson(ref reader, options);
          break;

        case "subject":
          Subject = new fhirCsR2.Models.Reference();
          Subject.DeserializeJson(ref reader, options);
          break;

        case "subtype":
          Subtype = new fhirCsR2.Models.CodeableConcept();
          Subtype.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = reader.GetString();
          break;

        case "_type":
          _Type = new fhirCsR2.Models.Element();
          _Type.DeserializeJson(ref reader, options);
          break;

        case "view":
          View = new fhirCsR2.Models.CodeableConcept();
          View.DeserializeJson(ref reader, options);
          break;

        case "width":
          Width = reader.GetUInt32();
          break;

        default:
          ((fhirCsR2.Models.DomainResource)this).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Deserialize a JSON object
    /// </summary>
    public new void DeserializeJson(ref Utf8JsonReader reader, JsonSerializerOptions options)
    {
      string propertyName;

      while (reader.Read())
      {
        if (reader.TokenType == JsonTokenType.EndObject)
        {
          return;
        }

        if (reader.TokenType == JsonTokenType.PropertyName)
        {
          propertyName = reader.GetString();
          reader.Read();
          this.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException();
    }
  }
  /// <summary>
  /// Code Values for the Media.type field
  /// </summary>
  public static class MediaTypeCodes {
    public const string PHOTO = "photo";
    public const string VIDEO = "video";
    public const string AUDIO = "audio";
    public static HashSet<string> Values = new HashSet<string>() {
      "photo",
      "video",
      "audio",
    };
  }
}
