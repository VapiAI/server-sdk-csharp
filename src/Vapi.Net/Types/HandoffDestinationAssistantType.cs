using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<HandoffDestinationAssistantType>))]
public enum HandoffDestinationAssistantType
{
    [EnumMember(Value = "assistant")]
    Assistant,
}
