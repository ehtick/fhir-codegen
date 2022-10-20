// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using fhirCsR2.Models;

namespace fhirCsR2.ValueSets
{
  /// <summary>
  /// The availability status of the device.
  /// </summary>
  public static class DevicestatusCodes
  {
    /// <summary>
    /// The Device is available for use.
    /// </summary>
    public static readonly Coding Available = new Coding
    {
      Code = "available",
      Display = "Available",
      System = "http://hl7.org/fhir/devicestatus"
    };
    /// <summary>
    /// The Device was entered in error and voided.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered in Error",
      System = "http://hl7.org/fhir/devicestatus"
    };
    /// <summary>
    /// The Device is no longer available for use (e.g. lost, expired, damaged).
    /// </summary>
    public static readonly Coding NotAvailable = new Coding
    {
      Code = "not-available",
      Display = "Not Available",
      System = "http://hl7.org/fhir/devicestatus"
    };

    /// <summary>
    /// Literal for code: Available
    /// </summary>
    public const string LiteralAvailable = "available";

    /// <summary>
    /// Literal for code: DevicestatusAvailable
    /// </summary>
    public const string LiteralDevicestatusAvailable = "http://hl7.org/fhir/devicestatus#available";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: DevicestatusEnteredInError
    /// </summary>
    public const string LiteralDevicestatusEnteredInError = "http://hl7.org/fhir/devicestatus#entered-in-error";

    /// <summary>
    /// Literal for code: NotAvailable
    /// </summary>
    public const string LiteralNotAvailable = "not-available";

    /// <summary>
    /// Literal for code: DevicestatusNotAvailable
    /// </summary>
    public const string LiteralDevicestatusNotAvailable = "http://hl7.org/fhir/devicestatus#not-available";

    /// <summary>
    /// Dictionary for looking up Devicestatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "available", Available }, 
      { "http://hl7.org/fhir/devicestatus#available", Available }, 
      { "entered-in-error", EnteredInError }, 
      { "http://hl7.org/fhir/devicestatus#entered-in-error", EnteredInError }, 
      { "not-available", NotAvailable }, 
      { "http://hl7.org/fhir/devicestatus#not-available", NotAvailable }, 
    };
  };
}
