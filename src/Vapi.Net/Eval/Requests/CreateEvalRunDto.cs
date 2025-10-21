using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateEvalRunDto
{
    /// <summary>
    /// This is the transient eval that will be run
    /// </summary>
    [JsonPropertyName("eval")]
    public CreateEvalDto? Eval { get; set; }

    /// <summary>
    /// This is the target that will be run against the eval
    /// </summary>
    [JsonPropertyName("target")]
    public required object Target { get; set; }

    /// <summary>
    /// This is the type of the run.
    /// Currently it is fixed to `eval`.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "eval";

    /// <summary>
    /// This is the id of the eval that will be run.
    /// </summary>
    [JsonPropertyName("evalId")]
    public string? EvalId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
