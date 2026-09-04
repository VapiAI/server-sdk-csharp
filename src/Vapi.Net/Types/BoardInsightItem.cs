using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record BoardInsightItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("type")]
    public required BoardInsightItemType Type { get; set; }

    [JsonPropertyName("insightId")]
    public required string InsightId { get; set; }

    [JsonPropertyName("systemKey")]
    public string? SystemKey { get; set; }

    [JsonPropertyName("position")]
    public required BoardItemPosition Position { get; set; }

    [JsonPropertyName("size")]
    public required BoardItemSize Size { get; set; }

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
