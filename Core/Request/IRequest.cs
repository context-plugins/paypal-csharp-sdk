using System.Net.Http;

namespace Paypal.Core.Request;

internal interface IRequest
{
    HttpContent Get();

    bool CanRetry { get; }
}