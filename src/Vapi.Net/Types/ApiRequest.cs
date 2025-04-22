using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ApiRequest
{
    [JsonPropertyName("method")]
    public required ApiRequestMethod Method { get; set; }

    /// <summary>
    /// Api endpoint to send requests to.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    /// <summary>
    /// These are the custom headers to include in the Api Request sent.
    ///
    /// Each key-value pair represents a header name and its value.
    /// </summary>
    [JsonPropertyName("headers")]
    public JsonSchema? Headers { get; set; }

    /// <summary>
    /// This defined the JSON body of your Api Request. For example, if `body_schema`
    /// included "my_field": "my_gather_statement.user_age", then the json body sent to the server would have that particular value assign to it.
    /// Right now, only data from gather statements are supported.
    /// </summary>
    [JsonPropertyName("body")]
    public JsonSchema? Body { get; set; }

    /// <summary>
    /// This is the mode of the Api Request.
    /// We only support BLOCKING and BACKGROUND for now.
    /// </summary>
    [JsonPropertyName("mode")]
    public required ApiRequestMode Mode { get; set; }

    /// <summary>
    /// This is a list of hooks for a task.
    /// Each hook is a list of tasks to run on a trigger (such as on start, on failure, etc).
    /// Only Say is supported for now.
    /// </summary>
    [JsonPropertyName("hooks")]
    public IEnumerable<Hook>? Hooks { get; set; }

    /// <summary>
    /// This is the schema for the outputs of the Api Request.
    /// </summary>
    [JsonPropertyName("output")]
    public JsonSchema? Output { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// This is for metadata you want to store on the task.
    /// </summary>
    [JsonPropertyName("metadata")]
    public object? Metadata { get; set; }

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
