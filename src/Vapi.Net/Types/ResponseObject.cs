using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ResponseObject : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Unique identifier for this Response
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// The object type
    /// </summary>
    [JsonPropertyName("object")]
    public required ResponseObjectObject Object { get; set; }

    /// <summary>
    /// Unix timestamp (in seconds) of when this Response was created
    /// </summary>
    [JsonPropertyName("created_at")]
    public required double CreatedAt { get; set; }

    /// <summary>
    /// Status of the response
    /// </summary>
    [JsonPropertyName("status")]
    public required ResponseObjectStatus Status { get; set; }

    /// <summary>
    /// Error message if the response failed
    /// </summary>
    [JsonPropertyName("error")]
    public string? Error { get; set; }

    /// <summary>
    /// Output messages from the model
    /// </summary>
    [JsonPropertyName("output")]
    public IEnumerable<ResponseOutputMessage> Output { get; set; } =
        new List<ResponseOutputMessage>();

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
