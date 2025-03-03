using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record SipTrunkOutboundAuthenticationPlan
{
    /// <summary>
    /// This is not returned in the API.
    /// </summary>
    [JsonPropertyName("authPassword")]
    public string? AuthPassword { get; set; }

    [JsonPropertyName("authUsername")]
    public string? AuthUsername { get; set; }

    /// <summary>
    /// This can be used to configure if SIP register is required by the SIP trunk. If not provided, no SIP registration will be attempted.
    /// </summary>
    [JsonPropertyName("sipRegisterPlan")]
    public SipTrunkOutboundSipRegisterPlan? SipRegisterPlan { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
