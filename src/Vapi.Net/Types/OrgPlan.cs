using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record OrgPlan
{
    [JsonPropertyName("includedProviders")]
    public IEnumerable<object>? IncludedProviders { get; set; }

    [JsonPropertyName("includedMinutes")]
    public double? IncludedMinutes { get; set; }

    [JsonPropertyName("costPerOverageMinute")]
    public double? CostPerOverageMinute { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
