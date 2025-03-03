using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TestSuiteRunScorerAiResult>))]
public enum TestSuiteRunScorerAiResult
{
    [EnumMember(Value = "pass")]
    Pass,

    [EnumMember(Value = "fail")]
    Fail,
}
