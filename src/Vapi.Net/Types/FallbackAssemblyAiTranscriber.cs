using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record FallbackAssemblyAiTranscriber
{
    /// <summary>
    /// This is the language that will be set for the transcription.
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>
    /// Transcripts below this confidence threshold will be discarded.
    ///
    /// @default 0.4
    /// </summary>
    [JsonPropertyName("confidenceThreshold")]
    public double? ConfidenceThreshold { get; set; }

    /// <summary>
    /// Uses Assembly AI's new Universal Streaming API. See: https://www.assemblyai.com/docs/speech-to-text/universal-streaming
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("enableUniversalStreamingApi")]
    public bool? EnableUniversalStreamingApi { get; set; }

    /// <summary>
    /// This enables formatting of transcripts. Only used when `enableUniversalStreamingApi` is true.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("formatTurns")]
    public bool? FormatTurns { get; set; }

    /// <summary>
    /// The confidence threshold to use when determining if the end of a turn has been reached. Only used when `enableUniversalStreamingApi` is true.
    ///
    /// @default 0.7
    /// </summary>
    [JsonPropertyName("endOfTurnConfidenceThreshold")]
    public double? EndOfTurnConfidenceThreshold { get; set; }

    /// <summary>
    /// The minimum amount of silence in milliseconds required to detect end of turn when confident. Only used when `enableUniversalStreamingApi` is true.
    ///
    /// @default 160
    /// </summary>
    [JsonPropertyName("minEndOfTurnSilenceWhenConfident")]
    public double? MinEndOfTurnSilenceWhenConfident { get; set; }

    /// <summary>
    /// The maximum wait time for word finalization. Only used when `enableUniversalStreamingApi` is true.
    ///
    /// @default 160
    /// </summary>
    [JsonPropertyName("wordFinalizationMaxWaitTime")]
    public double? WordFinalizationMaxWaitTime { get; set; }

    /// <summary>
    /// The maximum amount of silence in milliseconds allowed in a turn before end of turn is triggered. Only used when `enableUniversalStreamingApi` is true.
    ///
    /// @default 400
    /// </summary>
    [JsonPropertyName("maxTurnSilence")]
    public double? MaxTurnSilence { get; set; }

    /// <summary>
    /// The WebSocket URL that the transcriber connects to.
    /// </summary>
    [JsonPropertyName("realtimeUrl")]
    public string? RealtimeUrl { get; set; }

    /// <summary>
    /// Add up to 2500 characters of custom vocabulary.
    /// </summary>
    [JsonPropertyName("wordBoost")]
    public IEnumerable<string>? WordBoost { get; set; }

    /// <summary>
    /// The duration of the end utterance silence threshold in milliseconds.
    /// </summary>
    [JsonPropertyName("endUtteranceSilenceThreshold")]
    public double? EndUtteranceSilenceThreshold { get; set; }

    /// <summary>
    /// Disable partial transcripts.
    /// Set to `true` to not receive partial transcripts. Defaults to `false`.
    /// </summary>
    [JsonPropertyName("disablePartialTranscripts")]
    public bool? DisablePartialTranscripts { get; set; }

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
