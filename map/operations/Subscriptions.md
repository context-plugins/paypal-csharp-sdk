<!-- Generated file — do not edit; regenerated with the SDK. -->

# Subscriptions — operations

Accessor: `client.Subscriptions` · Source: `Api/Subscriptions.cs` · 17 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### ActivateBillingPlan

- **Auth**: `options.Oauth2`
- **Signature**: `ActivateBillingPlan(ActivateBillingPlanRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<ActivateBillingPlanError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ActivateBillingPlanRequest` | `Requests/Subscriptions/ActivateBillingPlanRequest.cs` |
| `ActivateBillingPlanError` | `Errors/ActivateBillingPlanError.cs` |
| `SubscriptionError` | `Models/SubscriptionError.cs` |

### ActivateSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `ActivateSubscription(ActivateSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<ActivateSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ActivateSubscriptionOperationRequest` | `Requests/Subscriptions/ActivateSubscriptionOperationRequest.cs` |
| `ActivateSubscriptionRequest` | `Models/ActivateSubscriptionRequest.cs` |
| `ActivateSubscriptionError` | `Errors/ActivateSubscriptionError.cs` |
| `SubscriptionError` | `Models/SubscriptionError.cs` |

### CancelSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `CancelSubscription(CancelSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<CancelSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelSubscriptionOperationRequest` | `Requests/Subscriptions/CancelSubscriptionOperationRequest.cs` |
| `CancelSubscriptionRequest` | `Models/CancelSubscriptionRequest.cs` |
| `CancelSubscriptionError` | `Errors/CancelSubscriptionError.cs` |
| `SubscriptionError` | `Models/SubscriptionError.cs` |

### CaptureSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `CaptureSubscription(CaptureSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `SubscriptionTransactionDetails`
- **Error**: `ApiException<CaptureSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CaptureSubscriptionOperationRequest` | `Requests/Subscriptions/CaptureSubscriptionOperationRequest.cs` |
| `CaptureSubscriptionRequest` | `Models/CaptureSubscriptionRequest.cs` |
| `SubscriptionTransactionDetails` | `Models/SubscriptionTransactionDetails.cs` |
| `CaptureSubscriptionError` | `Errors/CaptureSubscriptionError.cs` |
| `SubscriptionError` | `Models/SubscriptionError.cs` |

### CreateBillingPlan

- **Auth**: `options.Oauth2`
- **Signature**: `CreateBillingPlan(CreateBillingPlanRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `BillingPlan`
- **Error**: `ApiException<CreateBillingPlanError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateBillingPlanRequest` | `Requests/Subscriptions/CreateBillingPlanRequest.cs` |
| `PlanRequest` | `Models/PlanRequest.cs` |
| `BillingPlan` | `Models/BillingPlan.cs` |
| `CreateBillingPlanError` | `Errors/CreateBillingPlanError.cs` |
| `SubscriptionError` | `Models/SubscriptionError.cs` |

### CreateSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `CreateSubscription(CreateSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `Subscription`
- **Error**: `ApiException<CreateSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateSubscriptionOperationRequest` | `Requests/Subscriptions/CreateSubscriptionOperationRequest.cs` |
| `CreateSubscriptionRequest` | `Models/CreateSubscriptionRequest.cs` |
| `Subscription` | `Models/Subscription.cs` |
| `CreateSubscriptionError` | `Errors/CreateSubscriptionError.cs` |
| `SubscriptionError` | `Models/SubscriptionError.cs` |

### DeactivateBillingPlan

- **Auth**: `options.Oauth2`
- **Signature**: `DeactivateBillingPlan(DeactivateBillingPlanRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeactivateBillingPlanError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeactivateBillingPlanRequest` | `Requests/Subscriptions/DeactivateBillingPlanRequest.cs` |
| `DeactivateBillingPlanError` | `Errors/DeactivateBillingPlanError.cs` |
| `SubscriptionError` | `Models/SubscriptionError.cs` |

### GetBillingPlan

- **Auth**: `options.Oauth2`
- **Signature**: `GetBillingPlan(GetBillingPlanRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `BillingPlan`
- **Error**: `ApiException<GetBillingPlanError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [401, 403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBillingPlanRequest` | `Requests/Subscriptions/GetBillingPlanRequest.cs` |
| `BillingPlan` | `Models/BillingPlan.cs` |
| `GetBillingPlanError` | `Errors/GetBillingPlanError.cs` |
| `SubscriptionError` | `Models/SubscriptionError.cs` |

### GetSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `GetSubscription(GetSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Query params (wire ← C#)**: `fields` ← `Fields`
- **Returns**: `Subscription`
- **Error**: `ApiException<GetSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [401, 403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetSubscriptionRequest` | `Requests/Subscriptions/GetSubscriptionRequest.cs` |
| `Subscription` | `Models/Subscription.cs` |
| `GetSubscriptionError` | `Errors/GetSubscriptionError.cs` |
| `SubscriptionError` | `Models/SubscriptionError.cs` |

### ListBillingPlans

- **Auth**: `options.Oauth2`
- **Signature**: `ListBillingPlans(ListBillingPlansRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `product_id` ← `ProductId`, `page_size` ← `PageSize`, `page` ← `Page`, `total_required` ← `TotalRequired`
- **Returns**: `PlanCollection`
- **Error**: `ApiException<ListBillingPlansError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListBillingPlansRequest` | `Requests/Subscriptions/ListBillingPlansRequest.cs` |
| `PlanCollection` | `Models/PlanCollection.cs` |
| `ListBillingPlansError` | `Errors/ListBillingPlansError.cs` |
| `SubscriptionError` | `Models/SubscriptionError.cs` |

### ListSubscriptionTransactions

- **Auth**: `options.Oauth2`
- **Signature**: `ListSubscriptionTransactions(ListSubscriptionTransactionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`, `StartTime`, `EndTime`
- **Query params (wire ← C#)**: `start_time` ← `StartTime`, `end_time` ← `EndTime`
- **Returns**: `TransactionsList`
- **Error**: `ApiException<ListSubscriptionTransactionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListSubscriptionTransactionsRequest` | `Requests/Subscriptions/ListSubscriptionTransactionsRequest.cs` |
| `TransactionsList` | `Models/TransactionsList.cs` |
| `ListSubscriptionTransactionsError` | `Errors/ListSubscriptionTransactionsError.cs` |
| `SubscriptionError` | `Models/SubscriptionError.cs` |

### ListSubscriptions

- **Auth**: `options.Oauth2`
- **Signature**: `ListSubscriptions(ListSubscriptionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `plan_ids` ← `PlanIds`, `statuses` ← `Statuses`, `created_after` ← `CreatedAfter`, `created_before` ← `CreatedBefore`, `status_updated_before` ← `StatusUpdatedBefore`, `status_updated_after` ← `StatusUpdatedAfter`, `filter` ← `Filter`, `page_size` ← `PageSize`, `page` ← `Page`, `customer_ids` ← `CustomerIds`
- **Returns**: `SubscriptionCollection`
- **Error**: `ApiException<ListSubscriptionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListSubscriptionsRequest` | `Requests/Subscriptions/ListSubscriptionsRequest.cs` |
| `SubscriptionCollection` | `Models/SubscriptionCollection.cs` |
| `ListSubscriptionsError` | `Errors/ListSubscriptionsError.cs` |
| `SubscriptionError` | `Models/SubscriptionError.cs` |

### PatchBillingPlan

- **Auth**: `options.Oauth2`
- **Signature**: `PatchBillingPlan(PatchBillingPlanRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<PatchBillingPlanError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchBillingPlanRequest` | `Requests/Subscriptions/PatchBillingPlanRequest.cs` |
| `Patch` | `Models/Patch.cs` |
| `PatchBillingPlanError` | `Errors/PatchBillingPlanError.cs` |
| `SubscriptionError` | `Models/SubscriptionError.cs` |

### PatchSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `PatchSubscription(PatchSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<PatchSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchSubscriptionRequest` | `Requests/Subscriptions/PatchSubscriptionRequest.cs` |
| `Patch` | `Models/Patch.cs` |
| `PatchSubscriptionError` | `Errors/PatchSubscriptionError.cs` |
| `SubscriptionError` | `Models/SubscriptionError.cs` |

### ReviseSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `ReviseSubscription(ReviseSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `ModifySubscriptionResponse`
- **Error**: `ApiException<ReviseSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReviseSubscriptionRequest` | `Requests/Subscriptions/ReviseSubscriptionRequest.cs` |
| `ModifySubscriptionRequest` | `Models/ModifySubscriptionRequest.cs` |
| `ModifySubscriptionResponse` | `Models/ModifySubscriptionResponse.cs` |
| `ReviseSubscriptionError` | `Errors/ReviseSubscriptionError.cs` |
| `SubscriptionError` | `Models/SubscriptionError.cs` |

### SuspendSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `SuspendSubscription(SuspendSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<SuspendSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SuspendSubscriptionRequest` | `Requests/Subscriptions/SuspendSubscriptionRequest.cs` |
| `SuspendSubscription` | `Models/SuspendSubscription.cs` |
| `SuspendSubscriptionError` | `Errors/SuspendSubscriptionError.cs` |
| `SubscriptionError` | `Models/SubscriptionError.cs` |

### UpdateBillingPlanPricingSchemes

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateBillingPlanPricingSchemes(UpdateBillingPlanPricingSchemesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<UpdateBillingPlanPricingSchemesError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateBillingPlanPricingSchemesRequest` | `Requests/Subscriptions/UpdateBillingPlanPricingSchemesRequest.cs` |
| `UpdatePricingSchemesRequest` | `Models/UpdatePricingSchemesRequest.cs` |
| `UpdateBillingPlanPricingSchemesError` | `Errors/UpdateBillingPlanPricingSchemesError.cs` |
| `SubscriptionError` | `Models/SubscriptionError.cs` |

