using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record FourierDenoisingPlan : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whether Fourier denoising is enabled. Note that this is experimental and may not work as expected.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// Whether automatic media detection is enabled. When enabled, the filter will automatically
    /// detect consistent background TV/music/radio and switch to more aggressive filtering settings.
    /// Only applies when enabled is true.
    /// </summary>
    [JsonPropertyName("mediaDetectionEnabled")]
    public bool? MediaDetectionEnabled { get; set; }

    /// <summary>
    /// Static threshold in dB used as fallback when no baseline is established.
    /// </summary>
    [JsonPropertyName("staticThreshold")]
    public double? StaticThreshold { get; set; }

    /// <summary>
    /// How far below the rolling baseline to filter audio, in dB.
    /// Lower values (e.g., -10) are more aggressive, higher values (e.g., -20) are more conservative.
    /// </summary>
    [JsonPropertyName("baselineOffsetDb")]
    public double? BaselineOffsetDb { get; set; }

    /// <summary>
    /// Rolling window size in milliseconds for calculating the audio baseline.
    /// Larger windows adapt more slowly but are more stable.
    /// </summary>
    [JsonPropertyName("windowSizeMs")]
    public double? WindowSizeMs { get; set; }

    /// <summary>
    /// Percentile to use for baseline calculation (1-99).
    /// Higher percentiles (e.g., 85) focus on louder speech, lower percentiles (e.g., 50) include quieter speech.
    /// </summary>
    [JsonPropertyName("baselinePercentile")]
    public double? BaselinePercentile { get; set; }

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
