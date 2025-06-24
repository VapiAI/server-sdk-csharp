using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record MonitorPlan
{
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
