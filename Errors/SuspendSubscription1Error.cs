using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Paypal.Core.ErrorResponse;
using Paypal.Core.Models;
using Paypal.Models;

namespace Paypal.Errors;

public sealed class SuspendSubscription1Error : ApiError
{
    private readonly Optional<SubscriptionError> _subscriptionErrorValue;

    private SuspendSubscription1Error(Optional<SubscriptionError> subscriptionErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _subscriptionErrorValue = subscriptionErrorValue;
    }

    private static SuspendSubscription1Error AsSubscriptionError(SubscriptionError value) =>
        new(Optional<SubscriptionError>.Some(value), default);

    private static SuspendSubscription1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetSubscriptionError(out SubscriptionError value) =>
        _subscriptionErrorValue.TryGetValue(out value);

    internal static Task<SuspendSubscription1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 422 or 500 => FromJson<SubscriptionError>(response, ct).As(AsSubscriptionError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class SuspendSubscription1ErrorResponse : IErrorResponse<SuspendSubscription1Error>
{
    public static SuspendSubscription1ErrorResponse Instance { get; } = new();

    private SuspendSubscription1ErrorResponse()
    {
    }

    public Task<SuspendSubscription1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        SuspendSubscription1Error.Create(response, ct);
}
