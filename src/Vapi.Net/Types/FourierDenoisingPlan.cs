using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record FourierDenoisingPlan
{
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
