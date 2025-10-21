using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record LiquidCondition
{
    /// <summary>
    /// This is the Liquid template that must return exactly "true" or "false" as a string.
    /// The template is evaluated and the entire output must be either "true" or "false" - nothing else.
    ///
    /// Available variables:
    /// - `messages`: Array of recent messages in OpenAI chat completions format (ChatCompletionMessageParam[])
    ///   Each message has properties like: role ('user', 'assistant', 'system'), content (string), etc.
    /// - `now`: Current timestamp in milliseconds (built-in Liquid variable)
    /// - Any assistant variable values (e.g., `userName`, `accountStatus`)
    ///
    /// Useful Liquid filters for messages:
    /// - `messages | last: 5` - Get the 5 most recent messages
    /// - `messages | where: 'role', 'user'` - Filter to only user messages
    /// - `messages | reverse` - Reverse the order of messages
    /// </summary>
    [JsonPropertyName("liquid")]
    public required string Liquid { get; set; }

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
