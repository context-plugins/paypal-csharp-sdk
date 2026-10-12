<!-- Generated file — do not edit; regenerated with the SDK. -->

# Subscriptions — operations

Accessor: `client.Subscriptions` · Source: `src/Paypal/Api/Subscriptions.cs` · 17 operations

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
| `ActivateBillingPlanRequest` | `src/Paypal/Requests/Subscriptions/ActivateBillingPlanRequest.cs` |
| `ActivateBillingPlanError` | `src/Paypal/Errors/ActivateBillingPlanError.cs` |
| `SubscriptionError` | `src/Paypal/Models/SubscriptionError.cs` |

### ActivateSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `ActivateSubscription(ActivateSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<ActivateSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ActivateSubscriptionOperationRequest` | `src/Paypal/Requests/Subscriptions/ActivateSubscriptionOperationRequest.cs` |
| `ActivateSubscriptionRequest` | `src/Paypal/Models/ActivateSubscriptionRequest.cs` |
| `ActivateSubscriptionError` | `src/Paypal/Errors/ActivateSubscriptionError.cs` |
| `SubscriptionError` | `src/Paypal/Models/SubscriptionError.cs` |

### CancelSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `CancelSubscription(CancelSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<CancelSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CancelSubscriptionOperationRequest` | `src/Paypal/Requests/Subscriptions/CancelSubscriptionOperationRequest.cs` |
| `CancelSubscriptionRequest` | `src/Paypal/Models/CancelSubscriptionRequest.cs` |
| `CancelSubscriptionError` | `src/Paypal/Errors/CancelSubscriptionError.cs` |
| `SubscriptionError` | `src/Paypal/Models/SubscriptionError.cs` |

### CaptureSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `CaptureSubscription(CaptureSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `SubscriptionTransactionDetails`
- **Error**: `ApiException<CaptureSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CaptureSubscriptionOperationRequest` | `src/Paypal/Requests/Subscriptions/CaptureSubscriptionOperationRequest.cs` |
| `CaptureSubscriptionRequest` | `src/Paypal/Models/CaptureSubscriptionRequest.cs` |
| `SubscriptionTransactionDetails` | `src/Paypal/Models/SubscriptionTransactionDetails.cs` |
| `CaptureSubscriptionError` | `src/Paypal/Errors/CaptureSubscriptionError.cs` |
| `SubscriptionError` | `src/Paypal/Models/SubscriptionError.cs` |

### CreateBillingPlan

- **Auth**: `options.Oauth2`
- **Signature**: `CreateBillingPlan(CreateBillingPlanRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `BillingPlan`
- **Error**: `ApiException<CreateBillingPlanError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateBillingPlanRequest` | `src/Paypal/Requests/Subscriptions/CreateBillingPlanRequest.cs` |
| `PlanRequest` | `src/Paypal/Models/PlanRequest.cs` |
| `BillingPlan` | `src/Paypal/Models/BillingPlan.cs` |
| `CreateBillingPlanError` | `src/Paypal/Errors/CreateBillingPlanError.cs` |
| `SubscriptionError` | `src/Paypal/Models/SubscriptionError.cs` |

### CreateSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `CreateSubscription(CreateSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Returns**: `Subscription`
- **Error**: `ApiException<CreateSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `CreateSubscriptionOperationRequest` | `src/Paypal/Requests/Subscriptions/CreateSubscriptionOperationRequest.cs` |
| `CreateSubscriptionRequest` | `src/Paypal/Models/CreateSubscriptionRequest.cs` |
| `Subscription` | `src/Paypal/Models/Subscription.cs` |
| `CreateSubscriptionError` | `src/Paypal/Errors/CreateSubscriptionError.cs` |
| `SubscriptionError` | `src/Paypal/Models/SubscriptionError.cs` |

### DeactivateBillingPlan

- **Auth**: `options.Oauth2`
- **Signature**: `DeactivateBillingPlan(DeactivateBillingPlanRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<DeactivateBillingPlanError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `DeactivateBillingPlanRequest` | `src/Paypal/Requests/Subscriptions/DeactivateBillingPlanRequest.cs` |
| `DeactivateBillingPlanError` | `src/Paypal/Errors/DeactivateBillingPlanError.cs` |
| `SubscriptionError` | `src/Paypal/Models/SubscriptionError.cs` |

### GetBillingPlan

- **Auth**: `options.Oauth2`
- **Signature**: `GetBillingPlan(GetBillingPlanRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `BillingPlan`
- **Error**: `ApiException<GetBillingPlanError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [401, 403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `GetBillingPlanRequest` | `src/Paypal/Requests/Subscriptions/GetBillingPlanRequest.cs` |
| `BillingPlan` | `src/Paypal/Models/BillingPlan.cs` |
| `GetBillingPlanError` | `src/Paypal/Errors/GetBillingPlanError.cs` |
| `SubscriptionError` | `src/Paypal/Models/SubscriptionError.cs` |

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
| `GetSubscriptionRequest` | `src/Paypal/Requests/Subscriptions/GetSubscriptionRequest.cs` |
| `Subscription` | `src/Paypal/Models/Subscription.cs` |
| `GetSubscriptionError` | `src/Paypal/Errors/GetSubscriptionError.cs` |
| `SubscriptionError` | `src/Paypal/Models/SubscriptionError.cs` |

### ListBillingPlans

- **Auth**: `options.Oauth2`
- **Signature**: `ListBillingPlans(ListBillingPlansRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `product_id` ← `ProductId`, `page_size` ← `PageSize`, `page` ← `Page`, `total_required` ← `TotalRequired`
- **Returns**: `PlanCollection`
- **Error**: `ApiException<ListBillingPlansError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 404, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListBillingPlansRequest` | `src/Paypal/Requests/Subscriptions/ListBillingPlansRequest.cs` |
| `PlanCollection` | `src/Paypal/Models/PlanCollection.cs` |
| `ListBillingPlansError` | `src/Paypal/Errors/ListBillingPlansError.cs` |
| `SubscriptionError` | `src/Paypal/Models/SubscriptionError.cs` |

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
| `ListSubscriptionTransactionsRequest` | `src/Paypal/Requests/Subscriptions/ListSubscriptionTransactionsRequest.cs` |
| `TransactionsList` | `src/Paypal/Models/TransactionsList.cs` |
| `ListSubscriptionTransactionsError` | `src/Paypal/Errors/ListSubscriptionTransactionsError.cs` |
| `SubscriptionError` | `src/Paypal/Models/SubscriptionError.cs` |

### ListSubscriptions

- **Auth**: `options.Oauth2`
- **Signature**: `ListSubscriptions(ListSubscriptionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `plan_ids` ← `PlanIds`, `statuses` ← `Statuses`, `created_after` ← `CreatedAfter`, `created_before` ← `CreatedBefore`, `status_updated_before` ← `StatusUpdatedBefore`, `status_updated_after` ← `StatusUpdatedAfter`, `filter` ← `Filter`, `page_size` ← `PageSize`, `page` ← `Page`, `customer_ids` ← `CustomerIds`
- **Returns**: `SubscriptionCollection`
- **Error**: `ApiException<ListSubscriptionsError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ListSubscriptionsRequest` | `src/Paypal/Requests/Subscriptions/ListSubscriptionsRequest.cs` |
| `SubscriptionCollection` | `src/Paypal/Models/SubscriptionCollection.cs` |
| `ListSubscriptionsError` | `src/Paypal/Errors/ListSubscriptionsError.cs` |
| `SubscriptionError` | `src/Paypal/Models/SubscriptionError.cs` |

### PatchBillingPlan

- **Auth**: `options.Oauth2`
- **Signature**: `PatchBillingPlan(PatchBillingPlanRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<PatchBillingPlanError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchBillingPlanRequest` | `src/Paypal/Requests/Subscriptions/PatchBillingPlanRequest.cs` |
| `Patch` | `src/Paypal/Models/Patch.cs` |
| `PatchBillingPlanError` | `src/Paypal/Errors/PatchBillingPlanError.cs` |
| `SubscriptionError` | `src/Paypal/Models/SubscriptionError.cs` |

### PatchSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `PatchSubscription(PatchSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<PatchSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `PatchSubscriptionRequest` | `src/Paypal/Requests/Subscriptions/PatchSubscriptionRequest.cs` |
| `Patch` | `src/Paypal/Models/Patch.cs` |
| `PatchSubscriptionError` | `src/Paypal/Errors/PatchSubscriptionError.cs` |
| `SubscriptionError` | `src/Paypal/Models/SubscriptionError.cs` |

### ReviseSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `ReviseSubscription(ReviseSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `ModifySubscriptionResponse`
- **Error**: `ApiException<ReviseSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `ReviseSubscriptionRequest` | `src/Paypal/Requests/Subscriptions/ReviseSubscriptionRequest.cs` |
| `ModifySubscriptionRequest` | `src/Paypal/Models/ModifySubscriptionRequest.cs` |
| `ModifySubscriptionResponse` | `src/Paypal/Models/ModifySubscriptionResponse.cs` |
| `ReviseSubscriptionError` | `src/Paypal/Errors/ReviseSubscriptionError.cs` |
| `SubscriptionError` | `src/Paypal/Models/SubscriptionError.cs` |

### SuspendSubscription

- **Auth**: `options.Oauth2`
- **Signature**: `SuspendSubscription(SuspendSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<SuspendSubscriptionError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SuspendSubscriptionRequest` | `src/Paypal/Requests/Subscriptions/SuspendSubscriptionRequest.cs` |
| `SuspendSubscription` | `src/Paypal/Models/SuspendSubscription.cs` |
| `SuspendSubscriptionError` | `src/Paypal/Errors/SuspendSubscriptionError.cs` |
| `SubscriptionError` | `src/Paypal/Models/SubscriptionError.cs` |

### UpdateBillingPlanPricingSchemes

- **Auth**: `options.Oauth2`
- **Signature**: `UpdateBillingPlanPricingSchemes(UpdateBillingPlanPricingSchemesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `Id`
- **Returns**: `void` (Task)
- **Error**: `ApiException<UpdateBillingPlanPricingSchemesError>` — **Case A (typed)**
- **Error accessors**: `TryGetSubscriptionError(out SubscriptionError)` [400, 401, 403, 404, 422, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `UpdateBillingPlanPricingSchemesRequest` | `src/Paypal/Requests/Subscriptions/UpdateBillingPlanPricingSchemesRequest.cs` |
| `UpdatePricingSchemesRequest` | `src/Paypal/Models/UpdatePricingSchemesRequest.cs` |
| `UpdateBillingPlanPricingSchemesError` | `src/Paypal/Errors/UpdateBillingPlanPricingSchemesError.cs` |
| `SubscriptionError` | `src/Paypal/Models/SubscriptionError.cs` |

