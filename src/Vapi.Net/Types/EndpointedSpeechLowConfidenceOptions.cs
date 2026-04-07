using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record EndpointedSpeechLowConfidenceOptions : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the minimum confidence threshold.
    /// Transcripts with confidence below this value will be discarded.
    ///
    /// @default confidenceMax - 0.2
    /// </summary>
    [JsonPropertyName("confidenceMin")]
    public double? ConfidenceMin { get; set; }

    /// <summary>
    /// This is the maximum confidence threshold.
    /// Transcripts with confidence at or above this value will be processed normally.
    ///
    /// @default transcriber's confidenceThreshold
    /// </summary>
    [JsonPropertyName("confidenceMax")]
    public double? ConfidenceMax { get; set; }

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
