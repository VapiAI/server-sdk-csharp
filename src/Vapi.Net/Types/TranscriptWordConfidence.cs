using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TranscriptWordConfidence : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The word as the transcriber recognised it.
    /// </summary>
    [JsonPropertyName("word")]
    public required string Word { get; set; }

    /// <summary>
    /// Offset at which the word begins, measured from the start of the
    /// transcriber stream (ElevenLabs, which transcribes each utterance as its
    /// own request, measures from the start of that utterance's audio). The unit
    /// is transcriber-specific today: seconds for Deepgram, Soniox, Gladia and
    /// ElevenLabs realtime (`scribe_v2_realtime`); milliseconds for AssemblyAI,
    /// ElevenLabs HTTP Scribe and Google. Transcribers without per-word timing
    /// emit a placeholder, typically `0`.
    /// </summary>
    [JsonPropertyName("start")]
    public required double Start { get; set; }

    /// <summary>
    /// Offset at which the word ends, with the same origin and unit as `start`.
    /// </summary>
    [JsonPropertyName("end")]
    public required double End { get; set; }

    /// <summary>
    /// The transcriber's confidence for this word, in [0, 1]. Transcribers that
    /// report no per-word score, or whose stream does not map one (Cartesia,
    /// ElevenLabs HTTP Scribe, Google, Talkscriber and custom transcribers), emit
    /// `1` for every word; that placeholder is not a measurement. ElevenLabs
    /// realtime passes through its token log-probability, which is not a [0, 1]
    /// confidence.
    /// </summary>
    [JsonPropertyName("confidence")]
    public required double Confidence { get; set; }

    /// <summary>
    /// The word with punctuation and casing applied, when the transcriber
    /// reports a punctuated form. The snake_case name deliberately mirrors the
    /// transcriber wire spelling already stored on every existing message;
    /// renaming it would break stored data.
    /// </summary>
    [JsonPropertyName("punctuated_word")]
    public string? PunctuatedWord { get; set; }

    /// <summary>
    /// The language the transcriber detected for this word, when it reports one.
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>
    /// The diarized speaker index this word was attributed to, when the
    /// transcriber reports one.
    /// </summary>
    [JsonPropertyName("speaker")]
    public double? Speaker { get; set; }

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
