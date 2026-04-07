using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record Condition : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the operator you want to use to compare the parameter and value.
    /// </summary>
    [JsonPropertyName("operator")]
    public required ConditionOperator Operator { get; set; }

    /// <summary>
    /// This is the name of the parameter that you want to check.
    /// </summary>
    [JsonPropertyName("param")]
    public required string Param { get; set; }

    /// <summary>
    /// This is the value you want to compare against the parameter.
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
