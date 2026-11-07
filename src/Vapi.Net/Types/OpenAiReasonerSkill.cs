using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record OpenAiReasonerSkill : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Unique name within this assistant.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Explain when the reasoner should load this skill. Always visible in its catalog.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; set; }

    /// <summary>
    /// Full skill instructions, loaded only while this skill is active.
    /// </summary>
    [JsonPropertyName("content")]
    public required string Content { get; set; }

    /// <summary>
    /// Tools available only after loading this skill. Can be combined with toolIds.
    /// </summary>
    [JsonPropertyName("tools")]
    public IEnumerable<object>? Tools { get; set; }

    /// <summary>
    /// Existing organization-owned tools available only after loading this skill.
    /// </summary>
    [JsonPropertyName("toolIds")]
    public IEnumerable<string>? ToolIds { get; set; }

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
