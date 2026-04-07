using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SipTrunkOutboundAuthenticationPlan : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
