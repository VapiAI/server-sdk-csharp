using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ToolMessageCompleteRole>))]
public enum ToolMessageCompleteRole
{
    [EnumMember(Value = "assistant")]
    Assistant,

    [EnumMember(Value = "system")]
    System,
}
