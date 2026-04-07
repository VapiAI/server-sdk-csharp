using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record PaginationMeta : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("itemsPerPage")]
    public required double ItemsPerPage { get; set; }

    [JsonPropertyName("totalItems")]
    public required double TotalItems { get; set; }

    [JsonPropertyName("currentPage")]
    public required double CurrentPage { get; set; }

    [JsonPropertyName("itemsBeyondRetention")]
    public bool? ItemsBeyondRetention { get; set; }

    [JsonPropertyName("createdAtLe")]
    public DateTime? CreatedAtLe { get; set; }

    [JsonPropertyName("createdAtGe")]
    public DateTime? CreatedAtGe { get; set; }

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
