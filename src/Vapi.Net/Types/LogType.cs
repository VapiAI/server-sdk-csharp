using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<LogType>))]
public enum LogType
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
