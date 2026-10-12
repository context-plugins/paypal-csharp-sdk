<!-- Generated file — do not edit; regenerated with the SDK. -->

# Payments — operations

Accessor: `client.Payments` · Source: `src/Paypal/Api/Payments.cs` · 7 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### CaptureAuthorizedPayment

- **Auth**: `options.Oauth2`
- **Signature**: `CaptureAuthorizedPayment(CaptureAuthorizedPaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AuthorizationId`
- **Returns**: `CapturedPayment`
- **Error**: `ApiException<CaptureAuthorizedPaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 404, 409, 422] · `TryGetNoContent(out RawError)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CaptureAuthorizedPaymentRequest` | `src/Paypal/Requests/Payments/CaptureAuthorizedPaymentRequest.cs` |
| `CaptureRequest` | `src/Paypal/Models/CaptureRequest.cs` |
| `CapturedPayment` | `src/Paypal/Models/CapturedPayment.cs` |
| `CaptureAuthorizedPaymentError` | `src/Paypal/Errors/CaptureAuthorizedPaymentError.cs` |
| `Error` | `src/Paypal/Models/Error.cs` |

### GetAuthorizedPayment

- **Auth**: `options.Oauth2`
- **Signature**: `GetAuthorizedPayment(GetAuthorizedPaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AuthorizationId`
- **Returns**: `PaymentAuthorization`
- **Error**: `ApiException<GetAuthorizedPaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 403, 404] · `TryGetNoContent(out RawError)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAuthorizedPaymentRequest` | `src/Paypal/Requests/Payments/GetAuthorizedPaymentRequest.cs` |
| `PaymentAuthorization` | `src/Paypal/Models/PaymentAuthorization.cs` |
| `GetAuthorizedPaymentError` | `src/Paypal/Errors/GetAuthorizedPaymentError.cs` |
| `Error` | `src/Paypal/Models/Error.cs` |

### GetCapturedPayment

- **Auth**: `options.Oauth2`
- **Signature**: `GetCapturedPayment(GetCapturedPaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CaptureId`
- **Returns**: `CapturedPayment`
- **Error**: `ApiException<GetCapturedPaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 403, 404] · `TryGetNoContent(out RawError)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCapturedPaymentRequest` | `src/Paypal/Requests/Payments/GetCapturedPaymentRequest.cs` |
| `CapturedPayment` | `src/Paypal/Models/CapturedPayment.cs` |
| `GetCapturedPaymentError` | `src/Paypal/Errors/GetCapturedPaymentError.cs` |
| `Error` | `src/Paypal/Models/Error.cs` |

### GetRefund

- **Auth**: `options.Oauth2`
- **Signature**: `GetRefund(GetRefundRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `RefundId`
- **Returns**: `Refund`
- **Error**: `ApiException<GetRefundError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 403, 404] · `TryGetNoContent(out RawError)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetRefundRequest` | `src/Paypal/Requests/Payments/GetRefundRequest.cs` |
| `Refund` | `src/Paypal/Models/Refund.cs` |
| `GetRefundError` | `src/Paypal/Errors/GetRefundError.cs` |
| `Error` | `src/Paypal/Models/Error.cs` |

### ReauthorizePayment

- **Auth**: `options.Oauth2`
- **Signature**: `ReauthorizePayment(ReauthorizePaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AuthorizationId`
- **Returns**: `PaymentAuthorization`
- **Error**: `ApiException<ReauthorizePaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 404, 422] · `TryGetNoContent(out RawError)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReauthorizePaymentRequest` | `src/Paypal/Requests/Payments/ReauthorizePaymentRequest.cs` |
| `ReauthorizeRequest` | `src/Paypal/Models/ReauthorizeRequest.cs` |
| `PaymentAuthorization` | `src/Paypal/Models/PaymentAuthorization.cs` |
| `ReauthorizePaymentError` | `src/Paypal/Errors/ReauthorizePaymentError.cs` |
| `Error` | `src/Paypal/Models/Error.cs` |

### RefundCapturedPayment

- **Auth**: `options.Oauth2`
- **Signature**: `RefundCapturedPayment(RefundCapturedPaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CaptureId`
- **Returns**: `Refund`
- **Error**: `ApiException<RefundCapturedPaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 404, 409, 422] · `TryGetNoContent(out RawError)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RefundCapturedPaymentRequest` | `src/Paypal/Requests/Payments/RefundCapturedPaymentRequest.cs` |
| `RefundRequest` | `src/Paypal/Models/RefundRequest.cs` |
| `Refund` | `src/Paypal/Models/Refund.cs` |
| `RefundCapturedPaymentError` | `src/Paypal/Errors/RefundCapturedPaymentError.cs` |
| `Error` | `src/Paypal/Models/Error.cs` |

### VoidPayment

- **Auth**: `options.Oauth2`
- **Signature**: `VoidPayment(VoidPaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AuthorizationId`
- **Returns**: `PaymentAuthorization`
- **Error**: `ApiException<VoidPaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 403, 404, 409, 422] · `TryGetNoContent(out RawError)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VoidPaymentRequest` | `src/Paypal/Requests/Payments/VoidPaymentRequest.cs` |
| `PaymentAuthorization` | `src/Paypal/Models/PaymentAuthorization.cs` |
| `VoidPaymentError` | `src/Paypal/Errors/VoidPaymentError.cs` |
| `Error` | `src/Paypal/Models/Error.cs` |

