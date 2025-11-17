using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record FilterStringArrayTypeColumnOnCallTable
{
    /// <summary>
    /// This is the column in the call table that will be filtered on.
    /// String Array Type columns are the same as String Type columns, but provides the ability to filter on multiple values provided as an array.
    /// Must be a valid column for the selected table.
    /// </summary>
    [JsonPropertyName("column")]
    public required FilterStringArrayTypeColumnOnCallTableColumn Column { get; set; }

    /// <summary>
    /// This is the operator to use for the filter.
    /// The operator must be `in` or `not_in`.
    /// </summary>
    [JsonPropertyName("operator")]
    public required FilterStringArrayTypeColumnOnCallTableOperator Operator { get; set; }

    /// <summary>
    /// These are the values to filter on.
    /// </summary>
    [JsonPropertyName("value")]
    public IEnumerable<string> Value { get; set; } = new List<string>();

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
