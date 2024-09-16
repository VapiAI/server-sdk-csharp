using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record FormatPlan
{
    /// <summary>
    /// This determines whether the chunk is formatted before being sent to the voice provider. This helps with enunciation. This includes phone numbers, emails and addresses. Default `true`.
    ///
    /// Usage:
    ///
    /// - To rely on the voice provider's formatting logic, set this to `false`.
    /// - To use ElevenLabs's `enableSsmlParsing` feature, set this to `false`.
    ///
    /// If `voice.chunkPlan.enabled` is `false`, this is automatically `false` since there's no chunk to format.
    ///
    /// @default true
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// This is the cutoff after which a number is converted to individual digits instead of being spoken as words.
    ///
    /// Example:
    ///
    /// - If cutoff 2025, "12345" is converted to "1 2 3 4 5" while "1200" is converted to "twelve hundred".
    ///
    /// Usage:
    ///
    /// - If your use case doesn't involve IDs like zip codes, set this to a high value.
    /// - If your use case involves IDs that are shorter than 5 digits, set this to a lower value.
    ///
    /// @default 2025
    /// </summary>
    [JsonPropertyName("numberToDigitsCutoff")]
    public double? NumberToDigitsCutoff { get; set; }

    /// <summary>
    /// These are the custom replacements you can make to the chunk before it is sent to the voice provider.
    ///
    /// Usage:
    ///
    /// - To replace a specific word or phrase with a different word or phrase, use the `ExactReplacement` type. Eg. `{ type: 'exact', key: 'hello', value: 'hi' }`
    /// - To replace a word or phrase that matches a pattern, use the `RegexReplacement` type. Eg. `{ type: 'regex', regex: '\\b[a-zA-Z]{5}\\b', value: 'hi' }`
    ///
    /// @default []
    /// </summary>
    [JsonPropertyName("replacements")]
    public IEnumerable<object>? Replacements { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
