using System.Net.Http;
using Paypal.Api;
using Paypal.Core;
using Paypal.Core.Logging;
using Paypal.Core.Models;

namespace Paypal;

/// <summary>
/// You can use billing plans and subscriptions to create subscriptions that process recurring PayPal payments for physical or digital goods, or services. A plan includes pricing and billing cycle information that defines the amount and frequency of charge for a subscription. You can also define a fixed plan, such as a $5 basic plan or a volume- or graduated-based plan with pricing tiers based on the quantity purchased. For more information, see Subscriptions Overview., ### Important Notes
///  - <b>Available Features:</b> This SDK currently contains only 5 of PayPal's API endpoints. Additional endpoints and functionality will be added in the future.
///
///  ## Information
///  The PayPal Server SDK provides integration access to the PayPal REST APIs. The API endpoints are divided into distinct controllers:
///  - Orders Controller: <see href="https://developer.paypal.com/docs/api/orders/v2/">Orders API v2</see>
///  - Payments Controller: <see href="https://developer.paypal.com/docs/api/payments/v2">Payments API v2</see>
///  - Vault Controller: <see href="https://developer.paypal.com/docs/api/payment-tokens/v3/">Payment Method Tokens API v3</see> *Available in the US only.*
///  - Transaction Search Controller: <see href="https://developer.paypal.com/docs/api/transaction-search/v1/">Transaction Search API v1</see>
///  - Subscriptions Controller: <see href="https://developer.paypal.com/docs/api/subscriptions/v1/">Subscriptions API v1</see>, Call the Payments API to authorize payments, capture authorized payments, refund payments that have already been captured, and show payment information. Use the Payments API in conjunction with the Orders API. For more information, see the PayPal Checkout Overview., Use the Transaction Search API to get the history of transactions for a PayPal account. To use the API on behalf of third parties, you must be part of the PayPal partner network. Reach out to your partner manager for the next steps. To enroll in the partner program, see Partner with PayPal. For more information about the API, see the Transaction Search API Integration Guide. Note: To use the API on behalf of third parties, you must be part of the PayPal partner network. Reach out to your partner manager for the next steps. To enroll in the partner program, see Partner with PayPal., The Payment Method Tokens API saves payment methods so payers don't have to enter details for future transactions. Payers can check out faster or pay without being present after they agree to save a payment method. The API associates a payment method with a temporary setup token. Pass the setup token to the API to exchange the setup token for a permanent token. The permanent token represents a payment method that's saved to the vault. This token can be used repeatedly for checkout or recurring transactions such as subscriptions. The Payment Method Tokens API is available in the US only.
/// </summary>
public sealed class PaypalClient
{
    public PaypalClient(HttpClient httpClient, PaypalClientOptions options)
    {
        var server = new Server(options.Environment, options.Server);
        var queryParameterFactory = new QueryParameterFactory([]);
        var templateParamsFactory = new TemplateParamsFactory([]);
        var urlFactory = new UriFactory(queryParameterFactory, templateParamsFactory);
        var httpStatusPolicy = new HttpStatusPolicy([]);
        var headersFactory =
            new HeadersFactory([new HeaderParam("User-Agent", "PaypalClient/1.11 CSharp"),
                    new HeaderParam("X-APIMatic-Lang", "CSharp"),
                    new HeaderParam("X-APIMatic-Package-Version", "1.11"),
                    new HeaderParam("X-APIMatic-Gen-Version", "4.0.0"),
                    new HeaderParam("X-APIMatic-OS", RuntimeEnvironment.Os),
                    new HeaderParam("X-APIMatic-Runtime", RuntimeEnvironment.Runtime)]);
        var resiliencePipelineFactory = new ResiliencePipelineFactory(options.Retry);
        var httpLogger = new HttpLogger(options.Logging, "PaypalClient");
        var rawClient =
            new RawClient(httpClient, urlFactory, httpStatusPolicy, headersFactory, resiliencePipelineFactory, httpLogger);
        var auth = new AuthSchemes(options, server, rawClient);
        Orders = new Orders(rawClient, server, auth);
        Payments = new Payments(rawClient, server, auth);
        Subscriptions = new Subscriptions(rawClient, server, auth);
        TransactionSearch = new TransactionSearch(rawClient, server, auth);
        Vault = new Vault(rawClient, server, auth);
    }

    /// <summary>
    /// Use the <c>/orders</c> resource to create, update, retrieve, authorize, capture and track orders.
    /// </summary>
    public Orders Orders { get; }

    /// <summary>
    /// Use the <c>/payments</c> resource to authorize, capture, void authorizations, and retrieve captures.
    /// </summary>
    public Payments Payments { get; }

    /// <summary>
    /// Use the <c>/subscriptions</c> resource to create, update, retrieve, and cancel subscriptions and their associated plans.
    /// </summary>
    public Subscriptions Subscriptions { get; }

    /// <summary>
    /// Use the <c>/transactions</c> resource to list transactions and the <c>/balances</c> resource to list balances.
    /// </summary>
    public TransactionSearch TransactionSearch { get; }

    /// <summary>
    /// Use the <c>/vault</c> resource to create, retrieve, and delete payment and setup tokens.
    /// </summary>
    public Vault Vault { get; }
}
