using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record BashTool
{
    /// <summary>
    /// These are the messages that will be spoken to the user as the tool is running.
    ///
    /// For some tools, this is auto-filled based on special fields like `tool.destinations`. For others like the function tool, these can be custom configured.
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<object>? Messages { get; set; }

    /// <summary>
    /// The sub type of tool.
    /// </summary>
    [JsonPropertyName("subType")]
    public string SubType { get; set; } = "bash_20241022";

    /// <summary>
    /// This is the server where a `tool-calls` webhook will be sent.
    ///
    ///   Notes:
    ///   - Webhook is sent to this server when a tool call is made.
    ///   - Webhook contains the call, assistant, and phone number objects.
    ///   - Webhook contains the variables set on the assistant.
    ///   - Webhook is sent to the first available URL in this order: {{tool.server.url}}, {{assistant.server.url}}, {{phoneNumber.server.url}}, {{org.server.url}}.
    ///   - Webhook expects a response with tool call result.
    /// </summary>
    [JsonPropertyName("server")]
    public Server? Server { get; set; }

    /// <summary>
    /// This is the unique identifier for the tool.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the unique identifier for the organization that this tool belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the tool was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the tool was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

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
    /// The name of the tool, fixed to 'bash'
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; } = "bash";

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
