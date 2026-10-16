using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationRunControllerFindItemsRequest
{
    /// <summary>
    /// Filters run items to a specific simulation.
    /// </summary>
    [JsonIgnore]
    public string? SimulationId { get; set; }

    /// <summary>
    /// Filters run items to a specific run.
    /// </summary>
    [JsonIgnore]
    public string? RunId { get; set; }

    /// <summary>
    /// Filters run items by status.
    /// </summary>
    [JsonIgnore]
    public SimulationRunControllerFindItemsRequestStatus? Status { get; set; }

    /// <summary>
    /// This is the page number to return. Defaults to 1.
    /// </summary>
    [JsonIgnore]
    public double? Page { get; set; }

    /// <summary>
    /// This is the sort order for pagination. Defaults to 'DESC'.
    /// </summary>
    [JsonIgnore]
    public SimulationRunControllerFindItemsRequestSortOrder? SortOrder { get; set; }

    /// <summary>
    /// This is the column to sort by. Defaults to 'createdAt'.
    /// </summary>
    [JsonIgnore]
    public SimulationRunControllerFindItemsRequestSortBy? SortBy { get; set; }

    /// <summary>
    /// This is the maximum number of items to return. Defaults to 100.
    /// </summary>
    [JsonIgnore]
    public double? Limit { get; set; }

    /// <summary>
    /// This will return items where the createdAt is greater than the specified value.
    /// </summary>
    [JsonIgnore]
    public DateTime? CreatedAtGt { get; set; }

    /// <summary>
    /// This will return items where the createdAt is less than the specified value.
    /// </summary>
    [JsonIgnore]
    public DateTime? CreatedAtLt { get; set; }

    /// <summary>
    /// This will return items where the createdAt is greater than or equal to the specified value.
    /// </summary>
    [JsonIgnore]
    public DateTime? CreatedAtGe { get; set; }

    /// <summary>
    /// This will return items where the createdAt is less than or equal to the specified value.
    /// </summary>
    [JsonIgnore]
    public DateTime? CreatedAtLe { get; set; }

    /// <summary>
    /// This will return items where the updatedAt is greater than the specified value.
    /// </summary>
    [JsonIgnore]
    public DateTime? UpdatedAtGt { get; set; }

    /// <summary>
    /// This will return items where the updatedAt is less than the specified value.
    /// </summary>
    [JsonIgnore]
    public DateTime? UpdatedAtLt { get; set; }

    /// <summary>
    /// This will return items where the updatedAt is greater than or equal to the specified value.
    /// </summary>
    [JsonIgnore]
    public DateTime? UpdatedAtGe { get; set; }

    /// <summary>
    /// This will return items where the updatedAt is less than or equal to the specified value.
    /// </summary>
    [JsonIgnore]
    public DateTime? UpdatedAtLe { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
