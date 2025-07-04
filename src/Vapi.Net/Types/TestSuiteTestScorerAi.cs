using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TestSuiteTestScorerAi
{
    /// <summary>
    /// This is the type of the scorer, which must be AI.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ai";

    /// <summary>
    /// This is the rubric used by the AI scorer.
    /// </summary>
    [JsonPropertyName("rubric")]
    public required string Rubric { get; set; }

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
