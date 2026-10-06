<!-- Generated file — do not edit; regenerated with the SDK. -->

# TransactionSearch — operations

Accessor: `client.TransactionSearch` · Source: `Api/TransactionSearch.cs` · 2 operations

**Type sources**: the file declaring each type an operation names (`RawError` excluded — see sdk-map.md).

### SearchBalances

- **Auth**: `options.Oauth2`
- **Signature**: `SearchBalances(SearchBalancesRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
- **Query params (wire ← C#)**: `as_of_time` ← `AsOfTime`, `currency_code` ← `CurrencyCode`
- **Returns**: `BalancesResponse`
- **Error**: `ApiException<SearchBalancesError>` — **Case A (typed)**
- **Error accessors**: `TryGetDefaultError(out DefaultError)` [400, 403, 500] · `TryGetRawError(out RawError)` [fallback]

| Type | Source |
| --- | --- |
| `SearchBalancesRequest` | `Requests/TransactionSearch/SearchBalancesRequest.cs` |
| `BalancesResponse` | `Models/BalancesResponse.cs` |
| `SearchBalancesError` | `Errors/SearchBalancesError.cs` |
| `DefaultError` | `Models/DefaultError.cs` |

### SearchTransactions

- **Auth**: `options.Oauth2`
- **Signature**: `SearchTransactions(SearchTransactionsRequest request, RequestOptions? requestOptions = null, CancellationToken cancellationToken = default)`
  - required: `StartDate`, `EndDate`
- **Query params (wire ← C#)**: `start_date` ← `StartDate`, `end_date` ← `EndDate`, `transaction_id` ← `TransactionId`, `transaction_type` ← `TransactionType`, `transaction_status` ← `TransactionStatus`, `transaction_amount` ← `TransactionAmount`, `transaction_currency` ← `TransactionCurrency`, `payment_instrument_type` ← `PaymentInstrumentType`, `store_id` ← `StoreId`, `terminal_id` ← `TerminalId`, `fields` ← `Fields`, `balance_affecting_records_only` ← `BalanceAffectingRecordsOnly`, `page_size` ← `PageSize`, `page` ← `Page`
- **Returns**: `SearchResponse`
- **Error**: `ApiException<RawError>` — **Case B**

| Type | Source |
| --- | --- |
| `SearchTransactionsRequest` | `Requests/TransactionSearch/SearchTransactionsRequest.cs` |
| `SearchResponse` | `Models/SearchResponse.cs` |

