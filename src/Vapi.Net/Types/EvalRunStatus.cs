using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<EvalRunStatus>))]
public enum EvalRunStatus
{
    [EnumMember(Value = "running")]
    Running,

    [EnumMember(Value = "ended")]
    Ended,

    [EnumMember(Value = "queued")]
    Queued,
}
