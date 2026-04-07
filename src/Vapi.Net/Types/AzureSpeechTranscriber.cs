using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AzureSpeechTranscriber : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the language that will be set for the transcription. The list of languages Azure supports can be found here: https://learn.microsoft.com/en-us/azure/ai-services/speech-service/language-support?tabs=stt
    /// </summary>
    [JsonPropertyName("language")]
    public AzureSpeechTranscriberLanguage? Language { get; set; }

    /// <summary>
    /// Controls how phrase boundaries are detected, enabling either simple time/silence heuristics or more advanced semantic segmentation.
    /// </summary>
    [JsonPropertyName("segmentationStrategy")]
    public AzureSpeechTranscriberSegmentationStrategy? SegmentationStrategy { get; set; }

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
    /// This is the plan for transcriber provider fallbacks in the event that the primary transcriber provider fails.
    /// </summary>
    [JsonPropertyName("fallbackPlan")]
    public FallbackTranscriberPlan? FallbackPlan { get; set; }

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
