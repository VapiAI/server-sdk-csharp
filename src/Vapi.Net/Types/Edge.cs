using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record Edge
{
    [JsonPropertyName("condition")]
    public object? Condition { get; set; }

    [JsonPropertyName("from")]
    public required string From { get; set; }

    [JsonPropertyName("to")]
    public required string To { get; set; }

    /// <summary>
    /// This is for metadata you want to store on the edge.
    /// </summary>
    [JsonPropertyName("metadata")]
    public object? Metadata { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
