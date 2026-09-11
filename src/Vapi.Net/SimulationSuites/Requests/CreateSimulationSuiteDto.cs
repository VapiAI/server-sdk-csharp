using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateSimulationSuiteDto
{
    /// <summary>
    /// The display name of the suite.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// A Slack incoming-webhook URL notified when the suite runs.
    /// </summary>
    [JsonPropertyName("slackWebhookUrl")]
    public string? SlackWebhookUrl { get; set; }

    /// <summary>
    /// The IDs of the simulations included in the suite.
    /// </summary>
    [JsonPropertyName("simulationIds")]
    public IEnumerable<string> SimulationIds { get; set; } = new List<string>();

    /// <summary>
    /// The assistants or squads the suite's simulations run against.
    /// </summary>
    [JsonPropertyName("targetAssignments")]
    public IEnumerable<SimulationSuiteTargetAssignment>? TargetAssignments { get; set; }

    /// <summary>
    /// Optional folder path for organizing simulation suites.
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
