using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TranscriptKeyValueResult : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the key value's position in the answer key.
    /// </summary>
    [JsonPropertyName("index")]
    public required double Index { get; set; }

    /// <summary>
    /// This is the key value as the answer key wrote it. Absent for organizations
    /// with HIPAA, PCI or zero data retention enabled.
    /// </summary>
    [JsonPropertyName("value")]
    public string? Value { get; set; }

    /// <summary>
    /// This is how the value came through.
    /// - exact: letter for letter, or as an accepted variant
    /// - near: a close spelling, at most about one wrong letter in five
    /// - missed: not found
    /// </summary>
    [JsonPropertyName("verdict")]
    public required TranscriptKeyValueResultVerdict Verdict { get; set; }

    /// <summary>
    /// This is whether this key value had to come through exactly for the
    /// simulation to pass. Kept for every organization, since it carries no answer-key text.
    /// </summary>
    [JsonPropertyName("required")]
    public required bool Required { get; set; }

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
