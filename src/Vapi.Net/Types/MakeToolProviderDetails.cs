using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record MakeToolProviderDetails
{
    /// <summary>
    /// This is the Template URL or the Snapshot URL corresponding to the Template.
    /// </summary>
    [JsonPropertyName("templateUrl")]
    public string? TemplateUrl { get; set; }

    [JsonPropertyName("setupInstructions")]
    public IEnumerable<ToolTemplateSetup>? SetupInstructions { get; set; }

    [JsonPropertyName("scenarioId")]
    public double? ScenarioId { get; set; }

    [JsonPropertyName("scenarioName")]
    public string? ScenarioName { get; set; }

    [JsonPropertyName("triggerHookId")]
    public double? TriggerHookId { get; set; }

    [JsonPropertyName("triggerHookName")]
    public string? TriggerHookName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
