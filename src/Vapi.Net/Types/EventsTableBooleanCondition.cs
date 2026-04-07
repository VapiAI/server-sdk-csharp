using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record EventsTableBooleanCondition : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The boolean field name from the event data
    /// </summary>
    [JsonPropertyName("column")]
    public required string Column { get; set; }

    /// <summary>
    /// Boolean comparison operator
    /// </summary>
    [JsonPropertyName("operator")]
    public required EventsTableBooleanConditionOperator Operator { get; set; }

    /// <summary>
    /// The boolean value to compare
    /// </summary>
    [JsonPropertyName("value")]
    public required bool Value { get; set; }

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
