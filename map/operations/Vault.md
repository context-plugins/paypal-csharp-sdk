<!-- Generated file — do not edit; regenerated with the SDK. -->

# Vault — operations

Accessor: `client.Vault` · Source: `src/Paypal/Api/Vault.cs` · 6 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CreatePaymentToken

- **Auth**: `options.Oauth2`
- **Signature**: `CreatePaymentToken(CreatePaymentTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `PaymentTokenResponse`
- **Error**: `ApiException<CreatePaymentTokenError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreatePaymentTokenRequest` | `src/Paypal/Requests/Vault/CreatePaymentTokenRequest.cs` |
| `PaymentTokenRequest` | `src/Paypal/Models/PaymentTokenRequest.cs` |
| `PaymentTokenResponse` | `src/Paypal/Models/PaymentTokenResponse.cs` |
| `CreatePaymentTokenError` | `src/Paypal/Errors/CreatePaymentTokenError.cs` |
| `Error` | `src/Paypal/Models/Error.cs` |

### CreateSetupToken

- **Auth**: `options.Oauth2`
- **Signature**: `CreateSetupToken(CreateSetupTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SetupTokenResponse`
- **Error**: `ApiException<CreateSetupTokenError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateSetupTokenRequest` | `src/Paypal/Requests/Vault/CreateSetupTokenRequest.cs` |
| `SetupTokenRequest` | `src/Paypal/Models/SetupTokenRequest.cs` |
| `SetupTokenResponse` | `src/Paypal/Models/SetupTokenResponse.cs` |
| `CreateSetupTokenError` | `src/Paypal/Errors/CreateSetupTokenError.cs` |
| `Error` | `src/Paypal/Models/Error.cs` |

### DeletePaymentToken

- **Auth**: `options.Oauth2`
- **Signature**: `DeletePaymentToken(DeletePaymentTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeletePaymentTokenError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeletePaymentTokenRequest` | `src/Paypal/Requests/Vault/DeletePaymentTokenRequest.cs` |
| `DeletePaymentTokenError` | `src/Paypal/Errors/DeletePaymentTokenError.cs` |
| `Error` | `src/Paypal/Models/Error.cs` |

### GetPaymentToken

- **Auth**: `options.Oauth2`
- **Signature**: `GetPaymentToken(GetPaymentTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `PaymentTokenResponse`
- **Error**: `ApiException<GetPaymentTokenError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPaymentTokenRequest` | `src/Paypal/Requests/Vault/GetPaymentTokenRequest.cs` |
| `PaymentTokenResponse` | `src/Paypal/Models/PaymentTokenResponse.cs` |
| `GetPaymentTokenError` | `src/Paypal/Errors/GetPaymentTokenError.cs` |
| `Error` | `src/Paypal/Models/Error.cs` |

### GetSetupToken

- **Auth**: `options.Oauth2`
- **Signature**: `GetSetupToken(GetSetupTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `SetupTokenResponse`
- **Error**: `ApiException<GetSetupTokenError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSetupTokenRequest` | `src/Paypal/Requests/Vault/GetSetupTokenRequest.cs` |
| `SetupTokenResponse` | `src/Paypal/Models/SetupTokenResponse.cs` |
| `GetSetupTokenError` | `src/Paypal/Errors/GetSetupTokenError.cs` |
| `Error` | `src/Paypal/Models/Error.cs` |

### ListCustomerPaymentTokens

- **Auth**: `options.Oauth2`
- **Signature**: `ListCustomerPaymentTokens(ListCustomerPaymentTokensRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CustomerId`
- **Query params (wire ← C#)**: `customer_id` ← `CustomerId`, `page_size` ← `PageSize`, `page` ← `Page`, `total_required` ← `TotalRequired`
- **Returns**: `CustomerVaultPaymentTokensResponse`
- **Error**: `ApiException<ListCustomerPaymentTokensError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListCustomerPaymentTokensRequest` | `src/Paypal/Requests/Vault/ListCustomerPaymentTokensRequest.cs` |
| `CustomerVaultPaymentTokensResponse` | `src/Paypal/Models/CustomerVaultPaymentTokensResponse.cs` |
| `ListCustomerPaymentTokensError` | `src/Paypal/Errors/ListCustomerPaymentTokensError.cs` |
| `Error` | `src/Paypal/Models/Error.cs` |

