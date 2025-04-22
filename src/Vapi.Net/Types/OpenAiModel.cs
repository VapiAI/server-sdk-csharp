using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record OpenAiModel
{
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
    /// This is the ID of the knowledge base the model will use.
    /// </summary>
    [JsonPropertyName("knowledgeBaseId")]
    public string? KnowledgeBaseId { get; set; }

    /// <summary>
    /// This is the OpenAI model that will be used.
    /// </summary>
    [JsonPropertyName("model")]
    public required OpenAiModelModel Model { get; set; }

    /// <summary>
    /// These are the fallback models that will be used if the primary model fails. This shouldn't be specified unless you have a specific reason to do so. Vapi will automatically find the fastest fallbacks that make sense.
    /// </summary>
    [JsonPropertyName("fallbackModels")]
    public IEnumerable<OpenAiModelFallbackModelsItem>? FallbackModels { get; set; }

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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
