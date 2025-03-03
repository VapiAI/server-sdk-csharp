using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record AssistantHookFilter
{
    /// <summary>
    /// This is the type of filter - currently only "oneOf" is supported
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "oneOf";

    /// <summary>
    /// This is the key to filter on (e.g. "call.endedReason")
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// This is the array of possible values to match against
    /// </summary>
    [JsonPropertyName("oneOf")]
    public IEnumerable<string> OneOf { get; set; } = new List<string>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
