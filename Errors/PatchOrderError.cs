using System.Threading.Tasks;
using Paypal.Core.ErrorResponse;
using Paypal.Core.Models;
using Paypal.Models;

namespace Paypal.Errors;

public sealed class PatchOrderError : ApiError
{
    private readonly Optional<Error> _errorValue;

    private PatchOrderError(Optional<Error> errorValue, Optional<RawError> fallback) : base(fallback)
    {
        _errorValue = errorValue;
    }

    private static PatchOrderError AsError(Error value) => new(Optional<Error>.Some(value), default);

    private static PatchOrderError AsFallback(RawError value) => new(default, Optional<RawError>.Some(value));

    public bool TryGetError(out Error value) => _errorValue.TryGetValue(out value);

    private static Task<PatchOrderError> Create(FailedResponse response) =>
        response.StatusCode switch
        {
            400 or 401 or 404 or 422 => response.Json<Error>().As(AsError),
            _ => response.RawBody().As(AsFallback)
        };

    internal static ApiErrorResponse<PatchOrderError> Response { get; } = new(Create);
}
