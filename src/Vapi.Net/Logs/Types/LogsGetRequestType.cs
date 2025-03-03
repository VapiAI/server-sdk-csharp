using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<LogsGetRequestType>))]
public enum LogsGetRequestType
{
    [EnumMember(Value = "API")]
    Api,

    [EnumMember(Value = "Webhook")]
    Webhook,

    [EnumMember(Value = "Call")]
    Call,

    [EnumMember(Value = "Provider")]
    Provider,
}
