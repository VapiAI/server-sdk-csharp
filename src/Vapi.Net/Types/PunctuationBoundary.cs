using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<PunctuationBoundary>))]
public enum PunctuationBoundary
{
    [EnumMember(Value = "。")]
    Circle,

    [EnumMember(Value = "，")]
    FullWidthComma,

    [EnumMember(Value = ".")]
    Dot,

    [EnumMember(Value = "!")]
    Exclamation,

    [EnumMember(Value = "?")]
    Question,

    [EnumMember(Value = ";")]
    Semicolon,

    [EnumMember(Value = ")")]
    Parenthesis,

    [EnumMember(Value = "،")]
    ArabicComma,

    [EnumMember(Value = "۔")]
    UrduFullStop,

    [EnumMember(Value = "।")]
    BengaliFullStop,

    [EnumMember(Value = "॥")]
    DoubleDanda,

    [EnumMember(Value = "|")]
    Pipe,

    [EnumMember(Value = "||")]
    DoublePipe,

    [EnumMember(Value = ",")]
    HalfWidthComma,

    [EnumMember(Value = ":")]
    Colon,
}
