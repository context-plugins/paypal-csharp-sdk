using System.Text.Json.Serialization;
using Paypal.Core.Enum;

namespace Paypal.Models.Enums;

/// <summary>
/// The location from which the shipping address is derived., The location from which the shipping address is derived., The shipping preference. This only applies to PayPal payment source., The shipping preference. This only applies to PayPal payment source., The location from which the shipping address is derived., DEPRECATED. DEPRECATED. The shipping preference: Displays the shipping address to the customer. Enables the customer to choose an address on the PayPal site. Restricts the customer from changing the address during the payment-approval process. .  The fields in <c>application_context</c> are now available in the <c>experience_context</c> object under the <c>payment_source</c> which supports them (eg. <c>payment_source.paypal.experience_context.shipping_preference</c>). Please specify this field in the <c>experience_context</c> object instead of the <c>application_context</c> object., The location from which the shipping address is derived., The location from which the shipping address is derived., The shipping preference. This only applies to PayPal payment source., The shipping preference. This only applies to PayPal payment source.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<ApplicationContextShippingPreference>))]
public sealed record ApplicationContextShippingPreference : StringEnum<ApplicationContextShippingPreference>
{
    private ApplicationContextShippingPreference(string value) : base(value)
    {
    }

    /// <summary>
    /// Get the customer-provided shipping address on the PayPal site.
    /// </summary>
    public static readonly ApplicationContextShippingPreference GetFromFile = new("GET_FROM_FILE");

    /// <summary>
    /// Redacts the shipping address from the PayPal site. Recommended for digital goods.
    /// </summary>
    public static readonly ApplicationContextShippingPreference NoShipping = new("NO_SHIPPING");

    /// <summary>
    /// Get the merchant-provided address. The customer cannot change this address on the PayPal site. If merchant does not pass an address, customer can choose the address on PayPal pages.
    /// </summary>
    public static readonly ApplicationContextShippingPreference SetProvidedAddress = new("SET_PROVIDED_ADDRESS");

    public static ApplicationContextShippingPreference FromValue(string value) => FromValueCore(value);
}
