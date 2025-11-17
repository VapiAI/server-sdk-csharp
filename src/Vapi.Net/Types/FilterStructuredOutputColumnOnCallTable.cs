using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record FilterStructuredOutputColumnOnCallTable
{
    /// <summary>
    /// This is the column in the call table that will be filtered on.
    /// Structured Output Type columns are only to filter on artifact.structuredOutputs[OutputID] column.
    /// </summary>
    [JsonPropertyName("column")]
    public required FilterStructuredOutputColumnOnCallTableColumn Column { get; set; }

    /// <summary>
    /// This is the operator to use for the filter.
    /// The operator depends on the value type of the structured output.
    /// If the structured output is a string or boolean, the operator must be "=", "!="
    /// If the structured output is a number, the operator must be "=", "&gt;", "&lt;", "&gt;=", "&lt;="
    /// If the structured output is an array, the operator must be "in" or "not_in"
    /// </summary>
    [JsonPropertyName("operator")]
    public required FilterStructuredOutputColumnOnCallTableOperator Operator { get; set; }

    /// <summary>
    /// This is the value to filter on.
    /// The value type depends on the structured output type being filtered.
    /// </summary>
    [JsonPropertyName("value")]
    public object Value { get; set; } = new Dictionary<string, object?>();

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
