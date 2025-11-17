using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessageChatDeletedType>))]
public enum ServerMessageChatDeletedType
{
    [EnumMember(Value = "chat.deleted")]
    ChatDeleted,
}
