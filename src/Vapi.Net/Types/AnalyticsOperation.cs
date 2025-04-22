using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
