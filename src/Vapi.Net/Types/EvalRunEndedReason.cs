using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<EvalRunEndedReason>))]
public enum EvalRunEndedReason
{
    [EnumMember(Value = "mockConversation.done")]
    MockConversationDone,

    [EnumMember(Value = "error")]
    Error,

    [EnumMember(Value = "timeout")]
    Timeout,

    [EnumMember(Value = "cancelled")]
    Cancelled,

    [EnumMember(Value = "aborted")]
    Aborted,
}
