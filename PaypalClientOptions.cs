using Paypal.Core.Authentication.OAuth2;
using Paypal.Core.Authentication.OAuth2.ClientCredentials;
using Paypal.Core.Configuration;
using Paypal.Servers;

namespace Paypal;

public class PaypalClientOptions
{
    public ServerEnvironment Environment { get; set; } = ServerEnvironment.Default();
    public RetryOptions Retry { get; set; } = RetryOptions.Default();
    public LoggingOptions Logging { get; set; } = new();
    public ServerOptions Server { get; set; } = new();
    /// <summary>
    /// Oauth 2.0 authentication, Oauth 2.0 authentication, OAuth 2.0 authentication, Oauth 2.0 authentication, Oauth 2.0 authentication, Oauth 2.0 authentication, OAuth 2.0 authentication, Oauth 2.0 authentication, Oauth 2.0 authentication
    /// </summary>
    public OAuth2ClientCredentials? Oauth2 { get; set; }
    public IOAuth2TokenStrategy<OAuth2ClientCredentials>? Oauth2TokenStrategy { get; set; }
}
