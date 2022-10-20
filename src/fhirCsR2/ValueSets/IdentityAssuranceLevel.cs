// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using fhirCsR2.Models;

namespace fhirCsR2.ValueSets
{
  /// <summary>
  /// The level of confidence that this link represents the same actual person, based on NIST Authentication Levels.
  /// </summary>
  public static class IdentityAssuranceLevelCodes
  {
    /// <summary>
    /// Little or no confidence in the asserted identity's accuracy.
    /// </summary>
    public static readonly Coding Level1 = new Coding
    {
      Code = "level1",
      Display = "Level 1",
      System = "http://hl7.org/fhir/identity-assuranceLevel"
    };
    /// <summary>
    /// Some confidence in the asserted identity's accuracy.
    /// </summary>
    public static readonly Coding Level2 = new Coding
    {
      Code = "level2",
      Display = "Level 2",
      System = "http://hl7.org/fhir/identity-assuranceLevel"
    };
    /// <summary>
    /// High confidence in the asserted identity's accuracy.
    /// </summary>
    public static readonly Coding Level3 = new Coding
    {
      Code = "level3",
      Display = "Level 3",
      System = "http://hl7.org/fhir/identity-assuranceLevel"
    };
    /// <summary>
    /// Very high confidence in the asserted identity's accuracy.
    /// </summary>
    public static readonly Coding Level4 = new Coding
    {
      Code = "level4",
      Display = "Level 4",
      System = "http://hl7.org/fhir/identity-assuranceLevel"
    };

    /// <summary>
    /// Literal for code: Level1
    /// </summary>
    public const string LiteralLevel1 = "level1";

    /// <summary>
    /// Literal for code: IdentityAssuranceLevelLevel1
    /// </summary>
    public const string LiteralIdentityAssuranceLevelLevel1 = "http://hl7.org/fhir/identity-assuranceLevel#level1";

    /// <summary>
    /// Literal for code: Level2
    /// </summary>
    public const string LiteralLevel2 = "level2";

    /// <summary>
    /// Literal for code: IdentityAssuranceLevelLevel2
    /// </summary>
    public const string LiteralIdentityAssuranceLevelLevel2 = "http://hl7.org/fhir/identity-assuranceLevel#level2";

    /// <summary>
    /// Literal for code: Level3
    /// </summary>
    public const string LiteralLevel3 = "level3";

    /// <summary>
    /// Literal for code: IdentityAssuranceLevelLevel3
    /// </summary>
    public const string LiteralIdentityAssuranceLevelLevel3 = "http://hl7.org/fhir/identity-assuranceLevel#level3";

    /// <summary>
    /// Literal for code: Level4
    /// </summary>
    public const string LiteralLevel4 = "level4";

    /// <summary>
    /// Literal for code: IdentityAssuranceLevelLevel4
    /// </summary>
    public const string LiteralIdentityAssuranceLevelLevel4 = "http://hl7.org/fhir/identity-assuranceLevel#level4";

    /// <summary>
    /// Dictionary for looking up IdentityAssuranceLevel Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "level1", Level1 }, 
      { "http://hl7.org/fhir/identity-assuranceLevel#level1", Level1 }, 
      { "level2", Level2 }, 
      { "http://hl7.org/fhir/identity-assuranceLevel#level2", Level2 }, 
      { "level3", Level3 }, 
      { "http://hl7.org/fhir/identity-assuranceLevel#level3", Level3 }, 
      { "level4", Level4 }, 
      { "http://hl7.org/fhir/identity-assuranceLevel#level4", Level4 }, 
    };
  };
}
