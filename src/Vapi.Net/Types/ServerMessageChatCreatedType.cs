using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessageChatCreatedType>))]
public enum ServerMessageChatCreatedType
{
    [EnumMember(Value = "chat.created")]
    ChatCreated,
}
