using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record InsightFormula
{
    /// <summary>
    /// This is the name of the formula.
    /// It will be used to label the formula in the insight board on the UI.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the formula to calculate the insight from the queries.
    /// The formula needs to be a valid mathematical expression.
    /// The formula must contain at least one query name in the LiquidJS format {{query_name}} or {{['query name']}} which will be substituted with the query result.
    /// Any MathJS formula is allowed - https://mathjs.org/docs/expressions/syntax.html
    ///
    /// Common valid math operations are +, -, *, /, %
    /// </summary>
    [JsonPropertyName("formula")]
    public required string Formula { get; set; }

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
