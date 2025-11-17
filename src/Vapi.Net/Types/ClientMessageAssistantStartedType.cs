using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ClientMessageAssistantStartedType>))]
public enum ClientMessageAssistantStartedType
{
    [EnumMember(Value = "assistant.started")]
    AssistantStarted,
}
