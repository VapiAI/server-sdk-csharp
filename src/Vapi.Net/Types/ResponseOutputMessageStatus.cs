using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ResponseOutputMessageStatus>))]
public enum ResponseOutputMessageStatus
{
    [EnumMember(Value = "in_progress")]
    InProgress,

    [EnumMember(Value = "completed")]
    Completed,

    [EnumMember(Value = "incomplete")]
    Incomplete,
}
