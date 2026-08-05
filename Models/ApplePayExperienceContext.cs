using System.Text.Json.Serialization;

namespace PayPalServerSdk.Models;

/// <summary>
/// Customizes the payer experience during the approval process for the payment.
/// </summary>
public record ApplePayExperienceContext
{
    /// <summary>
    /// Describes the URL.
    /// </summary>
    [JsonPropertyName("return_url")]
    public required string ReturnUrl { get; init; }

    /// <summary>
    /// Describes the URL.
    /// </summary>
    [JsonPropertyName("cancel_url")]
    public required string CancelUrl { get; init; }
}
