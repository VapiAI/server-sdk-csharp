using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ToolCallHookActionType>))]
public enum ToolCallHookActionType
{
    [EnumMember(Value = "tool")]
    Tool,
}
