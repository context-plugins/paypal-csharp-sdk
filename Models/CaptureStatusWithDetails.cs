using System.Text.Json.Serialization;
using Paypal.Models.Enums;

namespace Paypal.Models;

/// <summary>
/// The status and status details of a captured payment.
/// </summary>
public record CaptureStatusWithDetails
{
    /// <summary>
    /// The status of the captured payment.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status")]
    public CaptureStatus? Status { get; init; }

    /// <summary>
    /// The details of the captured payment status.
    /// </summary>
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    [JsonPropertyName("status_details")]
    public CaptureStatusDetails? StatusDetails { get; init; }
}
