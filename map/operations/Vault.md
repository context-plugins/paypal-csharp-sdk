<!-- Generated file — do not edit; regenerated with the SDK. -->

# Vault — operations

Accessor: `client.Vault` · Source: `Api/Vault.cs` · 6 operations

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
| `CreatePaymentTokenRequest` | `Requests/Vault/CreatePaymentTokenRequest.cs` |
| `PaymentTokenRequest` | `Models/PaymentTokenRequest.cs` |
| `PaymentTokenResponse` | `Models/PaymentTokenResponse.cs` |
| `CreatePaymentTokenError` | `Errors/CreatePaymentTokenError.cs` |
| `Error` | `Models/Error.cs` |

### CreateSetupToken

- **Auth**: `options.Oauth2`
- **Signature**: `CreateSetupToken(CreateSetupTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `SetupTokenResponse`
- **Error**: `ApiException<CreateSetupTokenError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateSetupTokenRequest` | `Requests/Vault/CreateSetupTokenRequest.cs` |
| `SetupTokenRequest` | `Models/SetupTokenRequest.cs` |
| `SetupTokenResponse` | `Models/SetupTokenResponse.cs` |
| `CreateSetupTokenError` | `Errors/CreateSetupTokenError.cs` |
| `Error` | `Models/Error.cs` |

### DeletePaymentToken

- **Auth**: `options.Oauth2`
- **Signature**: `DeletePaymentToken(DeletePaymentTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeletePaymentTokenError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeletePaymentTokenRequest` | `Requests/Vault/DeletePaymentTokenRequest.cs` |
| `DeletePaymentTokenError` | `Errors/DeletePaymentTokenError.cs` |
| `Error` | `Models/Error.cs` |

### GetPaymentToken

- **Auth**: `options.Oauth2`
- **Signature**: `GetPaymentToken(GetPaymentTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `PaymentTokenResponse`
- **Error**: `ApiException<GetPaymentTokenError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetPaymentTokenRequest` | `Requests/Vault/GetPaymentTokenRequest.cs` |
| `PaymentTokenResponse` | `Models/PaymentTokenResponse.cs` |
| `GetPaymentTokenError` | `Errors/GetPaymentTokenError.cs` |
| `Error` | `Models/Error.cs` |

### GetSetupToken

- **Auth**: `options.Oauth2`
- **Signature**: `GetSetupToken(GetSetupTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `SetupTokenResponse`
- **Error**: `ApiException<GetSetupTokenError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSetupTokenRequest` | `Requests/Vault/GetSetupTokenRequest.cs` |
| `SetupTokenResponse` | `Models/SetupTokenResponse.cs` |
| `GetSetupTokenError` | `Errors/GetSetupTokenError.cs` |
| `Error` | `Models/Error.cs` |

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
| `ListCustomerPaymentTokensRequest` | `Requests/Vault/ListCustomerPaymentTokensRequest.cs` |
| `CustomerVaultPaymentTokensResponse` | `Models/CustomerVaultPaymentTokensResponse.cs` |
| `ListCustomerPaymentTokensError` | `Errors/ListCustomerPaymentTokensError.cs` |
| `Error` | `Models/Error.cs` |

