using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Paypal.Models;

/// <summary>
/// The merchant preferences for a subscription.
/// </summary>
public record MerchantPreferences1
{
    /// <summary>
    /// The URL where the customer is redirected after the customer approves the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("return_url")]
    [StringLength(4000, MinimumLength = 10)]
    public string? ReturnUrl { get; init; }

    /// <summary>
    /// The URL where the customer is redirected after the customer cancels the payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("cancel_url")]
    [StringLength(4000, MinimumLength = 10)]
    public string? CancelUrl { get; init; }
}
