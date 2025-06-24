using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ToolMessageComplete
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
    /// This is optional and defaults to "assistant".
    ///
    /// When role=assistant, `content` is said out loud.
    ///
    /// When role=system, `content` is passed to the model in a system message. Example:
    ///     system: default one
    ///     assistant:
    ///     user:
    ///     assistant:
    ///     user:
    ///     assistant:
    ///     user:
    ///     assistant: tool called
    ///     tool: your server response
    ///     &lt;--- system prompt as hint
    ///     ---&gt; model generates response which is spoken
    /// This is useful when you want to provide a hint to the model about what to say next.
    /// </summary>
    [JsonPropertyName("role")]
    public ToolMessageCompleteRole? Role { get; set; }

    /// <summary>
    /// This is an optional boolean that if true, the call will end after the message is spoken. Default is false.
    ///
    /// This is ignored if `role` is set to `system`.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("endCallAfterSpokenEnabled")]
    public bool? EndCallAfterSpokenEnabled { get; set; }

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
