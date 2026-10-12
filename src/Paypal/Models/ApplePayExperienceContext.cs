using System.Text.Json.Serialization;
using Paypal.Core.Models;
using Paypal.Core.Validation;
using Paypal.Core.Validation.Attributes;

namespace Paypal.Models;

/// <summary>
/// Customizes the payer experience during the approval process for the payment.
/// </summary>
public record ApplePayExperienceContext
{
    /// <summary>
    /// Describes the URL.
    /// </summary>
    [JsonPropertyName("return_url")]
    [Format(FormatKind.Uri)]
    public required string ReturnUrl { get; init; }

    /// <summary>
    /// Describes the URL.
    /// </summary>
    [JsonPropertyName("cancel_url")]
    [Format(FormatKind.Uri)]
    public required string CancelUrl { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
