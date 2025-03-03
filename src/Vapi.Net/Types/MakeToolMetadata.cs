using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record MakeToolMetadata
{
    [JsonPropertyName("scenarioId")]
    public double? ScenarioId { get; set; }

    [JsonPropertyName("triggerHookId")]
    public double? TriggerHookId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
