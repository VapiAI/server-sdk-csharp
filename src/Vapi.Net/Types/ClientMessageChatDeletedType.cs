using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ClientMessageChatDeletedType>))]
public enum ClientMessageChatDeletedType
{
    [EnumMember(Value = "chat.deleted")]
    ChatDeleted,
}
