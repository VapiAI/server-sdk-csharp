using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record UpdateByoSipTrunkCredentialDto
{
    /// <summary>
    /// This can be used to bring your own SIP trunks or to connect to a Carrier.
    /// </summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>
    /// This is the list of SIP trunk's gateways.
    /// </summary>
    [JsonPropertyName("gateways")]
    public IEnumerable<SipTrunkGateway> Gateways { get; set; } = new List<SipTrunkGateway>();

    /// <summary>
    /// This is the name of the SIP trunk. This is just for your reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This can be used to configure the outbound authentication if required by the SIP trunk.
    /// </summary>
    [JsonPropertyName("outboundAuthenticationPlan")]
    public SipTrunkOutboundAuthenticationPlan? OutboundAuthenticationPlan { get; set; }

    /// <summary>
    /// This ensures the outbound origination attempts have a leading plus. Defaults to false to match conventional telecom behavior.
    ///
    /// Usage:
    ///
    /// - Vonage/Twilio requires leading plus for all outbound calls. Set this to true.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("outboundLeadingPlusEnabled")]
    public bool? OutboundLeadingPlusEnabled { get; set; }

    /// <summary>
    /// This is an advanced configuration for enterprise deployments. This uses the onprem SBC to trunk into the SIP trunk's `gateways`, rather than the managed SBC provided by Vapi.
    /// </summary>
    [JsonPropertyName("sbcConfiguration")]
    public SbcConfiguration? SbcConfiguration { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
