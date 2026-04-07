using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CartesiaPronunciationDictionary : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Unique identifier for the pronunciation dictionary
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// Name of the pronunciation dictionary
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// ID of the user who owns this dictionary
    /// </summary>
    [JsonPropertyName("ownerId")]
    public required string OwnerId { get; set; }

    /// <summary>
    /// Whether this dictionary is pinned for the user
    /// </summary>
    [JsonPropertyName("pinned")]
    public required bool Pinned { get; set; }

    /// <summary>
    /// List of text-to-pronunciation mappings
    /// </summary>
    [JsonPropertyName("items")]
    public IEnumerable<CartesiaPronunciationDictItem> Items { get; set; } =
        new List<CartesiaPronunciationDictItem>();

    /// <summary>
    /// ISO 8601 timestamp of when the dictionary was created
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

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
