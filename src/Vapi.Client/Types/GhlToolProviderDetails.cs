using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record GhlToolProviderDetails
{
    /// <summary>
    /// This is the Template URL or the Snapshot URL corresponding to the Template.
    /// </summary>
    [JsonPropertyName("templateUrl")]
    public string? TemplateUrl { get; set; }

    [JsonPropertyName("setupInstructions")]
    public IEnumerable<ToolTemplateSetup>? SetupInstructions { get; set; }

    [JsonPropertyName("workflowId")]
    public string? WorkflowId { get; set; }

    [JsonPropertyName("workflowName")]
    public string? WorkflowName { get; set; }

    [JsonPropertyName("webhookHookId")]
    public string? WebhookHookId { get; set; }

    [JsonPropertyName("webhookHookName")]
    public string? WebhookHookName { get; set; }

    [JsonPropertyName("locationId")]
    public string? LocationId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
