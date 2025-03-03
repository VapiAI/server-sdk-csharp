using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record SayHook
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = "say";

    /// <summary>
    /// This is for metadata you want to store on the task.
    /// </summary>
    [JsonPropertyName("metadata")]
    public object? Metadata { get; set; }

    [JsonPropertyName("exact")]
    public string? Exact { get; set; }

    [JsonPropertyName("prompt")]
    public string? Prompt { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
