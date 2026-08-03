using System.Text.Json.Serialization;
using Paypal.Models.Enums;

namespace Paypal.Models;

/// <summary>
/// The customer and merchant payment preferences.
/// </summary>
public record PaymentMethod
{
    /// <summary>
    /// The merchant-preferred payment methods.
    /// </summary>
    [JsonPropertyName("payee_preferred")]
    public PayeePaymentMethodPreference? PayeePreferred { get; init; } = PayeePaymentMethodPreference.Unrestricted;
}
