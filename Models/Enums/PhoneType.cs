using System.Text.Json.Serialization;
using Paypal.Core.Enum;

namespace Paypal.Models.Enums;

/// <summary>
/// The phone type.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<PhoneType>))]
public sealed record PhoneType : StringEnum<PhoneType>
{
    private PhoneType(string value) : base(value)
    {
    }

    public static readonly PhoneType Fax = new("FAX");

    public static readonly PhoneType Home = new("HOME");

    public static readonly PhoneType Mobile = new("MOBILE");

    public static readonly PhoneType Other = new("OTHER");

    public static readonly PhoneType Pager = new("PAGER");

    public static PhoneType FromValue(string value) => FromValueCore(value);
}
