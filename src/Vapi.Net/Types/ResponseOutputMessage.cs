using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ResponseOutputMessage : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The unique ID of the output message
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Content of the output message
    /// </summary>
    [JsonPropertyName("content")]
    public IEnumerable<ResponseOutputText> Content { get; set; } = new List<ResponseOutputText>();

    /// <summary>
    /// The role of the output message
    /// </summary>
    [JsonPropertyName("role")]
    public required ResponseOutputMessageRole Role { get; set; }

    /// <summary>
    /// The status of the message
    /// </summary>
    [JsonPropertyName("status")]
    public required ResponseOutputMessageStatus Status { get; set; }

    /// <summary>
    /// The type of the output message
    /// </summary>
    [JsonPropertyName("type")]
    public required ResponseOutputMessageType Type { get; set; }

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
