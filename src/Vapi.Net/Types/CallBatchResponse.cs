using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record CallBatchResponse
{
    /// <summary>
    /// This is the list of calls that were created.
    /// </summary>
    [JsonPropertyName("results")]
    public IEnumerable<Call> Results { get; set; } = new List<Call>();

    /// <summary>
    /// This is the list of calls that failed to be created.
    /// </summary>
    [JsonPropertyName("errors")]
    public IEnumerable<CallBatchError> Errors { get; set; } = new List<CallBatchError>();

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
