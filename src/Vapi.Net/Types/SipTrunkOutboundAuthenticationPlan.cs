using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
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
