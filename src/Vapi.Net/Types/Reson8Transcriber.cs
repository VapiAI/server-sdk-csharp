using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record Reson8Transcriber : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The Reson8 speech-to-text endpoint to use. `turns` is Reson8's turn-detection endpoint.
    /// </summary>
    [JsonPropertyName("model")]
    public Reson8TranscriberModel? Model { get; set; }

    /// <summary>
    /// Language for transcription (e.g. `nl`), or a comma-separated candidate list such as `nl,en` which constrains auto-detection. When omitted, Reson8 auto-detects the language per utterance. Supported: de, en, es, fr, fy, it, nl, pl, pt, sv.
    /// </summary>
    [JsonPropertyName("language")]
    public string? Language { get; set; }

    /// <summary>
    /// Domain-specific terms to boost recognition (brand names, product codes, jargon). Sent to Reson8 as the `phrases` parameter. Max 250 phrases.
    /// </summary>
    [JsonPropertyName("keyterms")]
    public IEnumerable<string>? Keyterms { get; set; }

    /// <summary>
    /// A stored Reson8 phrase collection (custom model) id, managed via the Reson8 API or console.
    /// </summary>
    [JsonPropertyName("customModelId")]
    public string? CustomModelId { get; set; }

    /// <summary>
    /// Threshold (0-1) at which Reson8 emits an eager turn-end candidate. Provider default 0.5.
    /// </summary>
    [JsonPropertyName("eagerTurnProbability")]
    public double? EagerTurnProbability { get; set; }

    /// <summary>
    /// Threshold (0-1) at which Reson8 confirms the end of a turn. Provider default 0.92.
    /// </summary>
    [JsonPropertyName("finalTurnProbability")]
    public double? FinalTurnProbability { get; set; }

    /// <summary>
    /// How Reson8 renders filler words in transcripts. Provider default `natural`.
    /// </summary>
    [JsonPropertyName("fillerMode")]
    public Reson8TranscriberFillerMode? FillerMode { get; set; }

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
