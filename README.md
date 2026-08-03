# paypal

[![Built with APIMatic][apimatic-badge]][apimatic-url] [![License: MIT][license-badge]][license-url]

The paypal SDK for .NET provides access to the paypal REST APIs from .NET applications.

You can use billing plans and subscriptions to create subscriptions that process recurring PayPal payments for physical or digital goods, or services. A plan includes pricing and billing cycle information that defines the amount and frequency of charge for a subscription. You can also define a fixed plan, such as a $5 basic plan or a volume- or graduated-based plan with pricing tiers based on the quantity purchased. For more information, see Subscriptions Overview., ### Important Notes
 - **Available Features:** This SDK currently contains only 5 of PayPal's API endpoints. Additional endpoints and functionality will be added in the future.
 
 ## Information
 The PayPal Server SDK provides integration access to the PayPal REST APIs. The API endpoints are divided into distinct controllers:
 - Orders Controller: [Orders API v2](https://developer.paypal.com/docs/api/orders/v2/)
 - Payments Controller: [Payments API v2](https://developer.paypal.com/docs/api/payments/v2)
 - Vault Controller: [Payment Method Tokens API v3](https://developer.paypal.com/docs/api/payment-tokens/v3/) *Available in the US only.*
 - Transaction Search Controller: [Transaction Search API v1](https://developer.paypal.com/docs/api/transaction-search/v1/)
 - Subscriptions Controller: [Subscriptions API v1](https://developer.paypal.com/docs/api/subscriptions/v1/), Call the Payments API to authorize payments, capture authorized payments, refund payments that have already been captured, and show payment information. Use the Payments API in conjunction with the Orders API. For more information, see the PayPal Checkout Overview., Use the Transaction Search API to get the history of transactions for a PayPal account. To use the API on behalf of third parties, you must be part of the PayPal partner network. Reach out to your partner manager for the next steps. To enroll in the partner program, see Partner with PayPal. For more information about the API, see the Transaction Search API Integration Guide. Note: To use the API on behalf of third parties, you must be part of the PayPal partner network. Reach out to your partner manager for the next steps. To enroll in the partner program, see Partner with PayPal., The Payment Method Tokens API saves payment methods so payers don't have to enter details for future transactions. Payers can check out faster or pay without being present after they agree to save a payment method. The API associates a payment method with a temporary setup token. Pass the setup token to the API to exchange the setup token for a permanent token. The permanent token represents a payment method that's saved to the vault. This token can be used repeatedly for checkout or recurring transactions such as subscriptions. The Payment Method Tokens API is available in the US only.

---

## Installation

Add the .NET SDK as a project reference into your solution:

```bash
dotnet add reference <path-to-sdk>/Paypal.csproj
```

---

## Quick Start

### Dependency Injection

Register the client with `IServiceCollection` and resolve it from the container. The `HttpClient` is managed by `IHttpClientFactory`. Configure the client's behavior through [PaypalClientOptions](PaypalClientOptions.cs).

```csharp
services.AddPaypalClient(options =>
    {
        options.Oauth2 =
            new OAuth2ClientCredentials
            {
                ClientId = "YOUR_CLIENT_ID",
                ClientSecret = "YOUR_CLIENT_SECRET",
            };
        options.Environment = ServerEnvironment.Production;
        // TODO: configure more client options here
    });
```

### Direct Instantiation

Create the client by passing an `HttpClient` you manage yourself. Configure the client's behavior through [PaypalClientOptions](PaypalClientOptions.cs).

```csharp
var httpClient = new HttpClient();
// TODO: configure more client options here
var options =
    new PaypalClientOptions
    {
        Oauth2 = new OAuth2ClientCredentials
        {
            ClientId = "YOUR_CLIENT_ID",
            ClientSecret = "YOUR_CLIENT_SECRET",
        },
        Environment = ServerEnvironment.Production,
    };
var client = new PaypalClient(httpClient, options);
```

---

## Usage

For code examples and error responses, see [API Reference](api-reference.md).

## Best Practices

> [!TIP]
> Use a **single `PaypalClient` instance** for the lifetime of your application and
> reuse it across all requests. Creating a new instance per request might exhaust the
> connection pool.

## License

This SDK is distributed under the [MIT License](LICENSE).

---

## Support

Refer to the [API reference](api-reference.md) for detailed information on available operations with code samples.

---

[license-url]: LICENSE
[license-badge]: https://img.shields.io/badge/License-MIT-blue.svg
[apimatic-url]: https://www.apimatic.io
[apimatic-badge]: https://www.apimatic.io/hubfs/Built-with-APIMatic-badge.svg
