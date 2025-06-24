using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record BackgroundSpeechDenoisingPlan
{
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
