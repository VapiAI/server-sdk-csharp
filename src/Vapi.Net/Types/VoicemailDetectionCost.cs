using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record VoicemailDetectionCost
{
    /// <summary>
    /// This is the model that was used to perform the analysis.
    /// </summary>
    [JsonPropertyName("model")]
    public object Model { get; set; } = new Dictionary<string, object?>();

    /// <summary>
    /// This is the provider that was used to detect the voicemail.
    /// </summary>
    [JsonPropertyName("provider")]
    public required VoicemailDetectionCostProvider Provider { get; set; }

    /// <summary>
    /// This is the number of prompt text tokens used in the voicemail detection.
    /// </summary>
    [JsonPropertyName("promptTextTokens")]
    public required double PromptTextTokens { get; set; }

    /// <summary>
    /// This is the number of prompt audio tokens used in the voicemail detection.
    /// </summary>
    [JsonPropertyName("promptAudioTokens")]
    public required double PromptAudioTokens { get; set; }

    /// <summary>
    /// This is the number of completion text tokens used in the voicemail detection.
    /// </summary>
    [JsonPropertyName("completionTextTokens")]
    public required double CompletionTextTokens { get; set; }

    /// <summary>
    /// This is the number of completion audio tokens used in the voicemail detection.
    /// </summary>
    [JsonPropertyName("completionAudioTokens")]
    public required double CompletionAudioTokens { get; set; }

    /// <summary>
    /// This is the cost of the component in USD.
    /// </summary>
    [JsonPropertyName("cost")]
    public required double Cost { get; set; }

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
