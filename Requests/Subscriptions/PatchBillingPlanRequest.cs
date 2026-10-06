using System.Collections.Generic;
using Paypal.Models;

namespace Paypal.Requests.Subscriptions;

/// <summary>
/// The inputs of the PatchBillingPlan operation.
/// </summary>
public sealed record PatchBillingPlanRequest
{
    /// <summary>
    /// The ID of the plan.
    /// </summary>
    public required string Id { get; init; }

    public IReadOnlyList<Patch>? Body { get; init; }
}
