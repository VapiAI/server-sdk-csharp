using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessageToolCallsType>))]
public enum ServerMessageToolCallsType
{
    [EnumMember(Value = "tool-calls")]
    ToolCalls,
}
