using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record Monitor
{
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}