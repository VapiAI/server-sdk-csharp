using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record WorkflowCustomModel
{
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
    public WorkflowCustomModelMetadataSendMode? MetadataSendMode { get; set; }

    /// <summary>
    /// These is the URL we'll use for the OpenAI client's `baseURL`. Ex. https://openrouter.ai/api/v1
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    /// <summary>
    /// This sets the timeout for the connection to the custom provider without needing to stream any tokens back. Default is 20 seconds.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>
    /// This is the name of the model. Ex. cognitivecomputations/dolphin-mixtral-8x7b
    /// </summary>
    [JsonPropertyName("model")]
    public required string Model { get; set; }

    /// <summary>
    /// This is the temperature of the model.
    /// </summary>
    [JsonPropertyName("temperature")]
    public double? Temperature { get; set; }

    /// <summary>
    /// This is the max tokens of the model.
    /// </summary>
    [JsonPropertyName("maxTokens")]
    public double? MaxTokens { get; set; }

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
