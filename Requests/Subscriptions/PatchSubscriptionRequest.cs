using System.Collections.Generic;
using Paypal.Models;

namespace Paypal.Requests.Subscriptions;

/// <summary>
/// The inputs of the PatchSubscription operation.
/// </summary>
public sealed record PatchSubscriptionRequest
{
    /// <summary>
    /// The ID for the subscription.
    /// </summary>
    public required string Id { get; init; }

    public IReadOnlyList<Patch>? Body { get; init; }
}
