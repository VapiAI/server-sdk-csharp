using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ToolRejectionPlan
{
    /// <summary>
    /// This is the list of conditions that must be evaluated.
    ///
    /// Usage:
    /// - If all conditions match (AND logic), the tool call is rejected.
    /// - For OR logic at the top level, use a single 'group' condition with operator: 'OR'.
    ///
    /// @default [] - Empty array means tool always executes
    /// </summary>
    [JsonPropertyName("conditions")]
    public IEnumerable<object>? Conditions { get; set; }

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
