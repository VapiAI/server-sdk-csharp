using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record RegexOption
{
    /// <summary>
    /// This is the type of the regex option. Options are:
    /// - `ignore-case`: Ignores the case of the text being matched. Add
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
