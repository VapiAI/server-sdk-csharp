using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record RegexReplacement
{
    /// <summary>
    /// This is the regex pattern to replace.
    ///
    /// Note:
    /// - This works by using the `string.replace` method in Node.JS. Eg. `"hello there".replace(/hello/g, "hi")` will return `"hi there"`.
    ///
    /// Hot tip:
    /// - In JavaScript, escape `\` when sending the regex pattern. Eg. `"hello\sthere"` will be sent over the wire as `"hellosthere"`. Send `"hello\\sthere"` instead.
    /// </summary>
    [JsonPropertyName("regex")]
    public required string Regex { get; set; }

    /// <summary>
    /// These are the options for the regex replacement. Defaults to all disabled.
    ///
    /// @default []
    /// </summary>
    [JsonPropertyName("options")]
    public IEnumerable<RegexOption>? Options { get; set; }

    /// <summary>
    /// This is the value that will replace the match.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }

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
