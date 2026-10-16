using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record UserMessageMetadata : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Per-word confidence scores from the transcriber. After consecutive
    /// transcript fragments are merged into one message the list covers the whole
    /// merged message, or is absent when any fragment lacked word scores.
    /// </summary>
    [JsonPropertyName("wordLevelConfidence")]
    public IEnumerable<TranscriptWordConfidence>? WordLevelConfidence { get; set; }

    /// <summary>
    /// Marks a message injected out-of-band rather than produced by the
    /// transcriber (e.g. an inbound SMS relayed into the conversation).
    /// </summary>
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    /// <summary>
    /// The channel or address the out-of-band message arrived from (e.g. the
    /// sender's phone number for an SMS).
    /// </summary>
    [JsonPropertyName("source")]
    public string? Source { get; set; }

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
