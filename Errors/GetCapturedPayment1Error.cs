using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using PayPalServerSdk.Core.ErrorResponse;
using PayPalServerSdk.Core.Models;
using PayPalServerSdk.Models;

namespace PayPalServerSdk.Errors;

public sealed class GetCapturedPayment1Error : ApiError
{
    private readonly Optional<Error> _errorValue;

    private readonly Optional<RawError> _noContentValue;

    private GetCapturedPayment1Error(Optional<Error> errorValue,
        Optional<RawError> noContentValue,
        Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
        _noContentValue = noContentValue;
    }

    private static GetCapturedPayment1Error AsError(Error value) =>
        new(Optional<Error>.Some(value), default, default);

    private static GetCapturedPayment1Error AsNoContent(RawError value) =>
        new(default, Optional<RawError>.Some(value), default);

    private static GetCapturedPayment1Error AsFallback(RawError value) =>
        new(default, default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    public bool TryGetNoContent(out RawError value) => _noContentValue.TryGetValue(out value);

    internal static Task<GetCapturedPayment1Error> Create(HttpResponseMessage response, CancellationToken ct) =>
        (int)response.StatusCode switch
        {
            401 or 403 or 404 => FromJson<Error>(response, ct).As(AsError),
            500 => FromRawBody(response, ct).As(AsNoContent),
            _ => FromRawBody(response, ct).As(AsFallback)
        };
}

internal sealed class GetCapturedPayment1ErrorResponse : IErrorResponse<GetCapturedPayment1Error>
{
    public static GetCapturedPayment1ErrorResponse Instance { get; } = new();

    private GetCapturedPayment1ErrorResponse()
    {
    }

    public Task<GetCapturedPayment1Error> Map(HttpResponseMessage response, CancellationToken ct) =>
        GetCapturedPayment1Error.Create(response, ct);
}
