using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TrafficAllocationControllerFindAllPaginatedRequest
{
    /// <summary>
    /// Filter to allocations for this assistant.
    /// </summary>
    [JsonIgnore]
    public string? AssistantId { get; set; }

    /// <summary>
    /// The page number to return. Defaults to 1.
    /// </summary>
    [JsonIgnore]
    public int? Page { get; set; }

    /// <summary>
    /// The maximum number of items to return. Defaults to 100.
    /// </summary>
    [JsonIgnore]
    public int? Limit { get; set; }

    /// <summary>
    /// The sort order for pagination. Defaults to 'DESC'.
    /// </summary>
    [JsonIgnore]
    public TrafficAllocationControllerFindAllPaginatedRequestSortOrder? SortOrder { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
