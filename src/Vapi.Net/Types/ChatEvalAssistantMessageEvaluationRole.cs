using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ChatEvalAssistantMessageEvaluationRole>))]
public enum ChatEvalAssistantMessageEvaluationRole
{
    [EnumMember(Value = "assistant")]
    Assistant,
}
