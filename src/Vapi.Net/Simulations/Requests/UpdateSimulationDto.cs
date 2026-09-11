using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record UpdateSimulationDto
{
    /// <summary>
    /// This is an optional friendly name for the simulation.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the ID of the scenario to use for this simulation.
    /// </summary>
    [JsonPropertyName("scenarioId")]
    public string? ScenarioId { get; set; }

    /// <summary>
    /// This is the ID of the personality to use for this simulation.
    /// </summary>
    [JsonPropertyName("personalityId")]
    public string? PersonalityId { get; set; }

    /// <summary>
    /// Optional folder path for organizing simulations.
    /// Supports up to 3 levels (e.g., "dept/feature/variant").
    /// Set to null to remove from folder.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
