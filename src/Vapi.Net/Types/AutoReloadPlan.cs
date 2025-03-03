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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
