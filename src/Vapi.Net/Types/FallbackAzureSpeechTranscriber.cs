using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record FallbackAzureSpeechTranscriber
{
    /// <summary>
    /// This is the language that will be set for the transcription. The list of languages Azure supports can be found here: https://learn.microsoft.com/en-us/azure/ai-services/speech-service/language-support?tabs=stt
    /// </summary>
    [JsonPropertyName("language")]
    public FallbackAzureSpeechTranscriberLanguage? Language { get; set; }

    /// <summary>
    /// Controls how phrase boundaries are detected, enabling either simple time/silence heuristics or more advanced semantic segmentation.
    /// </summary>
    [JsonPropertyName("segmentationStrategy")]
    public FallbackAzureSpeechTranscriberSegmentationStrategy? SegmentationStrategy { get; set; }

    /// <summary>
    /// Duration of detected silence after which the service finalizes a phrase. Configure to adjust sensitivity to pauses in speech.
    /// </summary>
    [JsonPropertyName("segmentationSilenceTimeoutMs")]
    public double? SegmentationSilenceTimeoutMs { get; set; }

    /// <summary>
    /// Maximum duration a segment can reach before being cut off when using time-based segmentation.
    /// </summary>
    [JsonPropertyName("segmentationMaximumTimeMs")]
    public double? SegmentationMaximumTimeMs { get; set; }

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
