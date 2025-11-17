using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ServerMessageConversationUpdateType>))]
public enum ServerMessageConversationUpdateType
{
    [EnumMember(Value = "conversation-update")]
    ConversationUpdate,
}
