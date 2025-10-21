using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record EvalRunResult
{
    /// <summary>
    /// This is the status of the eval run result.
    /// The status is only 'pass' or 'fail' for an eval run result.
    /// Currently, An eval is considered `pass` only if all the Assistant Judge messages are evaluated to pass.
    /// </summary>
    [JsonPropertyName("status")]
    public required EvalRunResultStatus Status { get; set; }

    /// <summary>
    /// This is the messages of the eval run result.
    /// It contains the user/system messages
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<object> Messages { get; set; } = new List<object>();

    /// <summary>
    /// This is the start time of the eval run result.
    /// </summary>
    [JsonPropertyName("startedAt")]
    public required DateTime StartedAt { get; set; }

    /// <summary>
    /// This is the end time of the eval run result.
    /// </summary>
    [JsonPropertyName("endedAt")]
    public required DateTime EndedAt { get; set; }

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
