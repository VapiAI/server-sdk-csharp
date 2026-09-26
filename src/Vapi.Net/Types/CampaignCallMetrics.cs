using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CampaignCallMetrics : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the number of contacts a call was actually placed for. Contacts
    /// that were skipped, rejected before dialing, or failed to dispatch are not
    /// counted — no call existed, so there was nothing to answer.
    /// </summary>
    [JsonPropertyName("dialed")]
    public required double Dialed { get; set; }

    /// <summary>
    /// This is the number of those calls a human picked up. Voicemail does not
    /// count. Divide by `dialed` for the pick-up rate.
    /// </summary>
    [JsonPropertyName("connected")]
    public required double Connected { get; set; }

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
