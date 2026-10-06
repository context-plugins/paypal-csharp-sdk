<!-- Generated file — do not edit; regenerated with the SDK. -->

# Payments — operations

Accessor: `client.Payments` · Source: `Api/Payments.cs` · 7 operations

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
| `CaptureAuthorizedPaymentRequest` | `Requests/Payments/CaptureAuthorizedPaymentRequest.cs` |
| `CaptureRequest` | `Models/CaptureRequest.cs` |
| `CapturedPayment` | `Models/CapturedPayment.cs` |
| `CaptureAuthorizedPaymentError` | `Errors/CaptureAuthorizedPaymentError.cs` |
| `Error` | `Models/Error.cs` |

### GetAuthorizedPayment

- **Auth**: `options.Oauth2`
- **Signature**: `GetAuthorizedPayment(GetAuthorizedPaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AuthorizationId`
- **Returns**: `PaymentAuthorization`
- **Error**: `ApiException<GetAuthorizedPaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 403, 404] · `TryGetNoContent(out RawError)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetAuthorizedPaymentRequest` | `Requests/Payments/GetAuthorizedPaymentRequest.cs` |
| `PaymentAuthorization` | `Models/PaymentAuthorization.cs` |
| `GetAuthorizedPaymentError` | `Errors/GetAuthorizedPaymentError.cs` |
| `Error` | `Models/Error.cs` |

### GetCapturedPayment

- **Auth**: `options.Oauth2`
- **Signature**: `GetCapturedPayment(GetCapturedPaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CaptureId`
- **Returns**: `CapturedPayment`
- **Error**: `ApiException<GetCapturedPaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 403, 404] · `TryGetNoContent(out RawError)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetCapturedPaymentRequest` | `Requests/Payments/GetCapturedPaymentRequest.cs` |
| `CapturedPayment` | `Models/CapturedPayment.cs` |
| `GetCapturedPaymentError` | `Errors/GetCapturedPaymentError.cs` |
| `Error` | `Models/Error.cs` |

### GetRefund

- **Auth**: `options.Oauth2`
- **Signature**: `GetRefund(GetRefundRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `RefundId`
- **Returns**: `Refund`
- **Error**: `ApiException<GetRefundError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 403, 404] · `TryGetNoContent(out RawError)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetRefundRequest` | `Requests/Payments/GetRefundRequest.cs` |
| `Refund` | `Models/Refund.cs` |
| `GetRefundError` | `Errors/GetRefundError.cs` |
| `Error` | `Models/Error.cs` |

### ReauthorizePayment

- **Auth**: `options.Oauth2`
- **Signature**: `ReauthorizePayment(ReauthorizePaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AuthorizationId`
- **Returns**: `PaymentAuthorization`
- **Error**: `ApiException<ReauthorizePaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 404, 422] · `TryGetNoContent(out RawError)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReauthorizePaymentRequest` | `Requests/Payments/ReauthorizePaymentRequest.cs` |
| `ReauthorizeRequest` | `Models/ReauthorizeRequest.cs` |
| `PaymentAuthorization` | `Models/PaymentAuthorization.cs` |
| `ReauthorizePaymentError` | `Errors/ReauthorizePaymentError.cs` |
| `Error` | `Models/Error.cs` |

### RefundCapturedPayment

- **Auth**: `options.Oauth2`
- **Signature**: `RefundCapturedPayment(RefundCapturedPaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `CaptureId`
- **Returns**: `Refund`
- **Error**: `ApiException<RefundCapturedPaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 404, 409, 422] · `TryGetNoContent(out RawError)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `RefundCapturedPaymentRequest` | `Requests/Payments/RefundCapturedPaymentRequest.cs` |
| `RefundRequest` | `Models/RefundRequest.cs` |
| `Refund` | `Models/Refund.cs` |
| `RefundCapturedPaymentError` | `Errors/RefundCapturedPaymentError.cs` |
| `Error` | `Models/Error.cs` |

### VoidPayment

- **Auth**: `options.Oauth2`
- **Signature**: `VoidPayment(VoidPaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `AuthorizationId`
- **Returns**: `PaymentAuthorization`
- **Error**: `ApiException<VoidPaymentError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 403, 404, 409, 422] · `TryGetNoContent(out RawError)` [500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `VoidPaymentRequest` | `Requests/Payments/VoidPaymentRequest.cs` |
| `PaymentAuthorization` | `Models/PaymentAuthorization.cs` |
| `VoidPaymentError` | `Errors/VoidPaymentError.cs` |
| `Error` | `Models/Error.cs` |

