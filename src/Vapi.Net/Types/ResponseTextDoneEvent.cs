using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ResponseTextDoneEvent : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Index of the content part
    /// </summary>
    [JsonPropertyName("content_index")]
    public required double ContentIndex { get; set; }

    /// <summary>
    /// ID of the output item
    /// </summary>
    [JsonPropertyName("item_id")]
    public required string ItemId { get; set; }

    /// <summary>
    /// Index of the output item
    /// </summary>
    [JsonPropertyName("output_index")]
    public required double OutputIndex { get; set; }

    /// <summary>
    /// Complete text content
    /// </summary>
    [JsonPropertyName("text")]
    public required string Text { get; set; }

    /// <summary>
    /// Event type
    /// </summary>
    [JsonPropertyName("type")]
    public required ResponseTextDoneEventType Type { get; set; }

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
