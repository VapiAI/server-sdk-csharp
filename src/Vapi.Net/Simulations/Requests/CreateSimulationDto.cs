using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateSimulationDto
{
    /// <summary>
    /// Optional display name for the simulation.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The ID of the scenario to run.
    /// </summary>
    [JsonPropertyName("scenarioId")]
    public required string ScenarioId { get; set; }

    /// <summary>
    /// The ID of the personality the AI tester uses.
    /// </summary>
    [JsonPropertyName("personalityId")]
    public required string PersonalityId { get; set; }

    /// <summary>
    /// Optional folder path for organizing simulations.
    /// Supports up to 3 levels (e.g., "dept/feature/variant").
    /// Maps to GitOps resource folder structure.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
