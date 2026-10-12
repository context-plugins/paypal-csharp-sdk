using System.Text.Json.Serialization;
using Paypal.Core.Models;

namespace Paypal.Models;

/// <summary>
/// The authorization of an order request.
/// </summary>
public record OrderAuthorizeRequest
{
    /// <summary>
    /// The payment source definition.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("payment_source")]
    public OrderAuthorizeRequestPaymentSource? PaymentSource { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
