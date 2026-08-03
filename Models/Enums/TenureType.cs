using System.Text.Json.Serialization;
using Paypal.Core.Enum;

namespace Paypal.Models.Enums;

/// <summary>
/// The tenure type of the billing cycle. In case of a plan having trial cycle, only 2 trial cycles are allowed per plan., The tenure type of the billing cycle identifies if the billing cycle is a trial(free or discounted) or regular billing cycle., The tenure type of the billing cycle. In case of a plan having trial cycle, only 2 trial cycles are allowed per plan., The type of the billing cycle., The tenure type of the billing cycle identifies if the billing cycle is a trial(free or discounted) or regular billing cycle.
/// </summary>
[JsonConverter(typeof(StringEnumConverter<TenureType>))]
public sealed record TenureType : StringEnum<TenureType>
{
    private TenureType(string value) : base(value)
    {
    }

    /// <summary>
    /// A regular billing cycle.
    /// </summary>
    public static readonly TenureType Regular = new("REGULAR");

    /// <summary>
    /// A trial billing cycle.
    /// </summary>
    public static readonly TenureType Trial = new("TRIAL");

    public static TenureType FromValue(string value) => FromValueCore(value);
}
