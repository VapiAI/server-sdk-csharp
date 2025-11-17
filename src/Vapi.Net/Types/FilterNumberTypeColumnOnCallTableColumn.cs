using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FilterNumberTypeColumnOnCallTableColumn>))]
public enum FilterNumberTypeColumnOnCallTableColumn
{
    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "cost")]
    Cost,

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
}
