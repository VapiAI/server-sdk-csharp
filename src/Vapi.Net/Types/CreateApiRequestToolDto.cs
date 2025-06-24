using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateApiRequestToolDto
{
    /// <summary>
    /// These are the messages that will be spoken to the user as the tool is running.
    ///
    /// For some tools, this is auto-filled based on special fields like `tool.destinations`. For others like the function tool, these can be custom configured.
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<object>? Messages { get; set; }

    [JsonPropertyName("method")]
    public required CreateApiRequestToolDtoMethod Method { get; set; }

    /// <summary>
    /// This is the timeout in seconds for the request. Defaults to 20 seconds.
    ///
    /// @default 20
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>
    /// This is the name of the tool. This will be passed to the model.
    ///
    /// Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 40.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the description of the tool. This will be passed to the model.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// This is where the request will be sent.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    /// <summary>
    /// This is the body of the request.
    /// </summary>
    [JsonPropertyName("body")]
    public JsonSchema? Body { get; set; }

    /// <summary>
    /// These are the headers to send in the request.
    /// </summary>
    [JsonPropertyName("headers")]
    public JsonSchema? Headers { get; set; }

    /// <summary>
    /// This is the backoff plan if the request fails. Defaults to undefined (the request will not be retried).
    ///
    /// @default undefined (the request will not be retried)
    /// </summary>
    [JsonPropertyName("backoffPlan")]
    public BackoffPlan? BackoffPlan { get; set; }

    /// <summary>
    /// This is the plan that controls the variable extraction from the tool's response.
    /// </summary>
    [JsonPropertyName("variableExtractionPlan")]
    public VariableExtractionPlan? VariableExtractionPlan { get; set; }

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
