using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ToolMessageStart
{
    /// <summary>
    /// This is an alternative to the `content` property. It allows to specify variants of the same content, one per language.
    ///
    /// Usage:
    /// - If your assistants are multilingual, you can provide content for each language.
    /// - If you don't provide content for a language, the first item in the array will be automatically translated to the active language at that moment.
    ///
    /// This will override the `content` property.
    /// </summary>
    [JsonPropertyName("contents")]
    public IEnumerable<TextContent>? Contents { get; set; }

    /// <summary>
    /// This is an optional boolean that if true, the tool call will only trigger after the message is spoken. Default is false.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("blocking")]
    public bool? Blocking { get; set; }

    /// <summary>
    /// This is the content that the assistant says when this message is triggered.
    /// </summary>
    [JsonPropertyName("content")]
    public string? Content { get; set; }

    /// <summary>
    /// This is an optional array of conditions that the tool call arguments must meet in order for this message to be triggered.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IEnumerable<Condition>? Conditions { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
