using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record FallbackSpeechmaticsTranscriber
{
    /// <summary>
    /// This is the model that will be used for the transcription.
    /// </summary>
    [JsonPropertyName("model")]
    public FallbackSpeechmaticsTranscriberModel? Model { get; set; }

    [JsonPropertyName("language")]
    public FallbackSpeechmaticsTranscriberLanguage? Language { get; set; }

    /// <summary>
    /// This is the operating point for the transcription. Choose between `standard` for faster turnaround with strong accuracy or `enhanced` for highest accuracy when precision is critical.
    ///
    /// @default 'enhanced'
    /// </summary>
    [JsonPropertyName("operatingPoint")]
    public FallbackSpeechmaticsTranscriberOperatingPoint? OperatingPoint { get; set; }

    /// <summary>
    /// This is the region for the Speechmatics API. Choose between EU (Europe) and US (United States) regions for lower latency and data sovereignty compliance.
    ///
    /// @default 'eu'
    /// </summary>
    [JsonPropertyName("region")]
    public FallbackSpeechmaticsTranscriberRegion? Region { get; set; }

    /// <summary>
    /// This enables speaker diarization, which identifies and separates speakers in the transcription. Essential for multi-speaker conversations and conference calls.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("enableDiarization")]
    public bool? EnableDiarization { get; set; }

    /// <summary>
    /// This sets the maximum number of speakers to detect when diarization is enabled. Only used when enableDiarization is true.
    ///
    /// @default 2
    /// </summary>
    [JsonPropertyName("maxSpeakers")]
    public double? MaxSpeakers { get; set; }

    /// <summary>
    /// Provides friendly speaker labels that map to diarization indices (Speaker 1 -&gt; labels[0]).
    /// </summary>
    [JsonPropertyName("speakerLabels")]
    public IEnumerable<string>? SpeakerLabels { get; set; }

    /// <summary>
    /// This enables partial transcripts during speech recognition. When false, only final transcripts are returned.
    ///
    /// @default true
    /// </summary>
    [JsonPropertyName("enablePartials")]
    public bool? EnablePartials { get; set; }

    /// <summary>
    /// This sets the maximum delay in milliseconds for partial transcripts. Balances latency and accuracy.
    ///
    /// @default 3000
    /// </summary>
    [JsonPropertyName("maxDelay")]
    public double? MaxDelay { get; set; }

    [JsonPropertyName("customVocabulary")]
    public IEnumerable<SpeechmaticsCustomVocabularyItem> CustomVocabulary { get; set; } =
        new List<SpeechmaticsCustomVocabularyItem>();

    /// <summary>
    /// This controls how numbers are formatted in the transcription output.
    ///
    /// @default 'written'
    /// </summary>
    [JsonPropertyName("numeralStyle")]
    public FallbackSpeechmaticsTranscriberNumeralStyle? NumeralStyle { get; set; }

    /// <summary>
    /// This enables detection of non-speech audio events like music, applause, and laughter.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("enableEntities")]
    public bool? EnableEntities { get; set; }

    /// <summary>
    /// This enables automatic punctuation in the transcription output.
    ///
    /// @default true
    /// </summary>
    [JsonPropertyName("enablePunctuation")]
    public bool? EnablePunctuation { get; set; }

    /// <summary>
    /// This enables automatic capitalization in the transcription output.
    ///
    /// @default true
    /// </summary>
    [JsonPropertyName("enableCapitalization")]
    public bool? EnableCapitalization { get; set; }

    /// <summary>
    /// This is the sensitivity level for end-of-turn detection, which determines when a speaker has finished talking. Higher values are more sensitive.
    ///
    /// @default 0.5
    /// </summary>
    [JsonPropertyName("endOfTurnSensitivity")]
    public double? EndOfTurnSensitivity { get; set; }

    /// <summary>
    /// This enables removal of disfluencies (um, uh) from the transcript to create cleaner, more professional output.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("removeDisfluencies")]
    public bool? RemoveDisfluencies { get; set; }

    /// <summary>
    /// This is the minimum duration in seconds for speech segments. Shorter segments will be filtered out. Helps remove noise and improve accuracy.
    ///
    /// @default 0.0
    /// </summary>
    [JsonPropertyName("minimumSpeechDuration")]
    public double? MinimumSpeechDuration { get; set; }

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
