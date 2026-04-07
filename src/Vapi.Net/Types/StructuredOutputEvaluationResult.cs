using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record StructuredOutputEvaluationResult : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the ID of the structured output that was evaluated.
    /// Will be 'inline' for inline structured output definitions.
    /// </summary>
    [JsonPropertyName("structuredOutputId")]
    public required string StructuredOutputId { get; set; }

    /// <summary>
    /// This is the name of the structured output.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// This is the value extracted from the call by the structured output.
    /// </summary>
    [JsonPropertyName("extractedValue")]
    public OneOf<double, string, bool>? ExtractedValue { get; set; }

    /// <summary>
    /// This is the expected value that was defined in the evaluation plan.
    /// </summary>
    [JsonPropertyName("expectedValue")]
    public required OneOf<double, string, bool> ExpectedValue { get; set; }

    /// <summary>
    /// This is the comparison operator used for evaluation.
    /// </summary>
    [JsonPropertyName("comparator")]
    public required StructuredOutputEvaluationResultComparator Comparator { get; set; }

    /// <summary>
    /// This indicates whether the evaluation passed (extracted value matched expected value using comparator).
    /// </summary>
    [JsonPropertyName("passed")]
    public required bool Passed { get; set; }

    /// <summary>
    /// This indicates whether this evaluation was required for the simulation to pass.
    /// </summary>
    [JsonPropertyName("required")]
    public required bool Required { get; set; }

    /// <summary>
    /// This contains any error that occurred during extraction.
    /// </summary>
    [JsonPropertyName("error")]
    public string? Error { get; set; }

    /// <summary>
    /// This indicates whether this evaluation was skipped (e.g., multimodal in chat mode).
    /// </summary>
    [JsonPropertyName("isSkipped")]
    public bool? IsSkipped { get; set; }

    /// <summary>
    /// This contains the reason for skipping the evaluation.
    /// </summary>
    [JsonPropertyName("skipReason")]
    public string? SkipReason { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
