using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record GuardrailAuthoring : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("mode")]
    public required GuardrailAuthoringMode Mode { get; set; }

    [JsonPropertyName("behavior")]
    public required string Behavior { get; set; }

    /// <summary>
    /// Natural-language condition evaluated using the candidate and call history.
    /// </summary>
    [JsonPropertyName("condition")]
    public string? Condition { get; set; }

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
