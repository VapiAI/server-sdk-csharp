using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record Condition
{
    /// <summary>
    /// This is the value you want to compare against the parameter.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
