using System.Text.Json.Serialization;
using Paypal.Core.Models;

namespace Paypal.Models;

/// <summary>
/// Completes an capture payment for an order.
/// </summary>
public record OrderCaptureRequest
{
    /// <summary>
    /// The payment source definition.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_source")]
    public OrderCaptureRequestPaymentSource? PaymentSource { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
