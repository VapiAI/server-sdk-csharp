using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TranscriptAnswerKey : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the verbatim transcript of everything the recording contains. A
    /// mixed recording of both parties needs both parties' words, in order. At
    /// most 30,000 words.
    /// </summary>
    [JsonPropertyName("transcript")]
    public required string Transcript { get; set; }

    /// <summary>
    /// These are values the transcript must carry, each scored exact, near or
    /// missed.
    /// </summary>
    [JsonPropertyName("keyValues")]
    public IEnumerable<TranscriptKeyValue>? KeyValues { get; set; }

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
