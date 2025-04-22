using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ByoSipTrunkCredential
{
    /// <summary>
    /// This can be used to bring your own SIP trunks or to connect to a Carrier.
    /// </summary>
    [JsonPropertyName("provider")]
    public string? Provider { get; set; }

    /// <summary>
    /// This is the unique identifier for the credential.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the unique identifier for the org that this credential belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the credential was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the assistant was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// This is the name of credential. This is just for your reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the list of SIP trunk's gateways.
    /// </summary>
    [JsonPropertyName("gateways")]
    public IEnumerable<SipTrunkGateway> Gateways { get; set; } = new List<SipTrunkGateway>();

    /// <summary>
    /// This can be used to configure the outbound authentication if required by the SIP trunk.
    /// </summary>
    [JsonPropertyName("outboundAuthenticationPlan")]
    public SipTrunkOutboundAuthenticationPlan? OutboundAuthenticationPlan { get; set; }

    /// <summary>
    /// This ensures the outbound origination attempts have a leading plus. Defaults to false to match conventional telecom behavior.
    ///
    /// Usage:
    /// - Vonage/Twilio requires leading plus for all outbound calls. Set this to true.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("outboundLeadingPlusEnabled")]
    public bool? OutboundLeadingPlusEnabled { get; set; }

    /// <summary>
    /// This can be used to configure the tech prefix on outbound calls. This is an advanced property.
    /// </summary>
    [JsonPropertyName("techPrefix")]
    public string? TechPrefix { get; set; }

    /// <summary>
    /// This can be used to enable the SIP diversion header for authenticating the calling number if the SIP trunk supports it. This is an advanced property.
    /// </summary>
    [JsonPropertyName("sipDiversionHeader")]
    public string? SipDiversionHeader { get; set; }

    /// <summary>
    /// This is an advanced configuration for enterprise deployments. This uses the onprem SBC to trunk into the SIP trunk's `gateways`, rather than the managed SBC provided by Vapi.
    /// </summary>
    [JsonPropertyName("sbcConfiguration")]
    public SbcConfiguration? SbcConfiguration { get; set; }

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
