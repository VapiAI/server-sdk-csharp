using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record RegexCondition : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the regular expression pattern to match against message content.
    ///
    /// Note:
    /// - This works by using the RegExp.test method in Node.JS. Eg. /hello/.test("hello there") will return true.
    ///
    /// Hot tips:
    /// - In JavaScript, escape \ when sending the regex pattern. Eg. "hello\sthere" will be sent over the wire as "hellosthere". Send "hello\\sthere" instead.
    /// - RegExp.test does substring matching, so /cat/.test("I love cats") will return true. To do full string matching, use anchors: /^cat$/ will only match exactly "cat".
    /// - Word boundaries \b are useful for matching whole words: /\bcat\b/ matches "cat" but not "cats" or "category".
    /// - Use inline flags for portability: (?i) for case insensitive, (?m) for multiline
    /// </summary>
    [JsonPropertyName("regex")]
    public required string Regex { get; set; }

    /// <summary>
    /// This is the target for messages to check against.
    /// If not specified, the condition will run on the last message (position: -1).
    /// If role is not specified, it will look at the last message regardless of role.
    /// @default { position: -1 }
    /// </summary>
    [JsonPropertyName("target")]
    public MessageTarget? Target { get; set; }

    /// <summary>
    /// This is the flag that when true, the condition matches if the pattern does NOT match.
    /// Useful for ensuring certain words/phrases are absent.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("negate")]
    public bool? Negate { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
