using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record AssemblyAiTranscriber
{
    /// <summary>
    /// This is the language that will be set for the transcription.
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
