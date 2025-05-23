using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FormatPlanFormattersEnabledItem>))]
public enum FormatPlanFormattersEnabledItem
{
    [EnumMember(Value = "markdown")]
    Markdown,

    [EnumMember(Value = "asterisk")]
    Asterisk,

    [EnumMember(Value = "quote")]
    Quote,

    [EnumMember(Value = "dash")]
    Dash,

    [EnumMember(Value = "newline")]
    Newline,

    [EnumMember(Value = "colon")]
    Colon,

    [EnumMember(Value = "acronym")]
    Acronym,

    [EnumMember(Value = "dollarAmount")]
    DollarAmount,

    [EnumMember(Value = "email")]
    Email,

    [EnumMember(Value = "date")]
    Date,

    [EnumMember(Value = "time")]
    Time,

    [EnumMember(Value = "distance")]
    Distance,

    [EnumMember(Value = "unit")]
    Unit,

    [EnumMember(Value = "percentage")]
    Percentage,

    [EnumMember(Value = "phoneNumber")]
    PhoneNumber,

    [EnumMember(Value = "number")]
    Number,

    [EnumMember(Value = "stripAsterisk")]
    StripAsterisk,
}
