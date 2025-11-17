using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<UpdateEvalDtoType>))]
public enum UpdateEvalDtoType
{
    [EnumMember(Value = "chat.mockConversation")]
    ChatMockConversation,
}
