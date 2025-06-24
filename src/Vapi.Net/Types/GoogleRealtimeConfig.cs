using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record GoogleRealtimeConfig
{
    /// <summary>
    /// This is the nucleus sampling parameter that controls the cumulative probability of tokens considered during text generation.
    /// Only applicable with the Gemini Flash 2.0 Multimodal Live API.
    /// </summary>
    [JsonPropertyName("topP")]
    public double? TopP { get; set; }

    /// <summary>
    /// This is the top-k sampling parameter that limits the number of highest probability tokens considered during text generation.
    /// Only applicable with the Gemini Flash 2.0 Multimodal Live API.
    /// </summary>
    [JsonPropertyName("topK")]
    public double? TopK { get; set; }

    /// <summary>
    /// This is the presence penalty parameter that influences the model's likelihood to repeat information by penalizing tokens based on their presence in the text.
    /// Only applicable with the Gemini Flash 2.0 Multimodal Live API.
    /// </summary>
    [JsonPropertyName("presencePenalty")]
    public double? PresencePenalty { get; set; }

    /// <summary>
    /// This is the frequency penalty parameter that influences the model's likelihood to repeat tokens by penalizing them based on their frequency in the text.
    /// Only applicable with the Gemini Flash 2.0 Multimodal Live API.
    /// </summary>
    [JsonPropertyName("frequencyPenalty")]
    public double? FrequencyPenalty { get; set; }

    /// <summary>
    /// This is the speech configuration object that defines the voice settings to be used for the model's speech output.
    /// Only applicable with the Gemini Flash 2.0 Multimodal Live API.
    /// </summary>
    [JsonPropertyName("speechConfig")]
    public GeminiMultimodalLiveSpeechConfig? SpeechConfig { get; set; }

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
