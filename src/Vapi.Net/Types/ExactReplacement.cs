using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ExactReplacement
{
    /// <summary>
    /// This option let's you control whether to replace all instances of the key or only the first one. By default, it only replaces the first instance.
    /// Examples:
    /// - For { type: 'exact', key: 'hello', value: 'hi', replaceAllEnabled: false }. Before: "hello world, hello universe" | After: "hi world, hello universe"
    /// - For { type: 'exact', key: 'hello', value: 'hi', replaceAllEnabled: true }. Before: "hello world, hello universe" | After: "hi world, hi universe"
    /// @default false
    /// </summary>
    [JsonPropertyName("replaceAllEnabled")]
    public bool? ReplaceAllEnabled { get; set; }

    /// <summary>
    /// This is the key to replace.
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

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
