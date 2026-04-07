using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record FilterDateTypeColumnOnCallTable : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the column in the call table that will be filtered on.
    /// Date Type columns are columns where the rows store data as a date.
    /// Must be a valid column for the selected table.
    /// </summary>
    [JsonPropertyName("column")]
    public required FilterDateTypeColumnOnCallTableColumn Column { get; set; }

    /// <summary>
    /// This is the operator to use for the filter.
    /// For date type columns, the operator must be "=", "&gt;", "&lt;", "&gt;=", "&lt;="
    /// </summary>
    [JsonPropertyName("operator")]
    public required FilterDateTypeColumnOnCallTableOperator Operator { get; set; }

    /// <summary>
    /// This is the value to filter on.
    /// Must be a valid ISO 8601 date-time string.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }

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
