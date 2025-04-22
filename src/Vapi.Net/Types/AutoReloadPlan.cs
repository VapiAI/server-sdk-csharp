using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record AutoReloadPlan
{
    /// <summary>
    /// This the amount of credits to reload.
    /// </summary>
    [JsonPropertyName("credits")]
    public required double Credits { get; set; }

    /// <summary>
    /// This is the limit at which the reload is triggered.
    /// </summary>
    [JsonPropertyName("threshold")]
    public required double Threshold { get; set; }

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
