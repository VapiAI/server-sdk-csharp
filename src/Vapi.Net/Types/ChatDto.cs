using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ChatDto
{
    [JsonPropertyName("messages")]
    public IEnumerable<OpenAiMessage> Messages { get; set; } = new List<OpenAiMessage>();

    [JsonPropertyName("assistantId")]
    public string? AssistantId { get; set; }

    [JsonPropertyName("assistant")]
    public CreateAssistantDto? Assistant { get; set; }

    [JsonPropertyName("assistantOverrides")]
    public AssistantOverrides? AssistantOverrides { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
