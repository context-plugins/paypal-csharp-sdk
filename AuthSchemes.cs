using Paypal.Core;
using Paypal.Core.Authentication;
using Paypal.Core.Authentication.OAuth2;
using Paypal.Core.Authentication.OAuth2.ClientCredentials;

namespace Paypal;

internal sealed class AuthSchemes
{
    public IAuthScheme Oauth2 { get; }

    public AuthSchemes(PaypalClientOptions options, Server server, RawClient rawClient)
    {
        Oauth2 =
            OAuth2Scheme<OAuth2ClientCredentials>.Create(options.Oauth2,
                options.Oauth2TokenStrategy ??
                    OAuth2ClientCredentialsStrategy.ForBasicAuthRequest(server.Default("/v1/oauth2/token"), rawClient));
    }
}
