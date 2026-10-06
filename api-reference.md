# Reference

Every operation below is shown in its throwing form. On an error status it throws `ApiException<TError>` — the status code, headers, content type and the operation's error type, `RawError` (the raw body) when the spec declares none — and where an operation offers an `…AsResult` sibling, that sibling returns `ApiResult<TResponse, TError>` instead. A request that produces no usable response surfaces as `SdkConnectionException` or `SdkTimeoutException`, a body that does not match the documented response type as `ResponseDeserializationException`, and a credential that cannot be applied as `AuthSchemeException`; all of them derive from `SdkException` and name the failed call. See [README → Error Handling](README.md#error-handling).

> Source: [PaypalClient](PaypalClient.cs)

## Orders

> Source: [Orders](Api/Orders.cs)

<details>
<summary><code>Task&lt;OrderAuthorizeResponse&gt; AuthorizeOrder(AuthorizeOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Authorizes payment for an order. To successfully authorize payment for an order, the buyer must first approve the order or a valid payment_source must be provided in the request. A buyer can approve the order upon being redirected to the rel:approve URL that was returned in the HATEOAS links in the create order response. Note: For error handling and troubleshooting, see Orders v2 errors.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.AuthorizeOrder(new AuthorizeOrderRequest { Id = "some example string" });
    // TODO: Handle 'response' of type OrderAuthorizeResponse
}
catch (ApiException<AuthorizeOrderError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[AuthorizeOrderRequest](Requests/Orders/AuthorizeOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[OrderAuthorizeResponse](Models/OrderAuthorizeResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[AuthorizeOrderError](Errors/AuthorizeOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Order&gt; CaptureOrder(CaptureOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Captures payment for an order. To successfully capture payment for an order, the buyer must first approve the order or a valid payment_source must be provided in the request. A buyer can approve the order upon being redirected to the rel:approve URL that was returned in the HATEOAS links in the create order response. Note: For error handling and troubleshooting, see Orders v2 errors.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.CaptureOrder(new CaptureOrderRequest { Id = "some example string" });
    // TODO: Handle 'response' of type Order
}
catch (ApiException<CaptureOrderError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CaptureOrderRequest](Requests/Orders/CaptureOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Order](Models/Order.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CaptureOrderError](Errors/CaptureOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Order&gt; ConfirmOrder(ConfirmOrderOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Payer confirms their intent to pay for the the Order with the given payment source.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.ConfirmOrder(new ConfirmOrderOperationRequest { Id = "some example string" });
    // TODO: Handle 'response' of type Order
}
catch (ApiException<ConfirmOrderError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ConfirmOrderOperationRequest](Requests/Orders/ConfirmOrderOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Order](Models/Order.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ConfirmOrderError](Errors/ConfirmOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Order&gt; CreateOrder(CreateOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates an order. Merchants and partners can add Level 2 and 3 data to payments to reduce risk and payment processing costs. For more information about processing payments, see checkout or multiparty checkout. Note: For error handling and troubleshooting, see Orders v2 errors.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.CreateOrder(new CreateOrderRequest
    {
        Body = new OrderRequest
        {
            Intent = CheckoutPaymentIntent.Capture,
            PurchaseUnits = [
                new PurchaseUnitRequest
                {
                    Amount = new AmountWithBreakdown
                    {
                        CurrencyCode = "some example string",
                        Value = "some example string",
                    },
                },
            ],
        },
    });
    // TODO: Handle 'response' of type Order
}
catch (ApiException<CreateOrderError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateOrderRequest](Requests/Orders/CreateOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Order](Models/Order.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CreateOrderError](Errors/CreateOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Order&gt; CreateOrderTracking(CreateOrderTrackingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Adds tracking information for an Order.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.CreateOrderTracking(new CreateOrderTrackingRequest
    {
        Id = "some example string",
        Body = new OrderTrackerRequest { CaptureId = "some example string" },
    });
    // TODO: Handle 'response' of type Order
}
catch (ApiException<CreateOrderTrackingError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateOrderTrackingRequest](Requests/Orders/CreateOrderTrackingRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Order](Models/Order.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CreateOrderTrackingError](Errors/CreateOrderTrackingError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Order&gt; GetOrder(GetOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Shows details for an order, by ID. Note: For error handling and troubleshooting, see Orders v2 errors.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Orders.GetOrder(new GetOrderRequest { Id = "some example string" });
    // TODO: Handle 'response' of type Order
}
catch (ApiException<GetOrderError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetOrderRequest](Requests/Orders/GetOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Order](Models/Order.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetOrderError](Errors/GetOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PatchOrder(PatchOrderRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates an order with a `CREATED` or `APPROVED` status. You cannot update an order with the `COMPLETED` status.<br/><br/>To make an update, you must provide a `reference_id`. If you omit this value with an order that contains only one purchase unit, PayPal sets the value to `default` which enables you to use the path: <code>\"/purchase_units/@reference_id=='default'/{attribute-or-object}\"</code>. Merchants and partners can add Level 2 and 3 data to payments to reduce risk and payment processing costs. For more information about processing payments, see <a href="https://developer.paypal.com/docs/checkout/advanced/processing/">checkout</a> or <a href="https://developer.paypal.com/docs/multiparty/checkout/advanced/processing/">multiparty checkout</a>.<blockquote><strong>Note:</strong> For error handling and troubleshooting, see <a href="https://developer.paypal.com/api/rest/reference/orders/v2/errors/#patch-order">Orders v2 errors</a>.</blockquote>Patchable attributes or objects:<br/><br/><table><thead><th>Attribute</th><th>Op</th><th>Notes</th></thead><tbody><tr><td><code>intent</code></td><td>replace</td><td></td></tr><tr><td><code>payer</code></td><td>replace, add</td><td>Using replace op for <code>payer</code> will replace the whole <code>payer</code> object with the value sent in request.</td></tr><tr><td><code>purchase_units</code></td><td>replace, add</td><td></td></tr><tr><td><code>purchase_units[].custom_id</code></td><td>replace, add, remove</td><td></td></tr><tr><td><code>purchase_units[].description</code></td><td>replace, add, remove</td><td></td></tr><tr><td><code>purchase_units[].payee.email</code></td><td>replace</td><td></td></tr><tr><td><code>purchase_units[].shipping.name</code></td><td>replace, add</td><td></td></tr><tr><td><code>purchase_units[].shipping.email_address</code></td><td>replace, add</td><td></td></tr><tr><td><code>purchase_units[].shipping.phone_number</code></td><td>replace, add</td><td></td></tr><tr><td><code>purchase_units[].shipping.options</code></td><td>replace, add</td><td></td></tr><tr><td><code>purchase_units[].shipping.address</code></td><td>replace, add</td><td></td></tr><tr><td><code>purchase_units[].shipping.type</code></td><td>replace, add</td><td></td></tr><tr><td><code>purchase_units[].soft_descriptor</code></td><td>replace, remove</td><td></td></tr><tr><td><code>purchase_units[].amount</code></td><td>replace</td><td></td></tr><tr><td><code>purchase_units[].items</code></td><td>replace, add, remove</td><td></td></tr><tr><td><code>purchase_units[].invoice_id</code></td><td>replace, add, remove</td><td></td></tr><tr><td><code>purchase_units[].payment_instruction</code></td><td>replace</td><td></td></tr><tr><td><code>purchase_units[].payment_instruction.disbursement_mode</code></td><td>replace</td><td>By default, <code>disbursement_mode</code> is <code>INSTANT</code>.</td></tr><tr><td><code>purchase_units[].payment_instruction.payee_receivable_fx_rate_id</code></td><td>replace, add, remove</td><td></td></tr><tr><td><code>purchase_units[].payment_instruction.platform_fees</code></td><td>replace, add, remove</td><td></td></tr><tr><td><code>purchase_units[].supplementary_data.airline</code></td><td>replace, add, remove</td><td></td></tr><tr><td><code>purchase_units[].supplementary_data.card</code></td><td>replace, add, remove</td><td></td></tr><tr><td><code>application_context.client_configuration</code></td><td>replace, add</td><td></td></tr></tbody></table>

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Orders.PatchOrder(new PatchOrderRequest { Id = "some example string" });
}
catch (ApiException<PatchOrderError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchOrderRequest](Requests/Orders/PatchOrderRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PatchOrderError](Errors/PatchOrderError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task UpdateOrderTracking(UpdateOrderTrackingRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates or cancels the tracking information for a PayPal order, by ID. Updatable attributes or objects: Attribute Op Notes items replace Using replace op for items will replace the entire items object with the value sent in request. notify_payer replace, add status replace Only patching status to CANCELLED is currently supported.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Orders.UpdateOrderTracking(new UpdateOrderTrackingRequest
    {
        Id = "some example string",
        TrackerId = "some example string",
    });
}
catch (ApiException<UpdateOrderTrackingError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateOrderTrackingRequest](Requests/Orders/UpdateOrderTrackingRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[UpdateOrderTrackingError](Errors/UpdateOrderTrackingError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Payments

> Source: [Payments](Api/Payments.cs)

<details>
<summary><code>Task&lt;CapturedPayment&gt; CaptureAuthorizedPayment(CaptureAuthorizedPaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Captures an authorized payment, by ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.CaptureAuthorizedPayment(new CaptureAuthorizedPaymentRequest
    {
        AuthorizationId = "some example string",
    });
    // TODO: Handle 'response' of type CapturedPayment
}
catch (ApiException<CaptureAuthorizedPaymentError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CaptureAuthorizedPaymentRequest](Requests/Payments/CaptureAuthorizedPaymentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CapturedPayment](Models/CapturedPayment.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CaptureAuthorizedPaymentError](Errors/CaptureAuthorizedPaymentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentAuthorization&gt; GetAuthorizedPayment(GetAuthorizedPaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Shows details for an authorized payment, by ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.GetAuthorizedPayment(new GetAuthorizedPaymentRequest
    {
        AuthorizationId = "some example string",
    });
    // TODO: Handle 'response' of type PaymentAuthorization
}
catch (ApiException<GetAuthorizedPaymentError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetAuthorizedPaymentRequest](Requests/Payments/GetAuthorizedPaymentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentAuthorization](Models/PaymentAuthorization.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetAuthorizedPaymentError](Errors/GetAuthorizedPaymentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CapturedPayment&gt; GetCapturedPayment(GetCapturedPaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Shows details for a captured payment, by ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.GetCapturedPayment(new GetCapturedPaymentRequest
    {
        CaptureId = "some example string",
    });
    // TODO: Handle 'response' of type CapturedPayment
}
catch (ApiException<GetCapturedPaymentError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetCapturedPaymentRequest](Requests/Payments/GetCapturedPaymentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CapturedPayment](Models/CapturedPayment.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetCapturedPaymentError](Errors/GetCapturedPaymentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Refund&gt; GetRefund(GetRefundRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Shows details for a refund, by ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.GetRefund(new GetRefundRequest { RefundId = "some example string" });
    // TODO: Handle 'response' of type Refund
}
catch (ApiException<GetRefundError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetRefundRequest](Requests/Payments/GetRefundRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Refund](Models/Refund.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetRefundError](Errors/GetRefundError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentAuthorization&gt; ReauthorizePayment(ReauthorizePaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Reauthorizes an authorized PayPal account payment, by ID. To ensure that funds are still available, reauthorize a payment after its initial three-day honor period expires. Within the 29-day authorization period, you can issue multiple re-authorizations after the honor period expires. If 30 days have transpired since the date of the original authorization, you must create an authorized payment instead of reauthorizing the original authorized payment. A reauthorized payment itself has a new honor period of three days. You can reauthorize an authorized payment from 4 to 29 days after the 3-day honor period. The allowed amount depends on context and geography, for example in US it is up to 115% of the original authorized amount, not to exceed an increase of $75 USD. Supports only the `amount` request parameter.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.ReauthorizePayment(new ReauthorizePaymentRequest
    {
        AuthorizationId = "some example string",
    });
    // TODO: Handle 'response' of type PaymentAuthorization
}
catch (ApiException<ReauthorizePaymentError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ReauthorizePaymentRequest](Requests/Payments/ReauthorizePaymentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentAuthorization](Models/PaymentAuthorization.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ReauthorizePaymentError](Errors/ReauthorizePaymentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Refund&gt; RefundCapturedPayment(RefundCapturedPaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Refunds a captured payment, by ID. For a full refund, include an empty payload in the JSON request body. For a partial refund, include an amount object in the JSON request body.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.RefundCapturedPayment(new RefundCapturedPaymentRequest
    {
        CaptureId = "some example string",
    });
    // TODO: Handle 'response' of type Refund
}
catch (ApiException<RefundCapturedPaymentError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[RefundCapturedPaymentRequest](Requests/Payments/RefundCapturedPaymentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Refund](Models/Refund.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RefundCapturedPaymentError](Errors/RefundCapturedPaymentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentAuthorization&gt; VoidPayment(VoidPaymentRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Voids, or cancels, an authorized payment, by ID. You cannot void an authorized payment that has been fully captured.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Payments.VoidPayment(new VoidPaymentRequest
    {
        AuthorizationId = "some example string",
    });
    // TODO: Handle 'response' of type PaymentAuthorization
}
catch (ApiException<VoidPaymentError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[VoidPaymentRequest](Requests/Payments/VoidPaymentRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentAuthorization](Models/PaymentAuthorization.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[VoidPaymentError](Errors/VoidPaymentError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Subscriptions

> Source: [Subscriptions](Api/Subscriptions.cs)

<details>
<summary><code>Task ActivateBillingPlan(ActivateBillingPlanRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Activates a plan, by ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Subscriptions.ActivateBillingPlan(new ActivateBillingPlanRequest { Id = "some example string" });
}
catch (ApiException<ActivateBillingPlanError> ex)
{
    if (ex.Error.TryGetSubscriptionError(out var error))
    {
        // TODO: Handle 'error' of type SubscriptionError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ActivateBillingPlanRequest](Requests/Subscriptions/ActivateBillingPlanRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ActivateBillingPlanError](Errors/ActivateBillingPlanError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task ActivateSubscription(ActivateSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Activates the subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Subscriptions.ActivateSubscription(new ActivateSubscriptionOperationRequest
    {
        Id = "some example string",
    });
}
catch (ApiException<ActivateSubscriptionError> ex)
{
    if (ex.Error.TryGetSubscriptionError(out var error))
    {
        // TODO: Handle 'error' of type SubscriptionError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ActivateSubscriptionOperationRequest](Requests/Subscriptions/ActivateSubscriptionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ActivateSubscriptionError](Errors/ActivateSubscriptionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task CancelSubscription(CancelSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Cancels the subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Subscriptions.CancelSubscription(new CancelSubscriptionOperationRequest
    {
        Id = "some example string",
    });
}
catch (ApiException<CancelSubscriptionError> ex)
{
    if (ex.Error.TryGetSubscriptionError(out var error))
    {
        // TODO: Handle 'error' of type SubscriptionError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CancelSubscriptionOperationRequest](Requests/Subscriptions/CancelSubscriptionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CancelSubscriptionError](Errors/CancelSubscriptionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SubscriptionTransactionDetails&gt; CaptureSubscription(CaptureSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Captures an authorized payment from the subscriber on the subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.CaptureSubscription(new CaptureSubscriptionOperationRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type SubscriptionTransactionDetails
}
catch (ApiException<CaptureSubscriptionError> ex)
{
    if (ex.Error.TryGetSubscriptionError(out var error))
    {
        // TODO: Handle 'error' of type SubscriptionError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CaptureSubscriptionOperationRequest](Requests/Subscriptions/CaptureSubscriptionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SubscriptionTransactionDetails](Models/SubscriptionTransactionDetails.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CaptureSubscriptionError](Errors/CaptureSubscriptionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BillingPlan&gt; CreateBillingPlan(CreateBillingPlanRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a plan that defines pricing and billing cycle details for subscriptions.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.CreateBillingPlan(new CreateBillingPlanRequest());
    // TODO: Handle 'response' of type BillingPlan
}
catch (ApiException<CreateBillingPlanError> ex)
{
    if (ex.Error.TryGetSubscriptionError(out var error))
    {
        // TODO: Handle 'error' of type SubscriptionError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateBillingPlanRequest](Requests/Subscriptions/CreateBillingPlanRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BillingPlan](Models/BillingPlan.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CreateBillingPlanError](Errors/CreateBillingPlanError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Subscription&gt; CreateSubscription(CreateSubscriptionOperationRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.CreateSubscription(new CreateSubscriptionOperationRequest());
    // TODO: Handle 'response' of type Subscription
}
catch (ApiException<CreateSubscriptionError> ex)
{
    if (ex.Error.TryGetSubscriptionError(out var error))
    {
        // TODO: Handle 'error' of type SubscriptionError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateSubscriptionOperationRequest](Requests/Subscriptions/CreateSubscriptionOperationRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Subscription](Models/Subscription.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CreateSubscriptionError](Errors/CreateSubscriptionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeactivateBillingPlan(DeactivateBillingPlanRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Deactivates a plan, by ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Subscriptions.DeactivateBillingPlan(new DeactivateBillingPlanRequest { Id = "some example string" });
}
catch (ApiException<DeactivateBillingPlanError> ex)
{
    if (ex.Error.TryGetSubscriptionError(out var error))
    {
        // TODO: Handle 'error' of type SubscriptionError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeactivateBillingPlanRequest](Requests/Subscriptions/DeactivateBillingPlanRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeactivateBillingPlanError](Errors/DeactivateBillingPlanError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;BillingPlan&gt; GetBillingPlan(GetBillingPlanRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Shows details for a plan, by ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.GetBillingPlan(new GetBillingPlanRequest { Id = "some example string" });
    // TODO: Handle 'response' of type BillingPlan
}
catch (ApiException<GetBillingPlanError> ex)
{
    if (ex.Error.TryGetSubscriptionError(out var error))
    {
        // TODO: Handle 'error' of type SubscriptionError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetBillingPlanRequest](Requests/Subscriptions/GetBillingPlanRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BillingPlan](Models/BillingPlan.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetBillingPlanError](Errors/GetBillingPlanError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;Subscription&gt; GetSubscription(GetSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Shows details for a subscription, by ID.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.GetSubscription(new GetSubscriptionRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type Subscription
}
catch (ApiException<GetSubscriptionError> ex)
{
    if (ex.Error.TryGetSubscriptionError(out var error))
    {
        // TODO: Handle 'error' of type SubscriptionError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSubscriptionRequest](Requests/Subscriptions/GetSubscriptionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[Subscription](Models/Subscription.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetSubscriptionError](Errors/GetSubscriptionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PlanCollection&gt; ListBillingPlans(ListBillingPlansRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists billing plans.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.ListBillingPlans(new ListBillingPlansRequest());
    // TODO: Handle 'response' of type PlanCollection
}
catch (ApiException<ListBillingPlansError> ex)
{
    if (ex.Error.TryGetSubscriptionError(out var error))
    {
        // TODO: Handle 'error' of type SubscriptionError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListBillingPlansRequest](Requests/Subscriptions/ListBillingPlansRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PlanCollection](Models/PlanCollection.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ListBillingPlansError](Errors/ListBillingPlansError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;TransactionsList&gt; ListSubscriptionTransactions(ListSubscriptionTransactionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists transactions for a subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.ListSubscriptionTransactions(new ListSubscriptionTransactionsRequest
    {
        Id = "some example string",
        StartTime = "some example string",
        EndTime = "some example string",
    });
    // TODO: Handle 'response' of type TransactionsList
}
catch (ApiException<ListSubscriptionTransactionsError> ex)
{
    if (ex.Error.TryGetSubscriptionError(out var error))
    {
        // TODO: Handle 'error' of type SubscriptionError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListSubscriptionTransactionsRequest](Requests/Subscriptions/ListSubscriptionTransactionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[TransactionsList](Models/TransactionsList.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ListSubscriptionTransactionsError](Errors/ListSubscriptionTransactionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SubscriptionCollection&gt; ListSubscriptions(ListSubscriptionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all subscriptions for merchant account.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.ListSubscriptions(new ListSubscriptionsRequest());
    // TODO: Handle 'response' of type SubscriptionCollection
}
catch (ApiException<ListSubscriptionsError> ex)
{
    if (ex.Error.TryGetSubscriptionError(out var error))
    {
        // TODO: Handle 'error' of type SubscriptionError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListSubscriptionsRequest](Requests/Subscriptions/ListSubscriptionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SubscriptionCollection](Models/SubscriptionCollection.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ListSubscriptionsError](Errors/ListSubscriptionsError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PatchBillingPlan(PatchBillingPlanRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a plan with the `CREATED` or `ACTIVE` status. For an `INACTIVE` plan, you can make only status updates. You can patch these attributes and objects: Attribute or object Operations description replace payment_preferences.auto_bill_outstanding replace taxes.percentage replace payment_preferences.payment_failure_threshold replace payment_preferences.setup_fee replace payment_preferences.setup_fee_failure_action replace name replace

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Subscriptions.PatchBillingPlan(new PatchBillingPlanRequest { Id = "some example string" });
}
catch (ApiException<PatchBillingPlanError> ex)
{
    if (ex.Error.TryGetSubscriptionError(out var error))
    {
        // TODO: Handle 'error' of type SubscriptionError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchBillingPlanRequest](Requests/Subscriptions/PatchBillingPlanRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PatchBillingPlanError](Errors/PatchBillingPlanError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task PatchSubscription(PatchSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates a subscription which could be in ACTIVE or SUSPENDED status. You can override plan level default attributes by providing customised values for plan path in the patch request. You cannot update attributes that have already completed (Example - trial cycles can’t be updated if completed). Once overridden, changes to plan resource will not impact subscription. Any price update will not impact billing cycles within next 10 days (Applicable only for subscriptions funded by PayPal account). Following are the fields eligible for patch. Attribute or object Operations billing_info.outstanding_balance replace custom_id add,replace plan.billing_cycles[@sequence==n]. pricing_scheme.fixed_price add,replace plan.billing_cycles[@sequence==n]. pricing_scheme.tiers replace plan.billing_cycles[@sequence==n]. total_cycles replace plan.payment_preferences. auto_bill_outstanding replace plan.payment_preferences. payment_failure_threshold replace plan.taxes.inclusive add,replace plan.taxes.percentage add,replace shipping_amount add,replace start_time replace subscriber.shipping_address add,replace subscriber.payment_source (for subscriptions funded by card payments) replace

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Subscriptions.PatchSubscription(new PatchSubscriptionRequest { Id = "some example string" });
}
catch (ApiException<PatchSubscriptionError> ex)
{
    if (ex.Error.TryGetSubscriptionError(out var error))
    {
        // TODO: Handle 'error' of type SubscriptionError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[PatchSubscriptionRequest](Requests/Subscriptions/PatchSubscriptionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[PatchSubscriptionError](Errors/PatchSubscriptionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;ModifySubscriptionResponse&gt; ReviseSubscription(ReviseSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates the quantity of the product or service in a subscription. You can also use this method to switch the plan and update the `shipping_amount`, `shipping_address` values for the subscription. This type of update requires the buyer's consent.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Subscriptions.ReviseSubscription(new ReviseSubscriptionRequest
    {
        Id = "some example string",
    });
    // TODO: Handle 'response' of type ModifySubscriptionResponse
}
catch (ApiException<ReviseSubscriptionError> ex)
{
    if (ex.Error.TryGetSubscriptionError(out var error))
    {
        // TODO: Handle 'error' of type SubscriptionError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ReviseSubscriptionRequest](Requests/Subscriptions/ReviseSubscriptionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[ModifySubscriptionResponse](Models/ModifySubscriptionResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ReviseSubscriptionError](Errors/ReviseSubscriptionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task SuspendSubscription(SuspendSubscriptionRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Suspends the subscription.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Subscriptions.SuspendSubscription(new SuspendSubscriptionRequest { Id = "some example string" });
}
catch (ApiException<SuspendSubscriptionError> ex)
{
    if (ex.Error.TryGetSubscriptionError(out var error))
    {
        // TODO: Handle 'error' of type SubscriptionError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SuspendSubscriptionRequest](Requests/Subscriptions/SuspendSubscriptionRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SuspendSubscriptionError](Errors/SuspendSubscriptionError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task UpdateBillingPlanPricingSchemes(UpdateBillingPlanPricingSchemesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Updates pricing for a plan. For example, you can update a regular billing cycle from $5 per month to $7 per month.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Subscriptions.UpdateBillingPlanPricingSchemes(new UpdateBillingPlanPricingSchemesRequest
    {
        Id = "some example string",
    });
}
catch (ApiException<UpdateBillingPlanPricingSchemesError> ex)
{
    if (ex.Error.TryGetSubscriptionError(out var error))
    {
        // TODO: Handle 'error' of type SubscriptionError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[UpdateBillingPlanPricingSchemesRequest](Requests/Subscriptions/UpdateBillingPlanPricingSchemesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[UpdateBillingPlanPricingSchemesError](Errors/UpdateBillingPlanPricingSchemesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## TransactionSearch

> Source: [TransactionSearch](Api/TransactionSearch.cs)

<details>
<summary><code>Task&lt;BalancesResponse&gt; SearchBalances(SearchBalancesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

List all balances. Specify date time to list balances for that time that appear in the response. Notes: It takes a maximum of three hours for balances to appear in the list balances call. This call lists balances upto the previous three years.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionSearch.SearchBalances(new SearchBalancesRequest());
    // TODO: Handle 'response' of type BalancesResponse
}
catch (ApiException<SearchBalancesError> ex)
{
    if (ex.Error.TryGetDefaultError(out var error))
    {
        // TODO: Handle 'error' of type DefaultError
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchBalancesRequest](Requests/TransactionSearch/SearchBalancesRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[BalancesResponse](Models/BalancesResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[SearchBalancesError](Errors/SearchBalancesError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SearchResponse&gt; SearchTransactions(SearchTransactionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Lists transactions. Specify one or more query parameters to filter the transaction that appear in the response. Notes: If you specify one or more optional query parameters, the ending_balance response field is empty. It takes a maximum of three hours for executed transactions to appear in the list transactions call. This call lists transaction for the previous three years.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.TransactionSearch.SearchTransactions(new SearchTransactionsRequest
    {
        StartDate = "some example string",
        EndDate = "some example string",
    });
    // TODO: Handle 'response' of type SearchResponse
}
catch (ApiException<RawError> ex)
{
    // TODO: Handle 'ex.Error' of type RawError
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[SearchTransactionsRequest](Requests/TransactionSearch/SearchTransactionsRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SearchResponse](Models/SearchResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[RawError](Core/ErrorResponse/RawError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

## Vault

> Source: [Vault](Api/Vault.cs)

<details>
<summary><code>Task&lt;PaymentTokenResponse&gt; CreatePaymentToken(CreatePaymentTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a Payment Token from the given payment source and adds it to the Vault of the associated customer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vault.CreatePaymentToken(new CreatePaymentTokenRequest
    {
        Body = new PaymentTokenRequest { PaymentSource = new PaymentTokenRequestPaymentSource() },
    });
    // TODO: Handle 'response' of type PaymentTokenResponse
}
catch (ApiException<CreatePaymentTokenError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreatePaymentTokenRequest](Requests/Vault/CreatePaymentTokenRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentTokenResponse](Models/PaymentTokenResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CreatePaymentTokenError](Errors/CreatePaymentTokenError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SetupTokenResponse&gt; CreateSetupToken(CreateSetupTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Creates a Setup Token from the given payment source and adds it to the Vault of the associated customer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vault.CreateSetupToken(new CreateSetupTokenRequest
    {
        Body = new SetupTokenRequest { PaymentSource = new SetupTokenRequestPaymentSource() },
    });
    // TODO: Handle 'response' of type SetupTokenResponse
}
catch (ApiException<CreateSetupTokenError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[CreateSetupTokenRequest](Requests/Vault/CreateSetupTokenRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SetupTokenResponse](Models/SetupTokenResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[CreateSetupTokenError](Errors/CreateSetupTokenError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task DeletePaymentToken(DeletePaymentTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Delete the payment token associated with the payment token id.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    await client.Vault.DeletePaymentToken(new DeletePaymentTokenRequest { Id = "some example string" });
}
catch (ApiException<DeletePaymentTokenError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[DeletePaymentTokenRequest](Requests/Vault/DeletePaymentTokenRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: No content

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[DeletePaymentTokenError](Errors/DeletePaymentTokenError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;PaymentTokenResponse&gt; GetPaymentToken(GetPaymentTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a readable representation of vaulted payment source associated with the payment token id.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vault.GetPaymentToken(new GetPaymentTokenRequest { Id = "some example string" });
    // TODO: Handle 'response' of type PaymentTokenResponse
}
catch (ApiException<GetPaymentTokenError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetPaymentTokenRequest](Requests/Vault/GetPaymentTokenRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[PaymentTokenResponse](Models/PaymentTokenResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetPaymentTokenError](Errors/GetPaymentTokenError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;SetupTokenResponse&gt; GetSetupToken(GetSetupTokenRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns a readable representation of temporarily vaulted payment source associated with the setup token id.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vault.GetSetupToken(new GetSetupTokenRequest { Id = "some example string" });
    // TODO: Handle 'response' of type SetupTokenResponse
}
catch (ApiException<GetSetupTokenError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[GetSetupTokenRequest](Requests/Vault/GetSetupTokenRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[SetupTokenResponse](Models/SetupTokenResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[GetSetupTokenError](Errors/GetSetupTokenError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

<details>
<summary><code>Task&lt;CustomerVaultPaymentTokensResponse&gt; ListCustomerPaymentTokens(ListCustomerPaymentTokensRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default);</code></summary>

<dl>
<dd>

### Description

<dl>
<dd>

Returns all payment tokens for a customer.

</dd>
</dl>

### Usage

<dl>
<dd>

```csharp
try
{
    var response = await client.Vault.ListCustomerPaymentTokens(new ListCustomerPaymentTokensRequest
    {
        CustomerId = "some example string",
    });
    // TODO: Handle 'response' of type CustomerVaultPaymentTokensResponse
}
catch (ApiException<ListCustomerPaymentTokensError> ex)
{
    if (ex.Error.TryGetError(out var error))
    {
        // TODO: Handle 'error' of type Error
    }
}
```

</dd>
</dl>

### Request

<dl>
<dd>

<code>[ListCustomerPaymentTokensRequest](Requests/Vault/ListCustomerPaymentTokensRequest.cs)</code>

</dd>
</dl>

### Response

<dl>
<dd>

**OnSuccess**: <code>[CustomerVaultPaymentTokensResponse](Models/CustomerVaultPaymentTokensResponse.cs)</code>

**OnError**: <code>[ApiException](Core/Exceptions/ApiException.cs)&lt;[ListCustomerPaymentTokensError](Errors/ListCustomerPaymentTokensError.cs)&gt;</code>

</dd>
</dl>

</dd>
</dl>

</details>

