// <auto-generated/>
// Contents of: hl7.fhir.r4.core version: 4.0.1

using System;
using System.Buffers;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using Hl7.Fhir.Model;
using Hl7.Fhir.Model.JsonExtensions;
using Hl7.Fhir.Serialization;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  
*/

namespace Hl7.Fhir.Model.JsonExtensions
{
  /// <summary>
  /// JSON Serialization Extensions for RelatedPerson
  /// </summary>
  public static class RelatedPersonJsonExtensions
  {
    /// <summary>
    /// Serialize a FHIR RelatedPerson into JSON
    /// </summary>
    public static void SerializeJson(this RelatedPerson current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      writer.WriteString("resourceType","RelatedPerson");
      // Complex: RelatedPerson, Export: RelatedPerson, Base: DomainResource (DomainResource)
      ((Hl7.Fhir.Model.DomainResource)current).SerializeJson(writer, options, false);

      if ((current.Identifier != null) && (current.Identifier.Count != 0))
      {
        writer.WritePropertyName("identifier");
        writer.WriteStartArray();
        foreach (Identifier val in current.Identifier)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.ActiveElement != null)
      {
        if (current.ActiveElement.Value != null)
        {
          writer.WriteBoolean("active",(bool)current.ActiveElement.Value);
        }
        if (current.ActiveElement.HasExtensions() || (!string.IsNullOrEmpty(current.ActiveElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_active",false,current.ActiveElement.Extension,current.ActiveElement.ElementId);
        }
      }

      writer.WritePropertyName("patient");
      current.Patient.SerializeJson(writer, options);

      if ((current.Relationship != null) && (current.Relationship.Count != 0))
      {
        writer.WritePropertyName("relationship");
        writer.WriteStartArray();
        foreach (CodeableConcept val in current.Relationship)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Name != null) && (current.Name.Count != 0))
      {
        writer.WritePropertyName("name");
        writer.WriteStartArray();
        foreach (HumanName val in current.Name)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Telecom != null) && (current.Telecom.Count != 0))
      {
        writer.WritePropertyName("telecom");
        writer.WriteStartArray();
        foreach (ContactPoint val in current.Telecom)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.GenderElement != null)
      {
        if (current.GenderElement.Value != null)
        {
          writer.WriteString("gender",Hl7.Fhir.Utility.EnumUtility.GetLiteral(current.GenderElement.Value));
        }
        if (current.GenderElement.HasExtensions() || (!string.IsNullOrEmpty(current.GenderElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_gender",false,current.GenderElement.Extension,current.GenderElement.ElementId);
        }
      }

      if (current.BirthDateElement != null)
      {
        if (!string.IsNullOrEmpty(current.BirthDateElement.Value))
        {
          writer.WriteString("birthDate",current.BirthDateElement.Value);
        }
        if (current.BirthDateElement.HasExtensions() || (!string.IsNullOrEmpty(current.BirthDateElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_birthDate",false,current.BirthDateElement.Extension,current.BirthDateElement.ElementId);
        }
      }

      if ((current.Address != null) && (current.Address.Count != 0))
      {
        writer.WritePropertyName("address");
        writer.WriteStartArray();
        foreach (Address val in current.Address)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if ((current.Photo != null) && (current.Photo.Count != 0))
      {
        writer.WritePropertyName("photo");
        writer.WriteStartArray();
        foreach (Attachment val in current.Photo)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (current.Period != null)
      {
        writer.WritePropertyName("period");
        current.Period.SerializeJson(writer, options);
      }

      if ((current.Communication != null) && (current.Communication.Count != 0))
      {
        writer.WritePropertyName("communication");
        writer.WriteStartArray();
        foreach (RelatedPerson.CommunicationComponent val in current.Communication)
        {
          val.SerializeJson(writer, options, true);
        }
        writer.WriteEndArray();
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR RelatedPerson
    /// </summary>
    public static void DeserializeJson(this RelatedPerson current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"RelatedPerson >>> RelatedPerson.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"RelatedPerson: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR RelatedPerson
    /// </summary>
    public static void DeserializeJsonProperty(this RelatedPerson current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "identifier":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"RelatedPerson error reading 'identifier' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Identifier = new List<Identifier>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Identifier v_Identifier = new Hl7.Fhir.Model.Identifier();
            v_Identifier.DeserializeJson(ref reader, options);
            current.Identifier.Add(v_Identifier);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Identifier.Count == 0)
          {
            current.Identifier = null;
          }
          break;

        case "active":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.ActiveElement = new FhirBoolean();
            reader.Skip();
          }
          else
          {
            current.ActiveElement = new FhirBoolean(reader.GetBoolean());
          }
          break;

        case "_active":
          if (current.ActiveElement == null) { current.ActiveElement = new FhirBoolean(); }
          ((Hl7.Fhir.Model.Element)current.ActiveElement).DeserializeJson(ref reader, options);
          break;

        case "patient":
          current.Patient = new Hl7.Fhir.Model.ResourceReference();
          ((Hl7.Fhir.Model.ResourceReference)current.Patient).DeserializeJson(ref reader, options);
          break;

        case "relationship":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"RelatedPerson error reading 'relationship' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Relationship = new List<CodeableConcept>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.CodeableConcept v_Relationship = new Hl7.Fhir.Model.CodeableConcept();
            v_Relationship.DeserializeJson(ref reader, options);
            current.Relationship.Add(v_Relationship);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Relationship.Count == 0)
          {
            current.Relationship = null;
          }
          break;

        case "name":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"RelatedPerson error reading 'name' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Name = new List<HumanName>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.HumanName v_Name = new Hl7.Fhir.Model.HumanName();
            v_Name.DeserializeJson(ref reader, options);
            current.Name.Add(v_Name);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Name.Count == 0)
          {
            current.Name = null;
          }
          break;

        case "telecom":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"RelatedPerson error reading 'telecom' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Telecom = new List<ContactPoint>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.ContactPoint v_Telecom = new Hl7.Fhir.Model.ContactPoint();
            v_Telecom.DeserializeJson(ref reader, options);
            current.Telecom.Add(v_Telecom);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Telecom.Count == 0)
          {
            current.Telecom = null;
          }
          break;

        case "gender":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.GenderElement = new Code<Hl7.Fhir.Model.AdministrativeGender>();
            reader.Skip();
          }
          else
          {
            current.GenderElement = new Code<Hl7.Fhir.Model.AdministrativeGender>(Hl7.Fhir.Utility.EnumUtility.ParseLiteral<Hl7.Fhir.Model.AdministrativeGender>(reader.GetString()));
          }
          break;

        case "_gender":
          if (current.GenderElement == null) { current.GenderElement = new Code<Hl7.Fhir.Model.AdministrativeGender>(); }
          ((Hl7.Fhir.Model.Element)current.GenderElement).DeserializeJson(ref reader, options);
          break;

        case "birthDate":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.BirthDateElement = new Date();
            reader.Skip();
          }
          else
          {
            current.BirthDateElement = new Date(reader.GetString());
          }
          break;

        case "_birthDate":
          if (current.BirthDateElement == null) { current.BirthDateElement = new Date(); }
          ((Hl7.Fhir.Model.Element)current.BirthDateElement).DeserializeJson(ref reader, options);
          break;

        case "address":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"RelatedPerson error reading 'address' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Address = new List<Address>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Address v_Address = new Hl7.Fhir.Model.Address();
            v_Address.DeserializeJson(ref reader, options);
            current.Address.Add(v_Address);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Address.Count == 0)
          {
            current.Address = null;
          }
          break;

        case "photo":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"RelatedPerson error reading 'photo' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Photo = new List<Attachment>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.Attachment v_Photo = new Hl7.Fhir.Model.Attachment();
            v_Photo.DeserializeJson(ref reader, options);
            current.Photo.Add(v_Photo);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Photo.Count == 0)
          {
            current.Photo = null;
          }
          break;

        case "period":
          current.Period = new Hl7.Fhir.Model.Period();
          ((Hl7.Fhir.Model.Period)current.Period).DeserializeJson(ref reader, options);
          break;

        case "communication":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException($"RelatedPerson error reading 'communication' expected StartArray, found {reader.TokenType}! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
          }

          current.Communication = new List<RelatedPerson.CommunicationComponent>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            Hl7.Fhir.Model.RelatedPerson.CommunicationComponent v_Communication = new Hl7.Fhir.Model.RelatedPerson.CommunicationComponent();
            v_Communication.DeserializeJson(ref reader, options);
            current.Communication.Add(v_Communication);

            if (!reader.Read())
            {
              throw new JsonException();
            }
            if (reader.TokenType == JsonTokenType.EndObject) { reader.Read(); }
          }

          if (current.Communication.Count == 0)
          {
            current.Communication = null;
          }
          break;

        // Complex: RelatedPerson, Export: RelatedPerson, Base: DomainResource
        default:
          ((Hl7.Fhir.Model.DomainResource)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Serialize a FHIR RelatedPerson#Communication into JSON
    /// </summary>
    public static void SerializeJson(this RelatedPerson.CommunicationComponent current, Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject) { writer.WriteStartObject(); }
      // Component: RelatedPerson#Communication, Export: CommunicationComponent, Base: BackboneElement (BackboneElement)
      ((Hl7.Fhir.Model.BackboneElement)current).SerializeJson(writer, options, false);

      writer.WritePropertyName("language");
      current.Language.SerializeJson(writer, options);

      if (current.PreferredElement != null)
      {
        if (current.PreferredElement.Value != null)
        {
          writer.WriteBoolean("preferred",(bool)current.PreferredElement.Value);
        }
        if (current.PreferredElement.HasExtensions() || (!string.IsNullOrEmpty(current.PreferredElement.ElementId)))
        {
          JsonStreamUtilities.SerializeExtensionList(writer,options,"_preferred",false,current.PreferredElement.Extension,current.PreferredElement.ElementId);
        }
      }

      if (includeStartObject) { writer.WriteEndObject(); }
    }

    /// <summary>
    /// Deserialize JSON into a FHIR RelatedPerson#Communication
    /// </summary>
    public static void DeserializeJson(this RelatedPerson.CommunicationComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options)
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
          if (Hl7.Fhir.Serialization.FhirSerializerOptions.Debug) { Console.WriteLine($"RelatedPerson.CommunicationComponent >>> RelatedPerson#Communication.{propertyName}, depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}"); }
          reader.Read();
          current.DeserializeJsonProperty(ref reader, options, propertyName);
        }
      }

      throw new JsonException($"RelatedPerson.CommunicationComponent: invalid state! depth: {reader.CurrentDepth}, pos: {reader.BytesConsumed}");
    }

    /// <summary>
    /// Deserialize JSON into a FHIR RelatedPerson#Communication
    /// </summary>
    public static void DeserializeJsonProperty(this RelatedPerson.CommunicationComponent current, ref Utf8JsonReader reader, JsonSerializerOptions options, string propertyName)
    {
      switch (propertyName)
      {
        case "language":
          current.Language = new Hl7.Fhir.Model.CodeableConcept();
          ((Hl7.Fhir.Model.CodeableConcept)current.Language).DeserializeJson(ref reader, options);
          break;

        case "preferred":
          if (reader.TokenType == JsonTokenType.Null)
          {
            current.PreferredElement = new FhirBoolean();
            reader.Skip();
          }
          else
          {
            current.PreferredElement = new FhirBoolean(reader.GetBoolean());
          }
          break;

        case "_preferred":
          if (current.PreferredElement == null) { current.PreferredElement = new FhirBoolean(); }
          ((Hl7.Fhir.Model.Element)current.PreferredElement).DeserializeJson(ref reader, options);
          break;

        // Complex: communication, Export: CommunicationComponent, Base: BackboneElement
        default:
          ((Hl7.Fhir.Model.BackboneElement)current).DeserializeJsonProperty(ref reader, options, propertyName);
          break;
      }
    }

    /// <summary>
    /// Resource converter to support Sytem.Text.Json interop.
    /// </summary>
    public class RelatedPersonJsonConverter : JsonConverter<RelatedPerson>
    {
      /// <summary>
      /// Writes a specified value as JSON.
      /// </summary>
      public override void Write(Utf8JsonWriter writer, RelatedPerson value, JsonSerializerOptions options)
      {
        value.SerializeJson(writer, options, true);
        writer.Flush();
      }
      /// <summary>
      /// Reads and converts the JSON to a typed object.
      /// </summary>
      public override RelatedPerson Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
      {
        RelatedPerson target = new RelatedPerson();
        target.DeserializeJson(ref reader, options);
        return target;
      }
    }
  }

}

// end of file
