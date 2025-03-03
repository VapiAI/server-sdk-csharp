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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
