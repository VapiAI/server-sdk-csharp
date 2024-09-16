using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record AnalyticsOperation
{
    /// <summary>
    /// This is the aggregation operation you want to perform.
    /// </summary>
    [JsonPropertyName("operation")]
    public required AnalyticsOperationOperation Operation { get; set; }

    /// <summary>
    /// This is the columns you want to perform the aggregation operation on.
    /// </summary>
    [JsonPropertyName("column")]
    public required AnalyticsOperationColumn Column { get; set; }

    /// <summary>
    /// This is the alias for column name returned. Defaults to `${operation}${column}`.
    /// </summary>
    [JsonPropertyName("alias")]
    public string? Alias { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
