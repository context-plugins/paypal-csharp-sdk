using System.Text.Json.Serialization;
using Paypal.Core.Models;

namespace Paypal.Models;

/// <summary>
/// Additional attributes associated with the use of Apple Pay.
/// </summary>
public record ApplePayAttributesResponse
{
    /// <summary>
    /// The details about a saved payment source.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("vault")]
    public VaultResponse? Vault { get; init; }

    [JsonExtensionData]
    public AdditionalProperties AdditionalProperties { get; init; } = [];
}
