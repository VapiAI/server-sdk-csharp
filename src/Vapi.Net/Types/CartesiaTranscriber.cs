using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Configuration for transcribing speech during assistant conversations with Cartesia, including model, language, and fallback settings.
/// </summary>
[Serializable]
public record CartesiaTranscriber : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The Cartesia speech-to-text model used for transcription.
    /// </summary>
    [JsonPropertyName("model")]
    public CartesiaTranscriberModel? Model { get; set; }

    /// <summary>
    /// The language code used for transcription.
    /// </summary>
    [JsonPropertyName("language")]
    public CartesiaTranscriberLanguage? Language { get; set; }

    /// <summary>
    /// This is the plan for transcriber provider fallbacks in the event that the primary transcriber provider fails.
    /// </summary>
    [JsonPropertyName("fallbackPlan")]
    public FallbackTranscriberPlan? FallbackPlan { get; set; }

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
