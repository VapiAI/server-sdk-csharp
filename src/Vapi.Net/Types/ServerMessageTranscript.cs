using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ServerMessageTranscript : IJsonOnDeserialized
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
    /// This is the version label (e.g. `v3`) of the assistant the call was
    /// configured with. `null` for inline assistants, squad/workflow calls,
    /// pre-resolution assistant-request messages, and orgs not on
    /// assistant versioning.
    /// </summary>
    [JsonPropertyName("assistantVersion")]
    public string? AssistantVersion { get; set; }

    /// <summary>
    /// This is the type of the message. "transcript" is sent as transcriber outputs partial or final transcript.
    /// </summary>
    [JsonPropertyName("type")]
    public required ServerMessageTranscriptType Type { get; set; }

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

    /// <summary>
    /// This is the role for which the transcript is for.
    /// </summary>
    [JsonPropertyName("role")]
    public required ServerMessageTranscriptRole Role { get; set; }

    /// <summary>
    /// This is the type of the transcript.
    /// </summary>
    [JsonPropertyName("transcriptType")]
    public required ServerMessageTranscriptTranscriptType TranscriptType { get; set; }

    /// <summary>
    /// This is the transcript content.
    /// </summary>
    [JsonPropertyName("transcript")]
    public required string Transcript { get; set; }

    /// <summary>
    /// The ID of the assistant that produced this transcript. Present on
    /// assistant-role events when an active assistant ID is available.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public string? AssistantId { get; set; }

    /// <summary>
    /// The name of the assistant that produced this transcript. Present on
    /// assistant-role events when an active assistant name is available.
    /// </summary>
    [JsonPropertyName("assistantName")]
    public string? AssistantName { get; set; }

    /// <summary>
    /// Indicates if the transcript was filtered for security reasons.
    /// </summary>
    [JsonPropertyName("isFiltered")]
    public bool? IsFiltered { get; set; }

    /// <summary>
    /// List of detected security threats if the transcript was filtered.
    /// </summary>
    [JsonPropertyName("detectedThreats")]
    public IEnumerable<string>? DetectedThreats { get; set; }

    /// <summary>
    /// The original transcript before filtering (only included if content was filtered).
    /// </summary>
    [JsonPropertyName("originalTranscript")]
    public string? OriginalTranscript { get; set; }

    /// <summary>
    /// The transcriber's confidence score for this transcript, in [0, 1]. Only
    /// ever set alongside `confidenceSource` — see there for why an unmarked
    /// score is never included. Set only on final user-role transcripts: each
    /// live message carries the score of the one fragment it was built from, and
    /// `artifact.messages` agrees with it per fragment. A stored message built
    /// from several consecutive fragments reports the minimum across them as
    /// 'derived', so it can differ from the individual live messages that fed
    /// it. Partials never carry a score, because nothing stored exists for a
    /// partial's score to agree with.
    /// </summary>
    [JsonPropertyName("confidence")]
    public double? Confidence { get; set; }

    /// <summary>
    /// Whether `confidence` came directly from the transcriber ('provider') or
    /// was computed by Vapi ('derived').
    ///
    /// 'derived' means Vapi computed the score from the transcriber's per-word
    /// scores; the exact aggregation is provider-specific (an average, a median
    /// or a minimum, depending on the transcriber).
    ///
    /// Absent means no trustworthy score was available for this transcript:
    /// either the transcriber does not report one, or the value it reported was
    /// invalid and was dropped.
    /// </summary>
    [JsonPropertyName("confidenceSource")]
    public ServerMessageTranscriptConfidenceSource? ConfidenceSource { get; set; }

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
