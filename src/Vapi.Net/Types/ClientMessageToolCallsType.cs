using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ClientMessageToolCallsType>))]
public enum ClientMessageToolCallsType
{
    [EnumMember(Value = "tool-calls")]
    ToolCalls,
}
