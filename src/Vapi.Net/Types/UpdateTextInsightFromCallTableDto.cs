using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record UpdateTextInsightFromCallTableDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the name of the Insight.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// Formulas are mathematical expressions applied on the data returned by the queries to transform them before being used to create the insight.
    /// The formulas needs to be a valid mathematical expression, supported by MathJS - https://mathjs.org/docs/expressions/syntax.html
    /// A formula is created by using the query names as the variable.
    /// The formulas must contain at least one query name in the LiquidJS format {{query_name}} or {{['query name']}} which will be substituted with the query result.
    /// For example, if you have 2 queries, 'Was Booking Made' and 'Average Call Duration', you can create a formula like this:
    /// ```
    /// {{['Query 1']}} / {{['Query 2']}} * 100
    /// ```
    ///
    /// ```
    /// ({{[Query 1]}} * 10) + {{[Query 2]}}
    /// ```
    /// This will take the
    ///
    /// You can also use the query names as the variable in the formula.
    /// </summary>
    [JsonPropertyName("formula")]
    public object? Formula { get; set; }

    [JsonPropertyName("timeRange")]
    public InsightTimeRange? TimeRange { get; set; }

    /// <summary>
    /// These are the queries to run to generate the insight.
    /// For Text Insights, we only allow a single query, or require a formula if multiple queries are provided
    /// </summary>
    [JsonPropertyName("queries")]
    public IEnumerable<
        OneOf<
            JsonQueryOnCallTableWithStringTypeColumn,
            JsonQueryOnCallTableWithNumberTypeColumn,
            JsonQueryOnCallTableWithStructuredOutputColumn
        >
    >? Queries { get; set; }

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
