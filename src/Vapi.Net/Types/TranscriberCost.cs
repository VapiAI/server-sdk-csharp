using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record TranscriberCost
{
    /// <summary>
    /// This is the transcriber that was used during the call.
    ///
    /// This matches one of the below:
    ///
    /// - `call.assistant.transcriber`,
    /// - `call.assistantId->transcriber`,
    /// - `call.squad[n].assistant.transcriber`,
    /// - `call.squad[n].assistantId->transcriber`,
    /// - `call.squadId->[n].assistant.transcriber`,
    /// - `call.squadId->[n].assistantId->transcriber`.
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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
