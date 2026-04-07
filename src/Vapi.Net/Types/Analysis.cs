using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record Analysis : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the summary of the call. Customize by setting `assistant.analysisPlan.summaryPrompt`.
    /// </summary>
    [JsonPropertyName("summary")]
    public string? Summary { get; set; }

    /// <summary>
    /// This is the structured data extracted from the call. Customize by setting `assistant.analysisPlan.structuredDataPrompt` and/or `assistant.analysisPlan.structuredDataSchema`.
    /// </summary>
    [JsonPropertyName("structuredData")]
    public object? StructuredData { get; set; }

    /// <summary>
    /// This is the structured data catalog of the call. Customize by setting `assistant.analysisPlan.structuredDataMultiPlan`.
    /// </summary>
    [JsonPropertyName("structuredDataMulti")]
    public IEnumerable<object>? StructuredDataMulti { get; set; }

    /// <summary>
    /// This is the evaluation of the call. Customize by setting `assistant.analysisPlan.successEvaluationPrompt` and/or `assistant.analysisPlan.successEvaluationRubric`.
    /// </summary>
    [JsonPropertyName("successEvaluation")]
    public string? SuccessEvaluation { get; set; }

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
