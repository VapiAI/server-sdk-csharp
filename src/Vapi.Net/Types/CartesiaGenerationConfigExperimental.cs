using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CartesiaGenerationConfigExperimental
{
    /// <summary>
    /// Toggle accent localization for sonic-3: 0 (disabled, default) or 1 (enabled). When enabled, the voice adapts to match the transcript language accent while preserving vocal characteristics.
    /// </summary>
    [JsonPropertyName("accentLocalization")]
    public int? AccentLocalization { get; set; }

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
