using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record Gather
{
    [JsonPropertyName("output")]
    public required JsonSchema Output { get; set; }

    /// <summary>
    /// This is whether or not the workflow should read back the gathered data to the user, and ask about its correctness.
    /// </summary>
    [JsonPropertyName("confirmContent")]
    public bool? ConfirmContent { get; set; }

    /// <summary>
    /// This is a list of hooks for a task.
    /// Each hook is a list of tasks to run on a trigger (such as on start, on failure, etc).
    /// Only Say is supported for now.
    /// </summary>
    [JsonPropertyName("hooks")]
    public IEnumerable<Hook>? Hooks { get; set; }

    /// <summary>
    /// This is the number of times we should try to gather the information from the user before we failover to the fail path. An example of this would be a user refusing to give their phone number for privacy reasons, and then going down a different path on account of this
    /// </summary>
    [JsonPropertyName("maxRetries")]
    public double? MaxRetries { get; set; }

    /// <summary>
    /// This is a liquid templating string. On the first call to Gather, the template will be filled out with variables from the context, and will be spoken verbatim to the user. An example would be "Base on your zipcode, it looks like you could be in one of these counties: {{ counties | join: ", " }}. Which one do you live in?"
    /// </summary>
    [JsonPropertyName("literalTemplate")]
    public string? LiteralTemplate { get; set; }

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
