using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Controls whether Krisp smart denoising filters background speech and noise.
/// </summary>
[Serializable]
public record SmartDenoisingPlan : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whether smart denoising using Krisp is enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Intensity of the applied noise suppression, in the range [0, 100].
    /// - 0 indicates no noise suppression (audio passes through Krisp unchanged).
    /// - 100 indicates full noise suppression and is the historical default.
    /// Lower values are gentler; useful for narrowband telephony audio where
    /// aggressive suppression can over-attenuate brief or quiet user utterances.
    ///
    /// Per-call intensity is in beta, rolling out to select organizations and
    /// regions. Where it is not available, or the intensity-aware denoiser cannot
    /// be reached for a call, the standard denoiser runs at full suppression
    /// (100) whatever this is set to, so 0 does not turn suppression off there;
    /// set `enabled` to false for that. If the standard denoiser cannot be
    /// reached either, the call's audio passes through without smart denoising.
    ///
    /// @default 100
    /// </summary>
    [JsonPropertyName("intensity")]
    public double? Intensity { get; set; }

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
