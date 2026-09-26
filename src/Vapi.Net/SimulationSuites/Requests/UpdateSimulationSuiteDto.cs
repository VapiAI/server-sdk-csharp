using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record UpdateSimulationSuiteDto
{
    /// <summary>
    /// This is the name of the simulation suite.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the Slack webhook URL for notifications.
    /// </summary>
    [JsonPropertyName("slackWebhookUrl")]
    public string? SlackWebhookUrl { get; set; }

    /// <summary>
    /// This is the list of simulation IDs to include in the suite (replaces existing).
    /// </summary>
    [JsonPropertyName("simulationIds")]
    public IEnumerable<string>? SimulationIds { get; set; }

    /// <summary>
    /// Optional assistant or squad assignments (replaces existing).
    /// </summary>
    [JsonPropertyName("targetAssignments")]
    public IEnumerable<SimulationSuiteTargetAssignment>? TargetAssignments { get; set; }

    /// <summary>
    /// Optional folder path for organizing simulation suites.
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
