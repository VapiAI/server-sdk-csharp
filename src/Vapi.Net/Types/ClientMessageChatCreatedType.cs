using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ClientMessageChatCreatedType>))]
public enum ClientMessageChatCreatedType
{
    [EnumMember(Value = "chat.created")]
    ChatCreated,
}
