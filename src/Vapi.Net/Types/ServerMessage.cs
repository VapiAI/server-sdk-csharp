using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record ServerMessage
{
    /// <summary>
    /// These are all the messages that can be sent to your server before, after and during the call. Configure the messages you'd like to receive in `assistant.serverMessages`.
    ///
    /// The server where the message is sent is determined by the following precedence order:
    ///
    /// 1. `tool.server.url` (if configured, and only for "tool-calls" message)
    /// 2. `assistant.serverUrl` (if configure)
    /// 3. `phoneNumber.serverUrl` (if configured)
    /// 4. `org.serverUrl` (if configured)
    /// </summary>
    [JsonPropertyName("message")]
    public required object Message { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
