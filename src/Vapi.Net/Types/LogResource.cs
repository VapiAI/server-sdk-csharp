using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<LogResource>))]
public enum LogResource
{
    [EnumMember(Value = "org")]
    Org,

    [EnumMember(Value = "assistant")]
    Assistant,

    [EnumMember(Value = "analytics")]
    Analytics,

    [EnumMember(Value = "credential")]
    Credential,

    [EnumMember(Value = "phone-number")]
    PhoneNumber,

    [EnumMember(Value = "block")]
    Block,

    [EnumMember(Value = "voice-library")]
    VoiceLibrary,

    [EnumMember(Value = "provider")]
    Provider,

    [EnumMember(Value = "tool")]
    Tool,

    [EnumMember(Value = "token")]
    Token,

    [EnumMember(Value = "template")]
    Template,

    [EnumMember(Value = "squad")]
    Squad,

    [EnumMember(Value = "call")]
    Call,

    [EnumMember(Value = "file")]
    File,

    [EnumMember(Value = "metric")]
    Metric,

    [EnumMember(Value = "log")]
    Log,
}
