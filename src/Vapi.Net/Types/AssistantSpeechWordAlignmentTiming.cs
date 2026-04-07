using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AssistantSpeechWordAlignmentTiming : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The individual words in this audio segment.
    /// </summary>
    [JsonPropertyName("words")]
    public IEnumerable<string> Words { get; set; } = new List<string>();

    /// <summary>
    /// Start time in milliseconds for each word (parallel to `words`).
    /// </summary>
    [JsonPropertyName("wordsStartTimesMs")]
    public IEnumerable<double> WordsStartTimesMs { get; set; } = new List<double>();

    /// <summary>
    /// End time in milliseconds for each word (parallel to `words`).
    /// </summary>
    [JsonPropertyName("wordsEndTimesMs")]
    public IEnumerable<double> WordsEndTimesMs { get; set; } = new List<double>();

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
