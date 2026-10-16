using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// A user-authored entry in the call message history, including content, timing, security-filter results, and optional speaker metadata.
/// </summary>
[Serializable]
public record UserMessage : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The role of the user in the conversation.
    /// </summary>
    [JsonPropertyName("role")]
    public required string Role { get; set; }

    /// <summary>
    /// The message content from the user.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// The timestamp when the message was sent.
    /// </summary>
    [JsonPropertyName("time")]
    public required double Time { get; set; }

    /// <summary>
    /// The timestamp when the message ended.
    /// </summary>
    [JsonPropertyName("endTime")]
    public required double EndTime { get; set; }

    /// <summary>
    /// The number of seconds from the start of the conversation.
    /// </summary>
    [JsonPropertyName("secondsFromStart")]
    public required double SecondsFromStart { get; set; }

    /// <summary>
    /// The duration of the message in seconds.
    /// </summary>
    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    /// <summary>
    /// Indicates if the message was filtered for security reasons.
    /// </summary>
    [JsonPropertyName("isFiltered")]
    public bool? IsFiltered { get; set; }

    /// <summary>
    /// List of detected security threats if the message was filtered.
    /// </summary>
    [JsonPropertyName("detectedThreats")]
    public IEnumerable<string>? DetectedThreats { get; set; }

    /// <summary>
    /// The original message before filtering (only included if content was filtered).
    /// </summary>
    [JsonPropertyName("originalMessage")]
    public string? OriginalMessage { get; set; }

    /// <summary>
    /// The transcriber's confidence score for this message, in [0, 1]. Only
    /// ever set alongside `confidenceSource` — see there for why an unmarked
    /// or out-of-range score is never stored.
    /// </summary>
    [JsonPropertyName("confidence")]
    public double? Confidence { get; set; }

    /// <summary>
    /// Whether `confidence` came directly from the transcriber ('provider') or
    /// was computed by Vapi ('derived').
    ///
    /// 'derived' means Vapi computed the score from the transcriber's per-word
    /// scores; the exact aggregation is provider-specific (an average, a median
    /// or a minimum, depending on the transcriber). It is also 'derived' when
    /// consecutive transcript fragments were merged into one message, where the
    /// score is the minimum across the fragments.
    ///
    /// Absent means no trustworthy score was available for this message: either
    /// the transcriber does not report one, or the value it reported was invalid
    /// and was dropped. A merged message is unmarked whenever any fragment it
    /// contains was unmarked.
    /// </summary>
    [JsonPropertyName("confidenceSource")]
    public UserMessageConfidenceSource? ConfidenceSource { get; set; }

    /// <summary>
    /// The metadata associated with the message. Currently used to store the transcriber's word level confidence.
    /// </summary>
    [JsonPropertyName("metadata")]
    public UserMessageMetadata? Metadata { get; set; }

    /// <summary>
    /// Stable speaker label for diarized user speakers (e.g., "Speaker 1").
    /// </summary>
    [JsonPropertyName("speakerLabel")]
    public string? SpeakerLabel { get; set; }

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
