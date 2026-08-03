using System.Text.Json.Serialization;
using Paypal.Core.Enum;

namespace Paypal.Models.Enums;

/// <summary>
/// The HTTP method required to make the related call.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<LinkHttpMethod>))]
public sealed record LinkHttpMethod : StringEnum<LinkHttpMethod>
{
    private LinkHttpMethod(string value) : base(value)
    {
    }

    public static readonly LinkHttpMethod Get = new("GET");

    public static readonly LinkHttpMethod Post = new("POST");

    public static readonly LinkHttpMethod Put = new("PUT");

    public static readonly LinkHttpMethod Delete = new("DELETE");

    public static readonly LinkHttpMethod Head = new("HEAD");

    public static readonly LinkHttpMethod Connect = new("CONNECT");

    public static readonly LinkHttpMethod Options = new("OPTIONS");

    public static readonly LinkHttpMethod Patch = new("PATCH");

    public static LinkHttpMethod FromValue(string value) => FromValueCore(value);
}
