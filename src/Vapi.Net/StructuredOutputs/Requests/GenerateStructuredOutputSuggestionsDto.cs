using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record GenerateStructuredOutputSuggestionsDto
{
    /// <summary>
    /// The assistant ID to analyze and generate suggestions for
    /// </summary>
    [JsonPropertyName("assistantId")]
    public required string AssistantId { get; set; }

    /// <summary>
    /// Number of suggestions to generate
    /// </summary>
    [JsonPropertyName("count")]
    public double? Count { get; set; }

    /// <summary>
    /// Existing structured output IDs to exclude from suggestions
    /// </summary>
    [JsonPropertyName("excludeIds")]
    public IEnumerable<string>? ExcludeIds { get; set; }

    /// <summary>
    /// Iteration/seed for generating diverse suggestions (0 = first generation, 1+ = regenerations with increasing specificity)
    /// </summary>
    [JsonPropertyName("seed")]
    public double? Seed { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
