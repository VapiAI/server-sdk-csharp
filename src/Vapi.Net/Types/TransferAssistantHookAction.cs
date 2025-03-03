using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record TransferAssistantHookAction
{
    /// <summary>
    /// This is the type of action - must be "transfer"
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "transfer";

    /// <summary>
    /// This is the destination details for the transfer - can be a phone number or SIP URI
    /// </summary>
    [JsonPropertyName("destination")]
    public object? Destination { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
