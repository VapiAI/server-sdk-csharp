using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TranscriberCost
{
    /// <summary>
    /// This is the transcriber that was used during the call.
    ///
    /// This matches one of the below:
    /// - `call.assistant.transcriber`,
    /// - `call.assistantId-&gt;transcriber`,
    /// - `call.squad[n].assistant.transcriber`,
    /// - `call.squad[n].assistantId-&gt;transcriber`,
    /// - `call.squadId-&gt;[n].assistant.transcriber`,
    /// - `call.squadId-&gt;[n].assistantId-&gt;transcriber`.
    /// </summary>
    [JsonPropertyName("transcriber")]
    public object Transcriber { get; set; } = new Dictionary<string, object?>();

    /// <summary>
    /// This is the minutes of `transcriber` usage. This should match `call.endedAt` - `call.startedAt` for single assistant calls, while squad calls will have multiple transcriber costs one for each assistant that was used.
    /// </summary>
    [JsonPropertyName("minutes")]
    public required double Minutes { get; set; }

    /// <summary>
    /// This is the cost of the component in USD.
    /// </summary>
    [JsonPropertyName("cost")]
    public required double Cost { get; set; }

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
