using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record LangfuseServerProbeResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Whether {apiUrl}/api/public/health answered at all.
    /// </summary>
    [JsonPropertyName("reachable")]
    public required bool Reachable { get; set; }

    /// <summary>
    /// The exact version the server reported, e.g. 3.63.0. Absent when the destination answered without one (proxies, adapters) or not at all.
    /// </summary>
    [JsonPropertyName("serverVersion")]
    public string? ServerVersion { get; set; }

    /// <summary>
    /// Why the URL was refused without being contacted (a private address, plaintext http). Absent for a destination that was merely unreachable: supplying the version yourself applies there, but not here, because saving would refuse the URL with this same reason.
    /// </summary>
    [JsonPropertyName("blockedMessage")]
    public string? BlockedMessage { get; set; }

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
