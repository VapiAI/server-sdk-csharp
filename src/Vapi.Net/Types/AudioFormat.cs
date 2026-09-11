using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AudioFormat : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the sample rate of the call.
    ///
    /// @default 16000
    /// </summary>
    [JsonPropertyName("sampleRate")]
    public required double SampleRate { get; set; }

    /// <summary>
    /// This is the audio format of the call.
    ///
    /// @default 'pcm_s16le'
    /// </summary>
    [JsonPropertyName("format")]
    public object Format { get; set; } = new Dictionary<string, object?>();

    /// <summary>
    /// This is the container format of the call.
    ///
    /// @default 'raw'
    /// </summary>
    [JsonPropertyName("container")]
    public AudioFormatContainer? Container { get; set; }

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
