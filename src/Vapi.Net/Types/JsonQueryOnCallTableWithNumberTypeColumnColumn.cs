using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<JsonQueryOnCallTableWithNumberTypeColumnColumn>))]
public enum JsonQueryOnCallTableWithNumberTypeColumnColumn
{
    [EnumMember(Value = "cost")]
    Cost,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "averageModelLatency")]
    AverageModelLatency,

    [EnumMember(Value = "averageVoiceLatency")]
    AverageVoiceLatency,

    [EnumMember(Value = "averageTranscriberLatency")]
    AverageTranscriberLatency,

    [EnumMember(Value = "averageTurnLatency")]
    AverageTurnLatency,

    [EnumMember(Value = "averageEndpointingLatency")]
    AverageEndpointingLatency,

    [EnumMember(Value = "artifact.structuredOutputs[OutputID]")]
    ArtifactStructuredOutputsOutputId,
}
