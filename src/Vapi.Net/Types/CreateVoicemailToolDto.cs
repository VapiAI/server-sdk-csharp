using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record CreateVoicemailToolDto
{
    /// <summary>
    /// This determines if the tool is async.
    ///
    /// If async, the assistant will move forward without waiting for your server to respond. This is useful if you just want to trigger something on your server.
    ///
    /// If sync, the assistant will wait for your server to respond. This is useful if want assistant to respond with the result from your server.
    ///
    /// Defaults to synchronous (`false`).
    /// </summary>
    [JsonPropertyName("async")]
    public bool? Async { get; set; }

    /// <summary>
    /// These are the messages that will be spoken to the user as the tool is running.
    ///
    /// For some tools, this is auto-filled based on special fields like `tool.destinations`. For others like the function tool, these can be custom configured.
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<
        OneOf<ToolMessageStart, ToolMessageComplete, ToolMessageFailed, ToolMessageDelayed>
    >? Messages { get; set; }

    /// <summary>
    /// The type of tool. "voicemail". This uses the model itself to determine if a voicemil was reached. Can be used alternatively/alongside with TwilioVoicemailDetection
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// This is the function definition of the tool.
    ///
    /// For `endCall`, `transferCall`, and `dtmf` tools, this is auto-filled based on tool-specific fields like `tool.destinations`. But, even in those cases, you can provide a custom function definition for advanced use cases.
    ///
    /// An example of an advanced use case is if you want to customize the message that's spoken for `endCall` tool. You can specify a function where it returns an argument "reason". Then, in `messages` array, you can have many "request-complete" messages. One of these messages will be triggered if the `messages[].conditions` matches the "reason" argument.
    /// </summary>
    [JsonPropertyName("function")]
    public OpenAiFunction? Function { get; set; }

    /// <summary>
    /// This is the server that will be hit when this tool is requested by the model.
    ///
    /// All requests will be sent with the call object among other things. You can find more details in the Server URL documentation.
    ///
    /// This overrides the serverUrl set on the org and the phoneNumber. Order of precedence: highest tool.server.url, then assistant.serverUrl, then phoneNumber.serverUrl, then org.serverUrl.
    /// </summary>
    [JsonPropertyName("server")]
    public Server? Server { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
