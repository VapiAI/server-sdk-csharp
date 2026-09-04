using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record VersionPinReference : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Kind of source row the pin originates from.
    /// </summary>
    [JsonPropertyName("sourceType")]
    public required VersionPinReferenceSourceType SourceType { get; set; }

    /// <summary>
    /// UUID of the source row (polymorphic, not FK-enforced).
    /// </summary>
    [JsonPropertyName("sourceId")]
    public required string SourceId { get; set; }

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
