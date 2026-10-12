using System.Text.Json.Serialization;
using Paypal.Core.Models;
using Paypal.Models.Enums;

namespace Paypal.Models;

/// <summary>
/// The API caller can opt in to verify the card through PayPal offered verification services (e.g. Smart Dollar Auth, 3DS).
/// </summary>
public record CardVerification
{
    /// <summary>
    /// The method used for card verification.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("method")]
    public OrdersCardVerificationMethod? Method { get; init; } = OrdersCardVerificationMethod.ScaWhenRequired;

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
