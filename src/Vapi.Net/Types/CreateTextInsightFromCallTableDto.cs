using System.Text.Json;
using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateTextInsightFromCallTableDto
{
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
    > Queries { get; set; } =
        new List<
            OneOf<
                JsonQueryOnCallTableWithStringTypeColumn,
                JsonQueryOnCallTableWithNumberTypeColumn,
                JsonQueryOnCallTableWithStructuredOutputColumn
            >
        >();

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
