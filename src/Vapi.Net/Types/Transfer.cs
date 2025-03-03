using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record Transfer
{
    [JsonPropertyName("destination")]
    public object Destination { get; set; } = new Dictionary<string, object?>();

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// This is for metadata you want to store on the task.
    /// </summary>
    [JsonPropertyName("metadata")]
    public object? Metadata { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
