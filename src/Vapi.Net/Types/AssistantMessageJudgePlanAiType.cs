using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<AssistantMessageJudgePlanAiType>))]
public enum AssistantMessageJudgePlanAiType
{
    [EnumMember(Value = "ai")]
    Ai,
}
