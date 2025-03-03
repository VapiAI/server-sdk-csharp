using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ExactReplacement
{
    /// <summary>
    /// This is the key to replace.
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// This is the value that will replace the match.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
