using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ClientInboundMessageTransfer
{
    /// <summary>
    /// This is the destination to transfer the call to.
    /// </summary>
    [JsonPropertyName("destination")]
    public object? Destination { get; set; }

    /// <summary>
    /// This is the content to say.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
