using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record StepDestination
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = "step";

    /// <summary>
    /// This is an optional array of conditions that must be met for this destination to be triggered. If empty, this is the default destination that the step transfers to.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IEnumerable<object>? Conditions { get; set; }

    [JsonPropertyName("stepName")]
    public required string StepName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
