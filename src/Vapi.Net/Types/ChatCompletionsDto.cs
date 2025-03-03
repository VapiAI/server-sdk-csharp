using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ChatCompletionsDto
{
    [JsonPropertyName("messages")]
    public IEnumerable<ChatCompletionMessage> Messages { get; set; } =
        new List<ChatCompletionMessage>();

    [JsonPropertyName("workflowId")]
    public string? WorkflowId { get; set; }

    [JsonPropertyName("workflow")]
    public CreateWorkflowDto? Workflow { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
