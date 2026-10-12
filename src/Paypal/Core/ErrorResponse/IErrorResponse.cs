using System.Threading;
using System.Threading.Tasks;
using Paypal.Core.Models;

namespace Paypal.Core.ErrorResponse;

internal interface IErrorResponse<TError>
{
    Task<TError> Map(ResponseContext context, CancellationToken cancellationToken);
}