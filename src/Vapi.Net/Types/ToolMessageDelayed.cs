using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ToolMessageDelayed
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
    /// The number of milliseconds to wait for the server response before saying this message.
    /// </summary>
    [JsonPropertyName("timingMilliseconds")]
    public double? TimingMilliseconds { get; set; }

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
