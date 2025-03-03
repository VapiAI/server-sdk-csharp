using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record VoiceCost
{
    /// <summary>
    /// This is the voice that was used during the call.
    ///
    /// This matches one of the following:
    /// - `call.assistant.voice`,
    /// - `call.assistantId-&gt;voice`,
    /// - `call.squad[n].assistant.voice`,
    /// - `call.squad[n].assistantId-&gt;voice`,
    /// - `call.squadId-&gt;[n].assistant.voice`,
    /// - `call.squadId-&gt;[n].assistantId-&gt;voice`.
    /// </summary>
    [JsonPropertyName("voice")]
    public object Voice { get; set; } = new Dictionary<string, object?>();

    /// <summary>
    /// This is the number of characters that were generated during the call. These should be total characters used in the call for single assistant calls, while squad calls will have multiple voice costs one for each assistant that was used.
    /// </summary>
    [JsonPropertyName("characters")]
    public required double Characters { get; set; }

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
