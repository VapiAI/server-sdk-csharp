using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record Transport
{
    /// <summary>
    /// This is the provider used for the call.
    /// </summary>
    [JsonPropertyName("provider")]
    public TransportProvider? Provider { get; set; }

    /// <summary>
    /// This is determines whether the assistant will have video enabled.
    ///
    /// Only relevant for `webCall` type.
    /// </summary>
    [JsonPropertyName("assistantVideoEnabled")]
    public bool? AssistantVideoEnabled { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
