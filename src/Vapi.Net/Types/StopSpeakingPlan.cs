using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record StopSpeakingPlan
{
    /// <summary>
    /// This is the number of words that the customer has to say before the assistant will stop talking.
    ///
    /// Words like "stop", "actually", "no", etc. will always interrupt immediately regardless of this value.
    ///
    /// Words like "okay", "yeah", "right" will never interrupt.
    ///
    /// When set to 0, `voiceSeconds` is used in addition to the transcriptions to determine the customer has started speaking.
    ///
    /// Defaults to 0.
    ///
    /// @default 0
    /// </summary>
    [JsonPropertyName("numWords")]
    public double? NumWords { get; set; }

    /// <summary>
    /// This is the seconds customer has to speak before the assistant stops talking. This uses the VAD (Voice Activity Detection) spike to determine if the customer has started speaking.
    ///
    /// Considerations:
    /// - A lower value might be more responsive but could potentially pick up non-speech sounds.
    /// - A higher value reduces false positives but might slightly delay the detection of speech onset.
    ///
    /// This is only used if `numWords` is set to 0.
    ///
    /// Defaults to 0.2
    ///
    /// @default 0.2
    /// </summary>
    [JsonPropertyName("voiceSeconds")]
    public double? VoiceSeconds { get; set; }

    /// <summary>
    /// This is the seconds to wait before the assistant will start talking again after being interrupted.
    ///
    /// Defaults to 1.
    ///
    /// @default 1
    /// </summary>
    [JsonPropertyName("backoffSeconds")]
    public double? BackoffSeconds { get; set; }

    /// <summary>
    /// These are the phrases that will never interrupt the assistant, even if numWords threshold is met.
    /// These are typically acknowledgement or backchanneling phrases.
    /// </summary>
    [JsonPropertyName("acknowledgementPhrases")]
    public IEnumerable<string>? AcknowledgementPhrases { get; set; }

    /// <summary>
    /// These are the phrases that will always interrupt the assistant immediately, regardless of numWords.
    /// These are typically phrases indicating disagreement or desire to stop.
    /// </summary>
    [JsonPropertyName("interruptionPhrases")]
    public IEnumerable<string>? InterruptionPhrases { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
