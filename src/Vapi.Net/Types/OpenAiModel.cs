using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record OpenAiModel : IJsonOnDeserialized
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
    /// These are the options for the knowledge base.
    /// </summary>
    [JsonPropertyName("knowledgeBase")]
    public CreateCustomKnowledgeBaseDto? KnowledgeBase { get; set; }

    /// <summary>
    /// This is the OpenAI model that will be used.
    ///
    /// When using Vapi OpenAI or your own Azure Credentials, you have the option to specify the region for the selected model. This shouldn't be specified unless you have a specific reason to do so. Vapi will automatically find the fastest region that make sense.
    /// This is helpful when you are required to comply with Data Residency rules. Learn more about Azure regions here https://azure.microsoft.com/en-us/explore/global-infrastructure/data-residency/.
    ///
    /// @default undefined
    /// </summary>
    [JsonPropertyName("model")]
    public required OpenAiModelModel Model { get; set; }

    /// <summary>
    /// These are the fallback models that will be used if the primary model fails. This shouldn't be specified unless you have a specific reason to do so. Vapi will automatically find the fastest fallbacks that make sense.
    /// </summary>
    [JsonPropertyName("fallbackModels")]
    public IEnumerable<OpenAiModelFallbackModelsItem>? FallbackModels { get; set; }

    /// <summary>
    /// Azure OpenAI doesn't support `maxLength` right now https://learn.microsoft.com/en-us/azure/ai-services/openai/how-to/structured-outputs?tabs=python-secure%2Cdotnet-entra-id&pivots=programming-language-csharp#unsupported-type-specific-keywords. Need to strip.
    ///
    /// - `strip-parameters-with-unsupported-validation` will strip parameters with unsupported validation.
    /// - `strip-unsupported-validation` will keep the parameters but strip unsupported validation.
    ///
    /// @default `strip-unsupported-validation`
    /// </summary>
    [JsonPropertyName("toolStrictCompatibilityMode")]
    public OpenAiModelToolStrictCompatibilityMode? ToolStrictCompatibilityMode { get; set; }

    /// <summary>
    /// This controls the prompt cache retention policy for models that support extended caching (GPT-4.1, GPT-5 series).
    ///
    /// - `in_memory`: Default behavior, cache retained in GPU memory only
    /// - `24h`: Extended caching, keeps cached prefixes active for up to 24 hours by offloading to GPU-local storage
    ///
    /// Only applies to models: gpt-5.4, gpt-5.4-mini, gpt-5.4-nano, gpt-5.2, gpt-5.1, gpt-5.1-codex, gpt-5.1-codex-mini, gpt-5.1-chat-latest, gpt-5, gpt-5-codex, gpt-4.1
    ///
    /// @default undefined (uses API default which is 'in_memory')
    /// </summary>
    [JsonPropertyName("promptCacheRetention")]
    public OpenAiModelPromptCacheRetention? PromptCacheRetention { get; set; }

    /// <summary>
    /// This is the prompt cache key for models that support extended caching (GPT-4.1, GPT-5 series).
    ///
    /// Providing a cache key allows you to share cached prefixes across requests.
    ///
    /// @default undefined
    /// </summary>
    [JsonPropertyName("promptCacheKey")]
    public string? PromptCacheKey { get; set; }

    /// <summary>
    /// This is the temperature that will be used for calls. Default is 0 to leverage caching for lower latency.
    /// </summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>
    /// This is the max number of tokens that the assistant will be allowed to generate in each turn of the conversation. Default is 250.
    /// </summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

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
