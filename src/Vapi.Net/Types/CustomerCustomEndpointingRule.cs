using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record CustomerCustomEndpointingRule
{
    /// <summary>
    /// This is the regex pattern to match.
    ///
    /// Note:
    /// - This works by using the `RegExp.test` method in Node.JS. Eg. `/hello/.test("hello there")` will return `true`.
    ///
    /// Hot tip:
    /// - In JavaScript, escape `\` when sending the regex pattern. Eg. `"hello\sthere"` will be sent over the wire as `"hellosthere"`. Send `"hello\\sthere"` instead.
    /// - `RegExp.test` does substring matching, so `/cat/.test("I love cats")` will return `true`. To do full string matching, send "^cat$".
    /// </summary>
    [JsonPropertyName("regex")]
    public required string Regex { get; set; }

    /// <summary>
    /// These are the options for the regex match. Defaults to all disabled.
    ///
    /// @default []
    /// </summary>
    [JsonPropertyName("regexOptions")]
    public IEnumerable<RegexOption>? RegexOptions { get; set; }

    /// <summary>
    /// This is the endpointing timeout in seconds, if the rule is matched.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public required double TimeoutSeconds { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
