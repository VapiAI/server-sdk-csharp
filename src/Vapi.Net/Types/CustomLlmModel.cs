using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record CustomLlmModel
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
    public IEnumerable<
        OneOf<
            CreateDtmfToolDto,
            CreateEndCallToolDto,
            CreateVoicemailToolDto,
            CreateFunctionToolDto,
            CreateGhlToolDto,
            CreateMakeToolDto,
            CreateTransferCallToolDto
        >
    >? Tools { get; set; }

    /// <summary>
    /// These are the tools that the assistant can use during the call. To use transient tools, use `tools`.
    ///
    /// Both `tools` and `toolIds` can be used together.
    /// </summary>
    [JsonPropertyName("toolIds")]
    public IEnumerable<string>? ToolIds { get; set; }

    /// <summary>
    /// This is the provider that will be used for the model. Any service, including your own server, that is compatible with the OpenAI API can be used.
    /// </summary>
    [JsonPropertyName("provider")]
    public required string Provider { get; set; }

    /// <summary>
    /// This determines whether metadata is sent in requests to the custom provider.
    ///
    /// - `off` will not send any metadata. payload will look like `{ messages }`
    /// - `variable` will send `assistant.metadata` as a variable on the payload. payload will look like `{ messages, metadata }`
    /// - `destructured` will send `assistant.metadata` fields directly on the payload. payload will look like `{ messages, ...metadata }`
    ///
    /// Further, `variable` and `destructured` will send `call`, `phoneNumber`, and `customer` objects in the payload.
    ///
    /// Default is `variable`.
    /// </summary>
    [JsonPropertyName("metadataSendMode")]
    public CustomLlmModelMetadataSendMode? MetadataSendMode { get; set; }

    /// <summary>
    /// These is the URL we'll use for the OpenAI client's `baseURL`. Ex. https://openrouter.ai/api/v1
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    /// <summary>
    /// This is the name of the model. Ex. cognitivecomputations/dolphin-mixtral-8x7b
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; set; }

    /// <summary>
    /// This is the temperature that will be used for calls. Default is 0 to leverage caching for lower latency.
    /// </summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>
    /// These are the options for the knowledge base.
    /// </summary>
    [JsonPropertyName("knowledgeBase")]
    public KnowledgeBase? KnowledgeBase { get; set; }

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
