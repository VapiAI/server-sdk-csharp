using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record LangfuseObservabilityPlan : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("provider")]
    public required LangfuseObservabilityPlanProvider Provider { get; set; }

    /// <summary>
    /// The name of a Langfuse prompt to link generations to. This enables tracking which prompt version was used for each generation. https://langfuse.com/docs/prompt-management/features/link-to-traces
    /// </summary>
    [JsonPropertyName("promptName")]
    public string? PromptName { get; set; }

    /// <summary>
    /// The version number of the Langfuse prompt to link generations to. Used together with promptName to identify the exact prompt version. https://langfuse.com/docs/prompt-management/features/link-to-traces
    /// </summary>
    [JsonPropertyName("promptVersion")]
    public double? PromptVersion { get; set; }

    /// <summary>
    /// Custom name for the Langfuse trace. Supports Liquid templates.
    ///
    /// Available variables:
    /// - {{ call.id }} - Call UUID
    /// - {{ call.type }} - 'inboundPhoneCall', 'outboundPhoneCall', 'webCall'
    /// - {{ assistant.name }} - Assistant name
    /// - {{ assistant.id }} - Assistant ID
    ///
    /// Example: "{{ assistant.name }} - {{ call.type }}"
    ///
    /// Defaults to call ID if not provided.
    /// </summary>
    [JsonPropertyName("traceName")]
    public string? TraceName { get; set; }

    /// <summary>
    /// This is an array of tags to be added to the Langfuse trace. Tags allow you to categorize and filter traces. https://langfuse.com/docs/tracing-features/tags
    /// </summary>
    [JsonPropertyName("tags")]
    public IEnumerable<string> Tags { get; set; } = new List<string>();

    /// <summary>
    /// This is a JSON object that will be added to the Langfuse trace. Traces can be enriched with metadata to better understand your users, application, and experiments. https://langfuse.com/docs/tracing-features/metadata
    /// By default it includes the call metadata, assistant metadata, and assistant overrides.
    /// </summary>
    [JsonPropertyName("metadata")]
    public object? Metadata { get; set; }

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
