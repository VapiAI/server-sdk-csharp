using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Live monitoring data for a call, including attached monitor results and listening and control URLs.
/// </summary>
[Serializable]
public record Monitor : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Results produced by monitors attached to the call.
    /// </summary>
    [JsonPropertyName("monitors")]
    public IEnumerable<MonitorResult>? Monitors { get; set; }

    /// <summary>
    /// This is the URL where the assistant's calls can be listened to in real-time. To enable, set `assistant.monitorPlan.listenEnabled` to `true`.
    /// </summary>
    [JsonPropertyName("listenUrl")]
    public string? ListenUrl { get; set; }

    /// <summary>
    /// This is the URL where the assistant's calls can be controlled in real-time. To enable, set `assistant.monitorPlan.controlEnabled` to `true`.
    /// </summary>
    [JsonPropertyName("controlUrl")]
    public string? ControlUrl { get; set; }

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
