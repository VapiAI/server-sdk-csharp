using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record RegexOption
{
    /// <summary>
    /// This is the type of the regex option. Options are:
    ///
    /// - `ignore-case`: Ignores the case of the text being matched.
    /// - `whole-word`: Matches whole words only.
    /// - `multi-line`: Matches across multiple lines.
    /// </summary>
    [JsonPropertyName("type")]
    public required RegexOptionType Type { get; set; }

    /// <summary>
    /// This is whether to enable the option.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("enabled")]
    public required bool Enabled { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
