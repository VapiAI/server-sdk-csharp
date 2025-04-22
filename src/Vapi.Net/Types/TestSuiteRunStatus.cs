using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TestSuiteRunStatus>))]
public enum TestSuiteRunStatus
{
    [EnumMember(Value = "queued")]
    Queued,

    [EnumMember(Value = "in-progress")]
    InProgress,

    [EnumMember(Value = "completed")]
    Completed,

    [EnumMember(Value = "failed")]
    Failed,
}
