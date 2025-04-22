using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ChatCompletionMessageMetadata
{
    [JsonPropertyName("taskName")]
    public required string TaskName { get; set; }

    [JsonPropertyName("taskType")]
    public required string TaskType { get; set; }

    [JsonPropertyName("taskOutput")]
    public required string TaskOutput { get; set; }

    [JsonPropertyName("taskState")]
    public object? TaskState { get; set; }

    [JsonPropertyName("nodeTrace")]
    public IEnumerable<string>? NodeTrace { get; set; }

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
