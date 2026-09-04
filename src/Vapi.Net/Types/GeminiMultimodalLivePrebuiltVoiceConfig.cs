using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Selects a prebuilt voice for Gemini Multimodal Live audio output.
/// </summary>
[Serializable]
public record GeminiMultimodalLivePrebuiltVoiceConfig : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Prebuilt Gemini voice used for audio output.
    /// </summary>
    [JsonPropertyName("voiceName")]
    public required GeminiMultimodalLivePrebuiltVoiceConfigVoiceName VoiceName { get; set; }

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
