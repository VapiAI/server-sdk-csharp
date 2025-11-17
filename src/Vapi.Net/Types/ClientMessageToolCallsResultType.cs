using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ClientMessageToolCallsResultType>))]
public enum ClientMessageToolCallsResultType
{
    [EnumMember(Value = "tool-calls-result")]
    ToolCallsResult,
}
