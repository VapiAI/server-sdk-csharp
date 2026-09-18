using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record VapiModel : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the starting state for the conversation.
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<OpenAiMessage>? Messages { get; set; }

    /// <summary>
    /// These are the tools that the assistant can use during the call. To use existing tools, use `toolIds`.
    ///
    /// Both `tools` and `toolIds` can be used together.
    /// </summary>
    [JsonPropertyName("tools")]
    public IEnumerable<object>? Tools { get; set; }

    /// <summary>
    /// These are the tools that the assistant can use during the call. To use transient tools, use `tools`.
    ///
    /// Both `tools` and `toolIds` can be used together.
    /// </summary>
    [JsonPropertyName("toolIds")]
    public IEnumerable<string>? ToolIds { get; set; }

    /// <summary>
    /// These are version-pinned references to tools. Each entry pins a specific
    /// version of a tool by `(toolId, version)`. When the same `toolId` appears
    /// in both `toolIds` and `toolRefs[]`, the `toolRefs` pin wins (the
    /// `toolIds` entry is dropped at write time).
    /// </summary>
    [JsonPropertyName("toolRefs")]
    public IEnumerable<ToolRef>? ToolRefs { get; set; }

    /// <summary>
    /// These are the options for the knowledge base.
    /// </summary>
    [JsonPropertyName("knowledgeBase")]
    public CreateCustomKnowledgeBaseDto? KnowledgeBase { get; set; }

    /// <summary>
    /// White-label Vapi models are selected by `version`, not a model name, so
    /// `model` is optional here (the runtime already accepts a version-only Vapi
    /// payload). Overriding the required `ModelBase.model`: the declared type stays
    /// `string` to match the base (avoids TS2416) and the `= undefined!` initializer
    /// satisfies TS2612 for the field override, while `@IsOptional` +
    /// `@ApiPropertyOptional` make validation and the generated OpenAPI schema treat
    /// it as optional (so `VapiModel.required` is `['provider']`).
    /// </summary>
    [JsonPropertyName("model")]
    public string? Model { get; set; }

    /// <summary>
    /// Vapi-managed model version (update channel). When set, this is a Vapi-managed
    /// LLM routed by the registry; when absent, this is the legacy workflow form
    /// below (`steps` / `workflow`).
    /// </summary>
    [JsonPropertyName("version")]
    public VapiModelVersion? Version { get; set; }

    /// <summary>
    /// This is the workflow that will be used for the call. To use a transient workflow, use `workflow` instead.
    /// </summary>
    [JsonPropertyName("workflowId")]
    public string? WorkflowId { get; set; }

    /// <summary>
    /// This is the workflow that will be used for the call. To use an existing workflow, use `workflowId` instead.
    /// </summary>
    [JsonPropertyName("workflow")]
    public WorkflowUserEditable? Workflow { get; set; }

    /// <summary>
    /// This is the temperature that will be used for calls. Default is 0.5.
    /// </summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>
    /// This determines whether we detect user's emotion while they speak and send it as an additional info to model.
    ///
    /// Default `false` because the model is usually are good at understanding the user's emotion from text.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("emotionRecognitionEnabled")]
    public bool? EmotionRecognitionEnabled { get; set; }

    /// <summary>
    /// This sets how many turns at the start of the conversation to use a smaller, faster model from the same provider before switching to the primary model. Example, gpt-3.5-turbo if provider is openai.
    ///
    /// Default is 0.
    ///
    /// @default 0
    /// </summary>
    [JsonPropertyName("numFastTurns")]
    public double? NumFastTurns { get; set; }

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
