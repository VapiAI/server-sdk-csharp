using System.Text.Json;
using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record JsonQueryOnCallTableWithStringTypeColumn
{
    /// <summary>
    /// This is the type of query. Only allowed type is "vapiql-json".
    /// </summary>
    [JsonPropertyName("type")]
    public required JsonQueryOnCallTableWithStringTypeColumnType Type { get; set; }

    /// <summary>
    /// This is the table that will be queried.
    /// </summary>
    [JsonPropertyName("table")]
    public required JsonQueryOnCallTableWithStringTypeColumnTable Table { get; set; }

    /// <summary>
    /// This is the filters to apply to the insight.
    /// The discriminator automatically selects the correct filter type based on column and operator.
    /// </summary>
    [JsonPropertyName("filters")]
    public IEnumerable<
        OneOf<
            FilterStringTypeColumnOnCallTable,
            FilterStringArrayTypeColumnOnCallTable,
            FilterNumberTypeColumnOnCallTable,
            FilterNumberArrayTypeColumnOnCallTable,
            FilterDateTypeColumnOnCallTable,
            FilterStructuredOutputColumnOnCallTable
        >
    >? Filters { get; set; }

    /// <summary>
    /// This is the column that will be queried in the selected table.
    /// Available columns depend on the selected table.
    /// String Type columns are columns where the rows store String data
    /// </summary>
    [JsonPropertyName("column")]
    public required JsonQueryOnCallTableWithStringTypeColumnColumn Column { get; set; }

    /// <summary>
    /// This is the aggregation operation to perform on the column.
    /// When the column is a string type, the operation must be "count".
    /// </summary>
    [JsonPropertyName("operation")]
    public required JsonQueryOnCallTableWithStringTypeColumnOperation Operation { get; set; }

    /// <summary>
    /// This is the name of the query.
    /// It will be used to label the query in the insight board on the UI.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
