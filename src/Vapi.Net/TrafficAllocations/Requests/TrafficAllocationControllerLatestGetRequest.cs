using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TrafficAllocationControllerLatestGetRequest
{
    /// <summary>
    /// The assistant whose latest allocation to return.
    /// </summary>
    [JsonIgnore]
    public required string AssistantId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
