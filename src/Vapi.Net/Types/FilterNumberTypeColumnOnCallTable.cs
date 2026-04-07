using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record FilterNumberTypeColumnOnCallTable : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the column in the call table that will be filtered on.
    /// Number Type columns are columns where the rows store data as a number.
    /// Must be a valid column for the selected table.
    /// </summary>
    [JsonPropertyName("column")]
    public required FilterNumberTypeColumnOnCallTableColumn Column { get; set; }

    /// <summary>
    /// This is the operator to use for the filter.
    /// For number type columns, the operator must be "=", "&gt;", "&lt;", "&gt;=", "&lt;="
    /// </summary>
    [JsonPropertyName("operator")]
    public required FilterNumberTypeColumnOnCallTableOperator Operator { get; set; }

    /// <summary>
    /// This is the value to filter on.
    /// </summary>
    [JsonPropertyName("value")]
    public required double Value { get; set; }

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
