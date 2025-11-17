using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ChatEvalToolResponseMessageEvaluationRole>))]
public enum ChatEvalToolResponseMessageEvaluationRole
{
    [EnumMember(Value = "tool")]
    Tool,
}
