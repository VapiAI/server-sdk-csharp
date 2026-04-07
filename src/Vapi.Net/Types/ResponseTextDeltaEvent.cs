using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ResponseTextDeltaEvent : IJsonOnDeserialized
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
    /// Text delta being added
    /// </summary>
    [JsonPropertyName("delta")]
    public required string Delta { get; set; }

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
    /// Event type
    /// </summary>
    [JsonPropertyName("type")]
    public required ResponseTextDeltaEventType Type { get; set; }

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
