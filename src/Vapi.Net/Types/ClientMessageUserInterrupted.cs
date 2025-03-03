using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ClientMessageUserInterrupted
{
    /// <summary>
    /// This is the type of the message. "user-interrupted" is sent when the user interrupts the assistant.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "user-interrupted";

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
