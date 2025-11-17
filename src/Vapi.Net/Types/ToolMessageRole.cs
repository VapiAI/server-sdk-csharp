using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ToolMessageRole>))]
public enum ToolMessageRole
{
    [EnumMember(Value = "tool")]
    Tool,
}
