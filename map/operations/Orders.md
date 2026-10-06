<!-- Generated file — do not edit; regenerated with the SDK. -->

# Orders — operations

Accessor: `client.Orders` · Source: `Api/Orders.cs` · 8 operations

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
| `AuthorizeOrderRequest` | `Requests/Orders/AuthorizeOrderRequest.cs` |
| `OrderAuthorizeRequest` | `Models/OrderAuthorizeRequest.cs` |
| `OrderAuthorizeResponse` | `Models/OrderAuthorizeResponse.cs` |
| `AuthorizeOrderError` | `Errors/AuthorizeOrderError.cs` |
| `Error` | `Models/Error.cs` |

### CaptureOrder

- **Auth**: `options.Oauth2`
- **Signature**: `CaptureOrder(CaptureOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `Order`
- **Error**: `ApiException<CaptureOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CaptureOrderRequest` | `Requests/Orders/CaptureOrderRequest.cs` |
| `OrderCaptureRequest` | `Models/OrderCaptureRequest.cs` |
| `Order` | `Models/Order.cs` |
| `CaptureOrderError` | `Errors/CaptureOrderError.cs` |
| `Error` | `Models/Error.cs` |

### ConfirmOrder

- **Auth**: `options.Oauth2`
- **Signature**: `ConfirmOrder(ConfirmOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `Order`
- **Error**: `ApiException<ConfirmOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ConfirmOrderOperationRequest` | `Requests/Orders/ConfirmOrderOperationRequest.cs` |
| `ConfirmOrderRequest` | `Models/ConfirmOrderRequest.cs` |
| `Order` | `Models/Order.cs` |
| `ConfirmOrderError` | `Errors/ConfirmOrderError.cs` |
| `Error` | `Models/Error.cs` |

### CreateOrder

- **Auth**: `options.Oauth2`
- **Signature**: `CreateOrder(CreateOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Body`
- **Returns**: `Order`
- **Error**: `ApiException<CreateOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateOrderRequest` | `Requests/Orders/CreateOrderRequest.cs` |
| `OrderRequest` | `Models/OrderRequest.cs` |
| `Order` | `Models/Order.cs` |
| `CreateOrderError` | `Errors/CreateOrderError.cs` |
| `Error` | `Models/Error.cs` |

### CreateOrderTracking

- **Auth**: `options.Oauth2`
- **Signature**: `CreateOrderTracking(CreateOrderTrackingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `Body`
- **Returns**: `Order`
- **Error**: `ApiException<CreateOrderTrackingError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateOrderTrackingRequest` | `Requests/Orders/CreateOrderTrackingRequest.cs` |
| `OrderTrackerRequest` | `Models/OrderTrackerRequest.cs` |
| `Order` | `Models/Order.cs` |
| `CreateOrderTrackingError` | `Errors/CreateOrderTrackingError.cs` |
| `Error` | `Models/Error.cs` |

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
| `GetOrderRequest` | `Requests/Orders/GetOrderRequest.cs` |
| `Order` | `Models/Order.cs` |
| `GetOrderError` | `Errors/GetOrderError.cs` |
| `Error` | `Models/Error.cs` |

### PatchOrder

- **Auth**: `options.Oauth2`
- **Signature**: `PatchOrder(PatchOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<PatchOrderError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 401, 404, 422] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchOrderRequest` | `Requests/Orders/PatchOrderRequest.cs` |
| `Patch` | `Models/Patch.cs` |
| `PatchOrderError` | `Errors/PatchOrderError.cs` |
| `Error` | `Models/Error.cs` |

### UpdateOrderTracking

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateOrderTracking(UpdateOrderTrackingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `TrackerId`
- **Returns**: `void` (Task)
- **Error**: `ApiException<UpdateOrderTrackingError>` — **Case A (typed)**
- **Error accessors**: `TryGetError(out Error)` [400, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateOrderTrackingRequest` | `Requests/Orders/UpdateOrderTrackingRequest.cs` |
| `Patch` | `Models/Patch.cs` |
| `UpdateOrderTrackingError` | `Errors/UpdateOrderTrackingError.cs` |
| `Error` | `Models/Error.cs` |

