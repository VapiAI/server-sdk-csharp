using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record GroupCondition
{
    /// <summary>
    /// This is the logical operator for combining conditions in this group
    /// </summary>
    [JsonPropertyName("operator")]
    public required GroupConditionOperator Operator { get; set; }

    /// <summary>
    /// This is the list of nested conditions to evaluate.
    /// Supports recursive nesting of groups for complex logic.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IEnumerable<object> Conditions { get; set; } = new List<object>();

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
