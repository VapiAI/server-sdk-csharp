using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Fallback configuration for transcribing speech with Cartesia, including model and language.
/// </summary>
[Serializable]
public record FallbackCartesiaTranscriber : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The Cartesia speech-to-text model used for transcription.
    /// </summary>
    [JsonPropertyName("model")]
    public FallbackCartesiaTranscriberModel? Model { get; set; }

    /// <summary>
    /// The language code used for transcription.
    /// </summary>
    [JsonPropertyName("language")]
    public FallbackCartesiaTranscriberLanguage? Language { get; set; }

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
