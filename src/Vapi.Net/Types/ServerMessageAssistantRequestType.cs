using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessageAssistantRequestType>))]
public enum ServerMessageAssistantRequestType
{
    [EnumMember(Value = "assistant-request")]
    AssistantRequest,
}
