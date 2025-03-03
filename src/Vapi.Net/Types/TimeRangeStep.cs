using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TimeRangeStep>))]
public enum TimeRangeStep
{
    [EnumMember(Value = "second")]
    Second,

    [EnumMember(Value = "minute")]
    Minute,

    [EnumMember(Value = "hour")]
    Hour,

    [EnumMember(Value = "day")]
    Day,

    [EnumMember(Value = "week")]
    Week,

    [EnumMember(Value = "month")]
    Month,

    [EnumMember(Value = "quarter")]
    Quarter,

    [EnumMember(Value = "year")]
    Year,

    [EnumMember(Value = "decade")]
    Decade,

    [EnumMember(Value = "century")]
    Century,

    [EnumMember(Value = "millennium")]
    Millennium,
}
