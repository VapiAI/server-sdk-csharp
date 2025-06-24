using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ResponseObjectStatus>))]
public enum ResponseObjectStatus
{
    [EnumMember(Value = "completed")]
    Completed,

    [EnumMember(Value = "failed")]
    Failed,

    [EnumMember(Value = "in_progress")]
    InProgress,

    [EnumMember(Value = "incomplete")]
    Incomplete,
}
