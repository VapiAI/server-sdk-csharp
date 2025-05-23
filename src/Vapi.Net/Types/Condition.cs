using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record Condition
{
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
