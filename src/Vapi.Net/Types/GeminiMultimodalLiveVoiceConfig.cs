using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Voice selection configuration for Gemini Multimodal Live.
/// </summary>
[Serializable]
public record GeminiMultimodalLiveVoiceConfig : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Prebuilt voice used for Gemini Multimodal Live speech output.
    /// </summary>
    [JsonPropertyName("prebuiltVoiceConfig")]
    public required GeminiMultimodalLivePrebuiltVoiceConfig PrebuiltVoiceConfig { get; set; }

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
