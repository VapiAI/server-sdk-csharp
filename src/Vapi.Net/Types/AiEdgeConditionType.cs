using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<AiEdgeConditionType>))]
public enum AiEdgeConditionType
{
    [EnumMember(Value = "ai")]
    Ai,
}
