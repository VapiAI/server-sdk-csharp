using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record FilterStringTypeColumnOnCallTable : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the column in the call table that will be filtered on.
    /// String Type columns are columns where the rows store data as a string.
    /// Must be a valid column for the selected table.
    /// </summary>
    [JsonPropertyName("column")]
    public required FilterStringTypeColumnOnCallTableColumn Column { get; set; }

    /// <summary>
    /// This is the operator to use for the filter.
    /// For string type columns, the operator must be "=", "!=", "contains", "not contains"
    /// </summary>
    [JsonPropertyName("operator")]
    public required FilterStringTypeColumnOnCallTableOperator Operator { get; set; }

    /// <summary>
    /// This is the value to filter on.
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
