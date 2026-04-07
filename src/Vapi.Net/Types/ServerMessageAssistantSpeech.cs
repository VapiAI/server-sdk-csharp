using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ServerMessageAssistantSpeech : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the phone number that the message is associated with.
    /// </summary>
    [JsonPropertyName("phoneNumber")]
    public object? PhoneNumber { get; set; }

    /// <summary>
    /// This is the type of the message. "assistant-speech" is sent as assistant audio is being played.
    /// </summary>
    [JsonPropertyName("type")]
    public required ServerMessageAssistantSpeechType Type { get; set; }

    /// <summary>
    /// The full assistant text for the current turn. This is the complete text,
    /// not an incremental delta — consumers should use `timing` metadata (e.g.
    /// `wordsSpoken`) to determine which portion has been spoken so far.
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; set; }

    /// <summary>
    /// This is the turn number of the assistant speech event (0-indexed).
    /// </summary>
    [JsonPropertyName("turn")]
    public double? Turn { get; set; }

    /// <summary>
    /// Indicates how the text was sourced.
    /// </summary>
    [JsonPropertyName("source")]
    public ServerMessageAssistantSpeechSource? Source { get; set; }

    /// <summary>
    /// Optional timing metadata. Shape depends on `timing.type`:
    ///
    /// - `word-alignment` (ElevenLabs): per-character timing at playback
    ///   cadence. words[] includes space entries. Best consumed by tracking
    ///   a running character count: join timing.words, add to a char cursor,
    ///   and highlight text up to that position. No interpolation needed.
    ///
    /// - `word-progress` (Minimax with voice.subtitleType: 'word'): cursor-
    ///   based word count per TTS segment. Use wordsSpoken as the anchor,
    ///   interpolate forward using segmentDurationMs or timing.words until
    ///   the next event arrives.
    ///
    /// When absent, the event is a text-only fallback for providers without
    /// word-level timing (e.g. Cartesia, Deepgram, Azure). Text emits once
    /// per TTS chunk when audio is playing. Optionally interpolate a word
    /// cursor at ~3.5 words/sec between events for approximate tracking.
    /// </summary>
    [JsonPropertyName("timing")]
    public object? Timing { get; set; }

    /// <summary>
    /// This is the timestamp of the message.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public double? Timestamp { get; set; }

    /// <summary>
    /// This is a live version of the `call.artifact`.
    ///
    /// This matches what is stored on `call.artifact` after the call.
    /// </summary>
    [JsonPropertyName("artifact")]
    public Artifact? Artifact { get; set; }

    /// <summary>
    /// This is the assistant that the message is associated with.
    /// </summary>
    [JsonPropertyName("assistant")]
    public CreateAssistantDto? Assistant { get; set; }

    /// <summary>
    /// This is the customer that the message is associated with.
    /// </summary>
    [JsonPropertyName("customer")]
    public CreateCustomerDto? Customer { get; set; }

    /// <summary>
    /// This is the call that the message is associated with.
    /// </summary>
    [JsonPropertyName("call")]
    public Call? Call { get; set; }

    /// <summary>
    /// This is the chat object.
    /// </summary>
    [JsonPropertyName("chat")]
    public Chat? Chat { get; set; }

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
