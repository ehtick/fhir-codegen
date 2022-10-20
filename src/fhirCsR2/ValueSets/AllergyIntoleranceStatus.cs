// <auto-generated />
// Built from: hl7.fhir.r2.core version: 1.0.2
  // Option: "NAMESPACE" = "fhirCsR2"

using fhirCsR2.Models;

namespace fhirCsR2.ValueSets
{
  /// <summary>
  /// Assertion about certainty associated with a propensity, or potential risk, of a reaction to the identified Substance.
  /// </summary>
  public static class AllergyIntoleranceStatusCodes
  {
    /// <summary>
    /// An active record of a reaction to the identified Substance.
    /// </summary>
    public static readonly Coding Active = new Coding
    {
      Code = "active",
      Display = "Active",
      System = "http://hl7.org/fhir/allergy-intolerance-status"
    };
    /// <summary>
    /// A high level of certainty about the propensity for a reaction to the identified Substance, which may include clinical evidence by testing or rechallenge.
    /// </summary>
    public static readonly Coding Confirmed = new Coding
    {
      Code = "confirmed",
      Display = "Confirmed",
      System = "http://hl7.org/fhir/allergy-intolerance-status"
    };
    /// <summary>
    /// The statement was entered in error and is not valid.
    /// </summary>
    public static readonly Coding EnteredInError = new Coding
    {
      Code = "entered-in-error",
      Display = "Entered In Error",
      System = "http://hl7.org/fhir/allergy-intolerance-status"
    };
    /// <summary>
    /// An inactive record of a reaction to the identified Substance.
    /// </summary>
    public static readonly Coding Inactive = new Coding
    {
      Code = "inactive",
      Display = "Inactive",
      System = "http://hl7.org/fhir/allergy-intolerance-status"
    };
    /// <summary>
    /// A propensity for a reaction to the identified Substance has been disproven with a high level of clinical certainty, which may include testing or rechallenge, and is refuted.
    /// </summary>
    public static readonly Coding Refuted = new Coding
    {
      Code = "refuted",
      Display = "Refuted",
      System = "http://hl7.org/fhir/allergy-intolerance-status"
    };
    /// <summary>
    /// A reaction to the identified Substance has been clinically reassessed by testing or rechallenge and considered to be resolved.
    /// </summary>
    public static readonly Coding Resolved = new Coding
    {
      Code = "resolved",
      Display = "Resolved",
      System = "http://hl7.org/fhir/allergy-intolerance-status"
    };
    /// <summary>
    /// A low level of certainty about the propensity for a reaction to the identified Substance.
    /// </summary>
    public static readonly Coding Unconfirmed = new Coding
    {
      Code = "unconfirmed",
      Display = "Unconfirmed",
      System = "http://hl7.org/fhir/allergy-intolerance-status"
    };

    /// <summary>
    /// Literal for code: Active
    /// </summary>
    public const string LiteralActive = "active";

    /// <summary>
    /// Literal for code: AllergyIntoleranceStatusActive
    /// </summary>
    public const string LiteralAllergyIntoleranceStatusActive = "http://hl7.org/fhir/allergy-intolerance-status#active";

    /// <summary>
    /// Literal for code: Confirmed
    /// </summary>
    public const string LiteralConfirmed = "confirmed";

    /// <summary>
    /// Literal for code: AllergyIntoleranceStatusConfirmed
    /// </summary>
    public const string LiteralAllergyIntoleranceStatusConfirmed = "http://hl7.org/fhir/allergy-intolerance-status#confirmed";

    /// <summary>
    /// Literal for code: EnteredInError
    /// </summary>
    public const string LiteralEnteredInError = "entered-in-error";

    /// <summary>
    /// Literal for code: AllergyIntoleranceStatusEnteredInError
    /// </summary>
    public const string LiteralAllergyIntoleranceStatusEnteredInError = "http://hl7.org/fhir/allergy-intolerance-status#entered-in-error";

    /// <summary>
    /// Literal for code: Inactive
    /// </summary>
    public const string LiteralInactive = "inactive";

    /// <summary>
    /// Literal for code: AllergyIntoleranceStatusInactive
    /// </summary>
    public const string LiteralAllergyIntoleranceStatusInactive = "http://hl7.org/fhir/allergy-intolerance-status#inactive";

    /// <summary>
    /// Literal for code: Refuted
    /// </summary>
    public const string LiteralRefuted = "refuted";

    /// <summary>
    /// Literal for code: AllergyIntoleranceStatusRefuted
    /// </summary>
    public const string LiteralAllergyIntoleranceStatusRefuted = "http://hl7.org/fhir/allergy-intolerance-status#refuted";

    /// <summary>
    /// Literal for code: Resolved
    /// </summary>
    public const string LiteralResolved = "resolved";

    /// <summary>
    /// Literal for code: AllergyIntoleranceStatusResolved
    /// </summary>
    public const string LiteralAllergyIntoleranceStatusResolved = "http://hl7.org/fhir/allergy-intolerance-status#resolved";

    /// <summary>
    /// Literal for code: Unconfirmed
    /// </summary>
    public const string LiteralUnconfirmed = "unconfirmed";

    /// <summary>
    /// Literal for code: AllergyIntoleranceStatusUnconfirmed
    /// </summary>
    public const string LiteralAllergyIntoleranceStatusUnconfirmed = "http://hl7.org/fhir/allergy-intolerance-status#unconfirmed";

    /// <summary>
    /// Dictionary for looking up AllergyIntoleranceStatus Codings based on Codes
    /// </summary>
    public static Dictionary<string, Coding> Values = new Dictionary<string, Coding>() {
      { "active", Active }, 
      { "http://hl7.org/fhir/allergy-intolerance-status#active", Active }, 
      { "confirmed", Confirmed }, 
      { "http://hl7.org/fhir/allergy-intolerance-status#confirmed", Confirmed }, 
      { "entered-in-error", EnteredInError }, 
      { "http://hl7.org/fhir/allergy-intolerance-status#entered-in-error", EnteredInError }, 
      { "inactive", Inactive }, 
      { "http://hl7.org/fhir/allergy-intolerance-status#inactive", Inactive }, 
      { "refuted", Refuted }, 
      { "http://hl7.org/fhir/allergy-intolerance-status#refuted", Refuted }, 
      { "resolved", Resolved }, 
      { "http://hl7.org/fhir/allergy-intolerance-status#resolved", Resolved }, 
      { "unconfirmed", Unconfirmed }, 
      { "http://hl7.org/fhir/allergy-intolerance-status#unconfirmed", Unconfirmed }, 
    };
  };
}
