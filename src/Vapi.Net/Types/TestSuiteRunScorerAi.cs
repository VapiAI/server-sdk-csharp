using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record TestSuiteRunScorerAi
{
    /// <summary>
    /// This is the type of the scorer, which must be AI.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "ai";

    /// <summary>
    /// This is the result of the test suite.
    /// </summary>
    [JsonPropertyName("result")]
    public required TestSuiteRunScorerAiResult Result { get; set; }

    /// <summary>
    /// This is the reasoning provided by the AI scorer.
    /// </summary>
    [JsonPropertyName("reasoning")]
    public required string Reasoning { get; set; }

    /// <summary>
    /// This is the rubric used by the AI scorer.
    /// </summary>
    [JsonPropertyName("rubric")]
    public required string Rubric { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
