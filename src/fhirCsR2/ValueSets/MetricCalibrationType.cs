// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using fhirCsR2.Models;

namespace fhirCsR2.ValueSets
{
  /// <summary>
  /// Describes the type of a metric calibration.
  /// </summary>
  public static class MetricCalibrationTypeCodes
  {
    /// <summary>
    /// TODO
    /// </summary>
    public static readonly Coding Gain = new Coding
    {
      Code = "gain",
      Display = "Gain",
      System = "http://hl7.org/fhir/metric-calibration-type"
    };
    /// <summary>
    /// TODO
    /// </summary>
    public static readonly Coding Offset = new Coding
    {
      Code = "offset",
      Display = "Offset",
      System = "http://hl7.org/fhir/metric-calibration-type"
    };
    /// <summary>
    /// TODO
    /// </summary>
    public static readonly Coding TwoPoint = new Coding
    {
      Code = "two-point",
      Display = "Two Point",
      System = "http://hl7.org/fhir/metric-calibration-type"
    };
    /// <summary>
    /// TODO
    /// </summary>
    public static readonly Coding Unspecified = new Coding
    {
      Code = "unspecified",
      Display = "Unspecified",
      System = "http://hl7.org/fhir/metric-calibration-type"
    };

    /// <summary>
    /// Literal for code: Gain
    /// </summary>
    public const string LiteralGain = "gain";

    /// <summary>
    /// Literal for code: MetricCalibrationTypeGain
    /// </summary>
    public const string LiteralMetricCalibrationTypeGain = "http://hl7.org/fhir/metric-calibration-type#gain";

    /// <summary>
    /// Literal for code: Offset
    /// </summary>
    public const string LiteralOffset = "offset";

    /// <summary>
    /// Literal for code: MetricCalibrationTypeOffset
    /// </summary>
    public const string LiteralMetricCalibrationTypeOffset = "http://hl7.org/fhir/metric-calibration-type#offset";

    /// <summary>
    /// Literal for code: TwoPoint
    /// </summary>
    public const string LiteralTwoPoint = "two-point";

    /// <summary>
    /// Literal for code: MetricCalibrationTypeTwoPoint
    /// </summary>
    public const string LiteralMetricCalibrationTypeTwoPoint = "http://hl7.org/fhir/metric-calibration-type#two-point";

    /// <summary>
    /// Literal for code: Unspecified
    /// </summary>
    public const string LiteralUnspecified = "unspecified";

    /// <summary>
    /// Literal for code: MetricCalibrationTypeUnspecified
    /// </summary>
    public const string LiteralMetricCalibrationTypeUnspecified = "http://hl7.org/fhir/metric-calibration-type#unspecified";

    /// <summary>
    /// Dictionary for looking up MetricCalibrationType Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "gain", Gain }, 
      { "http://hl7.org/fhir/metric-calibration-type#gain", Gain }, 
      { "offset", Offset }, 
      { "http://hl7.org/fhir/metric-calibration-type#offset", Offset }, 
      { "two-point", TwoPoint }, 
      { "http://hl7.org/fhir/metric-calibration-type#two-point", TwoPoint }, 
      { "unspecified", Unspecified }, 
      { "http://hl7.org/fhir/metric-calibration-type#unspecified", Unspecified }, 
    };
  };
}
