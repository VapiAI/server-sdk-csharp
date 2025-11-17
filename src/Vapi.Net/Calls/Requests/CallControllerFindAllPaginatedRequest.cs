using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallControllerFindAllPaginatedRequest
{
    /// <summary>
    /// Filter by assistant overrides. Use variableValues to filter by template variables.
    /// </summary>
    [JsonIgnore]
    public object? AssistantOverrides { get; set; }

    /// <summary>
    /// Filter by customer properties. Supports filtering by number, name, externalId, and extension.
    /// </summary>
    [JsonIgnore]
    public object? Customer { get; set; }

    /// <summary>
    /// This will return calls with the specified assistantId.
    /// </summary>
    [JsonIgnore]
    public string? AssistantId { get; set; }

    /// <summary>
    /// This will return calls where the transient assistant name exactly matches the specified value (case-insensitive).
    /// </summary>
    [JsonIgnore]
    public string? AssistantName { get; set; }

    /// <summary>
    /// This will return calls with the specified squadId.
    /// </summary>
    [JsonIgnore]
    public string? SquadId { get; set; }

    /// <summary>
    /// This will return calls where the transient squad name exactly matches the specified value (case-insensitive).
    /// </summary>
    [JsonIgnore]
    public string? SquadName { get; set; }

    /// <summary>
    /// This will return calls with the specified callId.
    /// </summary>
    [JsonIgnore]
    public string? Id { get; set; }

    /// <summary>
    /// This will return calls with the specified callIds.
    /// </summary>
    [JsonIgnore]
    public IEnumerable<string> IdAny { get; set; } = new List<string>();

    /// <summary>
    /// This will return calls where the cost is less than or equal to the specified value.
    /// </summary>
    [JsonIgnore]
    public double? CostLe { get; set; }

    /// <summary>
    /// This will return calls where the cost is greater than or equal to the specified value.
    /// </summary>
    [JsonIgnore]
    public double? CostGe { get; set; }

    /// <summary>
    /// This will return calls with the exact specified cost.
    /// </summary>
    [JsonIgnore]
    public double? Cost { get; set; }

    /// <summary>
    /// This will return calls with the specified successEvaluation.
    /// </summary>
    [JsonIgnore]
    public string? SuccessEvaluation { get; set; }

    /// <summary>
    /// This will return calls with the specified endedReason.
    /// </summary>
    [JsonIgnore]
    public string? EndedReason { get; set; }

    /// <summary>
    /// This will return calls with the specified phoneNumberId.
    /// </summary>
    [JsonIgnore]
    public string? PhoneNumberId { get; set; }

    /// <summary>
    /// Filter calls by structured output values. Use structured output ID as key and filter operators as values.
    /// </summary>
    [JsonIgnore]
    public Dictionary<string, StructuredOutputFilterDto>? StructuredOutputs { get; set; }

    /// <summary>
    /// Filter calls by the first scorecard's normalized score.
    /// </summary>
    [JsonIgnore]
    public string? Score { get; set; }

    /// <summary>
    /// This is the page number to return. Defaults to 1.
    /// </summary>
    [JsonIgnore]
    public double? Page { get; set; }

    /// <summary>
    /// This is the sort order for pagination. Defaults to 'DESC'.
    /// </summary>
    [JsonIgnore]
    public CallControllerFindAllPaginatedRequestSortOrder? SortOrder { get; set; }

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
