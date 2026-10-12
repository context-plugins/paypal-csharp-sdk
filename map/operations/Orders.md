<!-- Generated file — do not edit; regenerated with the SDK. -->

# Orders — operations

Accessor: `client.Orders` · Source: `src/Paypal/Api/Orders.cs` · 8 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### AuthorizeOrder

- **Auth**: `options.Oauth2`
- **Signature**: `AuthorizeOrder(AuthorizeOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `OrderAuthorizeResponse`
- **Error**: `ApiException<AuthorizeOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `AuthorizeOrderRequest` | `src/Paypal/Requests/Orders/AuthorizeOrderRequest.cs` |
| `OrderAuthorizeRequest` | `src/Paypal/Models/OrderAuthorizeRequest.cs` |
| `OrderAuthorizeResponse` | `src/Paypal/Models/OrderAuthorizeResponse.cs` |
| `AuthorizeOrderError` | `src/Paypal/Errors/AuthorizeOrderError.cs` |
| `Error` | `src/Paypal/Models/Error.cs` |

### CaptureOrder

- **Auth**: `options.Oauth2`
- **Signature**: `CaptureOrder(CaptureOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `Order`
- **Error**: `ApiException<CaptureOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CaptureOrderRequest` | `src/Paypal/Requests/Orders/CaptureOrderRequest.cs` |
| `OrderCaptureRequest` | `src/Paypal/Models/OrderCaptureRequest.cs` |
| `Order` | `src/Paypal/Models/Order.cs` |
| `CaptureOrderError` | `src/Paypal/Errors/CaptureOrderError.cs` |
| `Error` | `src/Paypal/Models/Error.cs` |

### ConfirmOrder

- **Auth**: `options.Oauth2`
- **Signature**: `ConfirmOrder(ConfirmOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `Order`
- **Error**: `ApiException<ConfirmOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ConfirmOrderOperationRequest` | `src/Paypal/Requests/Orders/ConfirmOrderOperationRequest.cs` |
| `ConfirmOrderRequest` | `src/Paypal/Models/ConfirmOrderRequest.cs` |
| `Order` | `src/Paypal/Models/Order.cs` |
| `ConfirmOrderError` | `src/Paypal/Errors/ConfirmOrderError.cs` |
| `Error` | `src/Paypal/Models/Error.cs` |

### CreateOrder

- **Auth**: `options.Oauth2`
- **Signature**: `CreateOrder(CreateOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `Order`
- **Error**: `ApiException<CreateOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateOrderRequest` | `src/Paypal/Requests/Orders/CreateOrderRequest.cs` |
| `OrderRequest` | `src/Paypal/Models/OrderRequest.cs` |
| `Order` | `src/Paypal/Models/Order.cs` |
| `CreateOrderError` | `src/Paypal/Errors/CreateOrderError.cs` |
| `Error` | `src/Paypal/Models/Error.cs` |

### CreateOrderTracking

- **Auth**: `options.Oauth2`
- **Signature**: `CreateOrderTracking(CreateOrderTrackingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `Order`
- **Error**: `ApiException<CreateOrderTrackingError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateOrderTrackingRequest` | `src/Paypal/Requests/Orders/CreateOrderTrackingRequest.cs` |
| `OrderTrackerRequest` | `src/Paypal/Models/OrderTrackerRequest.cs` |
| `Order` | `src/Paypal/Models/Order.cs` |
| `CreateOrderTrackingError` | `src/Paypal/Errors/CreateOrderTrackingError.cs` |
| `Error` | `src/Paypal/Models/Error.cs` |

### GetOrder

- **Auth**: `options.Oauth2`
- **Signature**: `GetOrder(GetOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `fields` ← `Fields`
- **Returns**: `Order`
- **Error**: `ApiException<GetOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [401, 404] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetOrderRequest` | `src/Paypal/Requests/Orders/GetOrderRequest.cs` |
| `Order` | `src/Paypal/Models/Order.cs` |
| `GetOrderError` | `src/Paypal/Errors/GetOrderError.cs` |
| `Error` | `src/Paypal/Models/Error.cs` |

### PatchOrder

- **Auth**: `options.Oauth2`
- **Signature**: `PatchOrder(PatchOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<PatchOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchOrderRequest` | `src/Paypal/Requests/Orders/PatchOrderRequest.cs` |
| `Patch` | `src/Paypal/Models/Patch.cs` |
| `PatchOrderError` | `src/Paypal/Errors/PatchOrderError.cs` |
| `Error` | `src/Paypal/Models/Error.cs` |

### UpdateOrderTracking

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateOrderTracking(UpdateOrderTrackingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `TrackerId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<UpdateOrderTrackingError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateOrderTrackingRequest` | `src/Paypal/Requests/Orders/UpdateOrderTrackingRequest.cs` |
| `Patch` | `src/Paypal/Models/Patch.cs` |
| `UpdateOrderTrackingError` | `src/Paypal/Errors/UpdateOrderTrackingError.cs` |
| `Error` | `src/Paypal/Models/Error.cs` |

