using System.Text.Json.Serialization;
using Paypal.Core.Enum;

namespace Paypal.Models.Enums;

/// <summary>
/// The type of the billing cycle.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TenureType1>))]
public sealed record TenureType1 : StringEnum<TenureType1>
{
    private TenureType1(string value) : base(value)
    {
    }

    /// <summary>
    /// A regular billing cycle.
    /// </summary>
    public static readonly TenureType1 Regular = new("REGULAR");

    /// <summary>
    /// A trial billing cycle.
    /// </summary>
    public static readonly TenureType1 Trial = new("TRIAL");

    public static TenureType1 FromValue(string value) => FromValueCore(value);
}
