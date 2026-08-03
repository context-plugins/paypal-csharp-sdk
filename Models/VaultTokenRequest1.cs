using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Paypal.Models;

/// <summary>
/// The Tokenized Payment Source representing a Request to Vault a Token.
/// </summary>
public record VaultTokenRequest1
{
    /// <summary>
    /// The PayPal-generated ID for the token.
    /// </summary>
    [JsonPropertyName("id")]
    [StringLength(255, MinimumLength = 1)]
    [RegularExpression("^[0-9A-Za-z_-]+$")]
    public required string Id { get; init; }

    /// <summary>
    /// The tokenization method that generated the ID.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; } = "SETUP_TOKEN";
}
