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
  /// Details where to send notifications when resources are received that meet the criteria.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<SubscriptionChannel>))]
  public class SubscriptionChannel : BackboneElement,  IFhirJsonSerializable {
    /// <summary>
    /// The uri that describes the actual end-point to send messages to.
    /// </summary>
    public string Endpoint { get; set; }
    /// <summary>
    /// Extension container element for Endpoint
    /// </summary>
    public Element _Endpoint { get; set; }
    /// <summary>
    /// Additional headers / information to send as part of the notification.
    /// </summary>
    public string Header { get; set; }
    /// <summary>
    /// Extension container element for Header
    /// </summary>
    public Element _Header { get; set; }
    /// <summary>
    /// The mime type to send the payload in - either application/xml+fhir, or application/json+fhir. If the mime type is blank, then there is no payload in the notification, just a notification.
    /// </summary>
    public string Payload { get; set; }
    /// <summary>
    /// Extension container element for Payload
    /// </summary>
    public Element _Payload { get; set; }
    /// <summary>
    /// The type of channel to send notifications on.
    /// </summary>
    public string Type { get; set; }
    /// <summary>
    /// Extension container element for Type
    /// </summary>
    public Element _Type { get; set; }
    /// <summary>
    /// Serialize to a JSON object
    /// </summary>
    public new void SerializeJson(Utf8JsonWriter writer, JsonSerializerOptions options, bool includeStartObject = true)
    {
      if (includeStartObject)
      {
        writer.WriteStartObject();
      }
      ((fhirCsR2.Models.BackboneElement)this).SerializeJson(writer, options, false);

      if (!string.IsNullOrEmpty(Type))
      {
        writer.WriteString("type", (string)Type!);
      }

      if (_Type != null)
      {
        writer.WritePropertyName("_type");
        _Type.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Endpoint))
      {
        writer.WriteString("endpoint", (string)Endpoint!);
      }

      if (_Endpoint != null)
      {
        writer.WritePropertyName("_endpoint");
        _Endpoint.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Payload))
      {
        writer.WriteString("payload", (string)Payload!);
      }

      if (_Payload != null)
      {
        writer.WritePropertyName("_payload");
        _Payload.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Header))
      {
        writer.WriteString("header", (string)Header!);
      }

      if (_Header != null)
      {
        writer.WritePropertyName("_header");
        _Header.SerializeJson(writer, options);
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
        case "endpoint":
          Endpoint = reader.GetString();
          break;

        case "_endpoint":
          _Endpoint = new fhirCsR2.Models.Element();
          _Endpoint.DeserializeJson(ref reader, options);
          break;

        case "header":
          Header = reader.GetString();
          break;

        case "_header":
          _Header = new fhirCsR2.Models.Element();
          _Header.DeserializeJson(ref reader, options);
          break;

        case "payload":
          Payload = reader.GetString();
          break;

        case "_payload":
          _Payload = new fhirCsR2.Models.Element();
          _Payload.DeserializeJson(ref reader, options);
          break;

        case "type":
          Type = reader.GetString();
          break;

        case "_type":
          _Type = new fhirCsR2.Models.Element();
          _Type.DeserializeJson(ref reader, options);
          break;

        default:
          ((fhirCsR2.Models.BackboneElement)this).DeserializeJsonProperty(ref reader, options, propertyName);
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
  /// Code Values for the Subscription.channel.type field
  /// </summary>
  public static class SubscriptionChannelTypeCodes {
    public const string REST_HOOK = "rest-hook";
    public const string WEBSOCKET = "websocket";
    public const string EMAIL = "email";
    public const string SMS = "sms";
    public const string MESSAGE = "message";
    public static HashSet<string> Values = new HashSet<string>() {
      "rest-hook",
      "websocket",
      "email",
      "sms",
      "message",
    };
  }
  /// <summary>
  /// The subscription resource is used to define a push based subscription from a server to another system. Once a subscription is registered with the server, the server checks every resource that is created or updated, and if the resource matches the given criteria, it sends a message on the defined "channel" so that another system is able to take an appropriate action.
  /// </summary>
  [JsonConverter(typeof(fhirCsR2.Serialization.JsonStreamComponentConverter<Subscription>))]
  public class Subscription : DomainResource,  IFhirJsonSerializable {
    /// <summary>
    /// Resource Type Name
    /// </summary>
    public override string ResourceType => "Subscription";
    /// <summary>
    /// Details where to send notifications when resources are received that meet the criteria.
    /// </summary>
    public SubscriptionChannel Channel { get; set; }
    /// <summary>
    /// Contact details for a human to contact about the subscription. The primary use of this for system administrator troubleshooting.
    /// </summary>
    public List<ContactPoint> Contact { get; set; }
    /// <summary>
    /// The rules that the server should use to determine when to generate notifications for this subscription.
    /// </summary>
    public string Criteria { get; set; }
    /// <summary>
    /// Extension container element for Criteria
    /// </summary>
    public Element _Criteria { get; set; }
    /// <summary>
    /// The time for the server to turn the subscription off.
    /// </summary>
    public string End { get; set; }
    /// <summary>
    /// Extension container element for End
    /// </summary>
    public Element _End { get; set; }
    /// <summary>
    /// A record of the last error that occurred when the server processed a notification.
    /// </summary>
    public string Error { get; set; }
    /// <summary>
    /// Extension container element for Error
    /// </summary>
    public Element _Error { get; set; }
    /// <summary>
    /// A description of why this subscription is defined.
    /// </summary>
    public string Reason { get; set; }
    /// <summary>
    /// Extension container element for Reason
    /// </summary>
    public Element _Reason { get; set; }
    /// <summary>
    /// The status of the subscription, which marks the server state for managing the subscription.
    /// </summary>
    public string Status { get; set; }
    /// <summary>
    /// Extension container element for Status
    /// </summary>
    public Element _Status { get; set; }
    /// <summary>
    /// A tag to add to any resource that matches the criteria, after the subscription is processed.
    /// </summary>
    public List<Coding> Tag { get; set; }
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

      if (!string.IsNullOrEmpty(Criteria))
      {
        writer.WriteString("criteria", (string)Criteria!);
      }

      if (_Criteria != null)
      {
        writer.WritePropertyName("_criteria");
        _Criteria.SerializeJson(writer, options);
      }

      if ((Contact != null) && (Contact.Count != 0))
      {
        writer.WritePropertyName("contact");
        writer.WriteStartArray();

        foreach (ContactPoint valContact in Contact)
        {
          valContact.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
      }

      if (!string.IsNullOrEmpty(Reason))
      {
        writer.WriteString("reason", (string)Reason!);
      }

      if (_Reason != null)
      {
        writer.WritePropertyName("_reason");
        _Reason.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Status))
      {
        writer.WriteString("status", (string)Status!);
      }

      if (_Status != null)
      {
        writer.WritePropertyName("_status");
        _Status.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(Error))
      {
        writer.WriteString("error", (string)Error!);
      }

      if (_Error != null)
      {
        writer.WritePropertyName("_error");
        _Error.SerializeJson(writer, options);
      }

      if (Channel != null)
      {
        writer.WritePropertyName("channel");
        Channel.SerializeJson(writer, options);
      }

      if (!string.IsNullOrEmpty(End))
      {
        writer.WriteString("end", (string)End!);
      }

      if (_End != null)
      {
        writer.WritePropertyName("_end");
        _End.SerializeJson(writer, options);
      }

      if ((Tag != null) && (Tag.Count != 0))
      {
        writer.WritePropertyName("tag");
        writer.WriteStartArray();

        foreach (Coding valTag in Tag)
        {
          valTag.SerializeJson(writer, options, true);
        }

        writer.WriteEndArray();
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
        case "channel":
          Channel = new fhirCsR2.Models.SubscriptionChannel();
          Channel.DeserializeJson(ref reader, options);
          break;

        case "contact":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Contact = new List<ContactPoint>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.ContactPoint objContact = new fhirCsR2.Models.ContactPoint();
            objContact.DeserializeJson(ref reader, options);
            Contact.Add(objContact);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Contact.Count == 0)
          {
            Contact = null;
          }

          break;

        case "criteria":
          Criteria = reader.GetString();
          break;

        case "_criteria":
          _Criteria = new fhirCsR2.Models.Element();
          _Criteria.DeserializeJson(ref reader, options);
          break;

        case "end":
          End = reader.GetString();
          break;

        case "_end":
          _End = new fhirCsR2.Models.Element();
          _End.DeserializeJson(ref reader, options);
          break;

        case "error":
          Error = reader.GetString();
          break;

        case "_error":
          _Error = new fhirCsR2.Models.Element();
          _Error.DeserializeJson(ref reader, options);
          break;

        case "reason":
          Reason = reader.GetString();
          break;

        case "_reason":
          _Reason = new fhirCsR2.Models.Element();
          _Reason.DeserializeJson(ref reader, options);
          break;

        case "status":
          Status = reader.GetString();
          break;

        case "_status":
          _Status = new fhirCsR2.Models.Element();
          _Status.DeserializeJson(ref reader, options);
          break;

        case "tag":
          if ((reader.TokenType != JsonTokenType.StartArray) || (!reader.Read()))
          {
            throw new JsonException();
          }

          Tag = new List<Coding>();

          while (reader.TokenType != JsonTokenType.EndArray)
          {
            fhirCsR2.Models.Coding objTag = new fhirCsR2.Models.Coding();
            objTag.DeserializeJson(ref reader, options);
            Tag.Add(objTag);

            if (!reader.Read())
            {
              throw new JsonException();
            }
          }

          if (Tag.Count == 0)
          {
            Tag = null;
          }

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
  /// Code Values for the Subscription.status field
  /// </summary>
  public static class SubscriptionStatusCodes {
    public const string REQUESTED = "requested";
    public const string ACTIVE = "active";
    public const string ERROR = "error";
    public const string OFF = "off";
    public static HashSet<string> Values = new HashSet<string>() {
      "requested",
      "active",
      "error",
      "off",
    };
  }
}
