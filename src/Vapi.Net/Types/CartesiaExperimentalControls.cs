using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Cartesia voice controls for speed and emotion.
/// </summary>
[Serializable]
public record CartesiaExperimentalControls : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Speaking-speed control expressed as a preset or a value from -1 to 1.
    /// </summary>
    [JsonPropertyName("speed")]
    public OneOf<CartesiaSpeedControlZero, double>? Speed { get; set; }

    /// <summary>
    /// Emotion and intensity applied to the Cartesia voice.
    /// </summary>
    [JsonPropertyName("emotion")]
    public CartesiaExperimentalControlsEmotion? Emotion { get; set; }

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
