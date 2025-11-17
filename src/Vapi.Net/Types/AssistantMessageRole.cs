using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<AssistantMessageRole>))]
public enum AssistantMessageRole
{
    [EnumMember(Value = "assistant")]
    Assistant,
}
