using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Pagination and retention metadata returned with a paginated list of phone numbers.
/// </summary>
[Serializable]
public record PaginationMeta : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The number of phone numbers returned per page.
    /// </summary>
    [JsonPropertyName("itemsPerPage")]
    public required double ItemsPerPage { get; set; }

    /// <summary>
    /// The total number of phone numbers matching the request.
    /// </summary>
    [JsonPropertyName("totalItems")]
    public required double TotalItems { get; set; }

    /// <summary>
    /// The current page number.
    /// </summary>
    [JsonPropertyName("currentPage")]
    public required double CurrentPage { get; set; }

    [JsonPropertyName("totalPages")]
    public double? TotalPages { get; set; }

    [JsonPropertyName("hasNextPage")]
    public bool? HasNextPage { get; set; }

    /// <summary>
    /// Opaque cursor for the next page under keyset pagination (PRO-3163). Pass it
    /// back as the `cursor` query param to fetch the next page without an OFFSET
    /// scan. Present only when a further page likely exists.
    /// </summary>
    [JsonPropertyName("nextCursor")]
    public string? NextCursor { get; set; }

    [JsonPropertyName("sortOrder")]
    public PaginationMetaSortOrder? SortOrder { get; set; }

    /// <summary>
    /// Whether additional matching phone numbers exist beyond the organization's data-retention window.
    /// </summary>
    [JsonPropertyName("itemsBeyondRetention")]
    public bool? ItemsBeyondRetention { get; set; }

    /// <summary>
    /// The inclusive upper creation-time boundary applied to the result set.
    /// </summary>
    [JsonPropertyName("createdAtLe")]
    public DateTime? CreatedAtLe { get; set; }

    /// <summary>
    /// The inclusive lower creation-time boundary applied to the result set.
    /// </summary>
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
