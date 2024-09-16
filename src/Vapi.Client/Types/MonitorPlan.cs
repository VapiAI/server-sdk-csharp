using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
