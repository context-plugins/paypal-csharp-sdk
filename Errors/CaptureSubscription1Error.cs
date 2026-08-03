using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using Paypal.Core.ErrorResponse;
using Paypal.Core.Models;
using Paypal.Models;

namespace Paypal.Errors;

public sealed class CaptureSubscription1Error : ApiError
{
    private readonly Optional<SubscriptionError> _subscriptionErrorValue;

    private CaptureSubscription1Error(Optional<SubscriptionError> subscriptionErrorValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _subscriptionErrorValue = subscriptionErrorValue;
    }

    private static CaptureSubscription1Error AsSubscriptionError(SubscriptionError value) =>
        new(Optional<SubscriptionError>.Some(value), default);

    private static CaptureSubscription1Error AsFallback(RawError value) =>
        new(default, Optional<RawError>.Some(value));

    public bool TryGetSubscriptionError(out SubscriptionError value) =>
        _subscriptionErrorValue.TryGetValue(out value);

    internal static Task<CaptureSubscription1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            400 or 401 or 403 or 404 or 422 or 500 => FromJson<SubscriptionError>(response, ct).As(AsSubscriptionError),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class CaptureSubscription1ErrorResponse : IErrorResponse<CaptureSubscription1Error>
{
    public static CaptureSubscription1ErrorResponse Instance { get; } = new();

    private CaptureSubscription1ErrorResponse()
    {
    }

    public Task<CaptureSubscription1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        CaptureSubscription1Error.Create(response, ct);
}
