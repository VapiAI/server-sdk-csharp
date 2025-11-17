using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<EvalUserEditableType>))]
public enum EvalUserEditableType
{
    [EnumMember(Value = "chat.mockConversation")]
    ChatMockConversation,
}
