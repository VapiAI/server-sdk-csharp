using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ToolCallFunction
{
    /// <summary>
    /// This is the name of the function the model called.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// These are the arguments that the function was called with.
    /// </summary>
    [JsonPropertyName("arguments")]
    public object Arguments { get; set; } = new Dictionary<string, object?>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
