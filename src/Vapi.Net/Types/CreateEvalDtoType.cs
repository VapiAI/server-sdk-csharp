using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CreateEvalDtoType>))]
public enum CreateEvalDtoType
{
    [EnumMember(Value = "chat.mockConversation")]
    ChatMockConversation,
}
