using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AssistantSpeechWordProgressTiming : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Number of words spoken so far in this turn.
    /// </summary>
    [JsonPropertyName("wordsSpoken")]
    public required double WordsSpoken { get; set; }

    /// <summary>
    /// Total number of words sent to the TTS provider for this turn.
    ///
    /// **Important**: this value grows across events within a single turn because
    /// Minimax synthesizes audio incrementally as the LLM streams tokens. Treat
    /// it as "best known total so far" — it will stabilize once synthesis is
    /// complete.
    ///
    /// A value of `0` is a valid sentinel meaning "not yet known". This can occur
    /// on the very first `assistant-speech` event of a turn if audio begins
    /// playing before the TTS provider has confirmed word-count data. Clients
    /// **must** guard against divide-by-zero when computing a progress fraction:
    ///
    /// ```ts
    /// const pct = totalWords &gt; 0 ? wordsSpoken / totalWords : 0;
    /// ```
    /// </summary>
    [JsonPropertyName("totalWords")]
    public required double TotalWords { get; set; }

    /// <summary>
    /// The text of the latest spoken segment (sentence or clause). Use this
    /// for caption display — it corresponds to the chunk just confirmed by
    /// the TTS provider, unlike `text` on the parent message which carries
    /// the full turn text.
    /// </summary>
    [JsonPropertyName("segment")]
    public string? Segment { get; set; }

    /// <summary>
    /// Audio duration in milliseconds for the latest spoken segment. Pair
    /// with `segment` to animate karaoke-style word reveals — divide the
    /// segment text across this duration for approximate per-word timing.
    /// </summary>
    [JsonPropertyName("segmentDurationMs")]
    public double? SegmentDurationMs { get; set; }

    /// <summary>
    /// Per-word timestamps for the latest spoken segment. Available when the
    /// TTS provider supports word-level timing (e.g. Minimax with
    /// subtitle_type: "word"). Syllables from the provider are aggregated
    /// into whole words with start/end times relative to the segment start.
    ///
    /// Use these for precise karaoke-style highlighting instead of
    /// interpolating from segmentDurationMs.
    /// </summary>
    [JsonPropertyName("words")]
    public IEnumerable<AssistantSpeechWordTimestamp>? Words { get; set; }

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
