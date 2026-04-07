using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AssistantSpeechWordTimestamp : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The full word text (syllables aggregated into complete words).
    /// </summary>
    [JsonPropertyName("word")]
    public required string Word { get; set; }

    /// <summary>
    /// Start time in milliseconds relative to the segment start.
    /// </summary>
    [JsonPropertyName("startMs")]
    public required double StartMs { get; set; }

    /// <summary>
    /// End time in milliseconds relative to the segment start.
    /// </summary>
    [JsonPropertyName("endMs")]
    public required double EndMs { get; set; }

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
