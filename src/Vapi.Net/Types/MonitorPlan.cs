using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record MonitorPlan : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This determines whether the assistant's calls allow live listening. Defaults to true.
    ///
    /// Fetch `call.monitor.listenUrl` to get the live listening URL.
    ///
    /// @default true
    /// </summary>
    [JsonPropertyName("listenEnabled")]
    public bool? ListenEnabled { get; set; }

    /// <summary>
    /// This enables authentication on the `call.monitor.listenUrl`.
    ///
    /// If `listenAuthenticationEnabled` is `true`, the `call.monitor.listenUrl` will require an `Authorization: Bearer &lt;vapi-public-api-key&gt;` header.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("listenAuthenticationEnabled")]
    public bool? ListenAuthenticationEnabled { get; set; }

    /// <summary>
    /// This determines whether the assistant's calls allow live control. Defaults to true.
    ///
    /// Fetch `call.monitor.controlUrl` to get the live control URL.
    ///
    /// To use, send any control message via a POST request to `call.monitor.controlUrl`. Here are the types of controls supported: https://docs.vapi.ai/api-reference/messages/client-inbound-message
    ///
    /// @default true
    /// </summary>
    [JsonPropertyName("controlEnabled")]
    public bool? ControlEnabled { get; set; }

    /// <summary>
    /// This enables authentication on the `call.monitor.controlUrl`.
    ///
    /// If `controlAuthenticationEnabled` is `true`, the `call.monitor.controlUrl` will require an `Authorization: Bearer &lt;vapi-public-api-key&gt;` header.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("controlAuthenticationEnabled")]
    public bool? ControlAuthenticationEnabled { get; set; }

    /// <summary>
    /// This the set of monitor ids that are attached to the assistant.
    /// The source of truth for the monitor ids is the assistant_monitor join table.
    /// This field can be used for transient assistants and to update assistants with new monitor ids.
    ///
    /// @default []
    /// </summary>
    [JsonPropertyName("monitorIds")]
    public IEnumerable<string>? MonitorIds { get; set; }

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
