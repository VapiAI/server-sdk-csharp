using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ExactReplacement : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
