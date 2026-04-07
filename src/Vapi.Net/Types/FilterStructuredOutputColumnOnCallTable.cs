using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record FilterStructuredOutputColumnOnCallTable : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
