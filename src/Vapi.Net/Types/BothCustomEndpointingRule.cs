using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record BothCustomEndpointingRule
{
    /// <summary>
    /// This is the regex pattern to match the assistant's message.
    ///
    /// Note:
    /// - This works by using the `RegExp.test` method in Node.JS. Eg. `/hello/.test("hello there")` will return `true`.
    ///
    /// Hot tip:
    /// - In JavaScript, escape `\` when sending the regex pattern. Eg. `"hello\sthere"` will be sent over the wire as `"hellosthere"`. Send `"hello\\sthere"` instead.
    /// - `RegExp.test` does substring matching, so `/cat/.test("I love cats")` will return `true`. To do full string matching, send "^cat$".
    /// </summary>
    [JsonPropertyName("assistantRegex")]
    public required string AssistantRegex { get; set; }

    /// <summary>
    /// These are the options for the assistant's message regex match. Defaults to all disabled.
    ///
    /// @default []
    /// </summary>
    [JsonPropertyName("assistantRegexOptions")]
    public IEnumerable<RegexOption>? AssistantRegexOptions { get; set; }

    [JsonPropertyName("customerRegex")]
    public required string CustomerRegex { get; set; }

    /// <summary>
    /// These are the options for the customer's message regex match. Defaults to all disabled.
    ///
    /// @default []
    /// </summary>
    [JsonPropertyName("customerRegexOptions")]
    public IEnumerable<RegexOption>? CustomerRegexOptions { get; set; }

    /// <summary>
    /// This is the endpointing timeout in seconds, if the rule is matched.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public required double TimeoutSeconds { get; set; }

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
