using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record FallbackXaiTranscriber : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The xAI speech-to-text model to use. xAI currently exposes a single STT model — placeholder for future model selection.
    /// </summary>
    [JsonPropertyName("model")]
    public FallbackXaiTranscriberModel? Model { get; set; }

    /// <summary>
    /// Single language for transcription as an ISO 639-1 code (e.g., `en`, `es`). Defaults to `en` if not set. xAI auto-detects when omitted via the API but Vapi defaults to English for deterministic behavior.
    /// </summary>
    [JsonPropertyName("language")]
    public FallbackXaiTranscriberLanguage? Language { get; set; }

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
