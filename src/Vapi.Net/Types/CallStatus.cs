using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CallStatus>))]
public enum CallStatus
{
    [EnumMember(Value = "scheduled")]
    Scheduled,

    [EnumMember(Value = "queued")]
    Queued,

    [EnumMember(Value = "ringing")]
    Ringing,

    [EnumMember(Value = "in-progress")]
    InProgress,

    [EnumMember(Value = "forwarding")]
    Forwarding,

    [EnumMember(Value = "ended")]
    Ended,

    [EnumMember(Value = "not-found")]
    NotFound,

    [EnumMember(Value = "deletion-failed")]
    DeletionFailed,
}
