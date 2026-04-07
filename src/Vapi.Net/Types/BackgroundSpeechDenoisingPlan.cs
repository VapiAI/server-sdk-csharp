using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record BackgroundSpeechDenoisingPlan : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whether smart denoising using Krisp is enabled.
    /// </summary>
    [JsonPropertyName("smartDenoisingPlan")]
    public SmartDenoisingPlan? SmartDenoisingPlan { get; set; }

    /// <summary>
    /// Whether Fourier denoising is enabled. Note that this is experimental and may not work as expected.
    ///
    /// This can be combined with smart denoising, and will be run afterwards.
    /// </summary>
    [JsonPropertyName("fourierDenoisingPlan")]
    public FourierDenoisingPlan? FourierDenoisingPlan { get; set; }

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
