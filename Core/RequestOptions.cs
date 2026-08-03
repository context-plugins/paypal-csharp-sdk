using Microsoft.Extensions.Logging;

namespace Paypal.Core;

public sealed record RequestOptions
{
    public LogLevel? LogLevel { get; init; }
}
