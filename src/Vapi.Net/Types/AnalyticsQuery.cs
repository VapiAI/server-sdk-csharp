using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AnalyticsQuery : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the table you want to query.
    /// </summary>
    [JsonPropertyName("table")]
    public required AnalyticsQueryTable Table { get; set; }

    /// <summary>
    /// This is the list of columns you want to group by.
    /// </summary>
    [JsonPropertyName("groupBy")]
    public IEnumerable<AnalyticsQueryGroupByItem>? GroupBy { get; set; }

    /// <summary>
    /// This is the list of variable value keys you want to group by.
    /// </summary>
    [JsonPropertyName("groupByVariableValue")]
    public IEnumerable<VariableValueGroupBy>? GroupByVariableValue { get; set; }

    /// <summary>
    /// This is the name of the query. This will be used to identify the query in the response.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// This is the time range for the query.
    /// </summary>
    [JsonPropertyName("timeRange")]
    public TimeRange? TimeRange { get; set; }

    /// <summary>
    /// This is the list of operations you want to perform.
    /// </summary>
    [JsonPropertyName("operations")]
    public IEnumerable<AnalyticsOperation> Operations { get; set; } =
        new List<AnalyticsOperation>();

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
