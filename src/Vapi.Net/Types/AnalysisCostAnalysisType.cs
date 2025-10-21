using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<AnalysisCostAnalysisType>))]
public enum AnalysisCostAnalysisType
{
    [EnumMember(Value = "summary")]
    Summary,

    [EnumMember(Value = "structuredData")]
    StructuredData,

    [EnumMember(Value = "successEvaluation")]
    SuccessEvaluation,

    [EnumMember(Value = "structuredOutput")]
    StructuredOutput,
}
