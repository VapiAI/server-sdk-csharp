using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ClientMessageSpeechUpdate
{
    /// <summary>
    /// This is the type of the message. "speech-update" is sent whenever assistant or user start or stop speaking.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "speech-update";

    /// <summary>
    /// This is the status of the speech update.
    /// </summary>
    [JsonPropertyName("status")]
    public required ClientMessageSpeechUpdateStatus Status { get; set; }

    /// <summary>
    /// This is the role which the speech update is for.
    /// </summary>
    [JsonPropertyName("role")]
    public required ClientMessageSpeechUpdateRole Role { get; set; }

    /// <summary>
    /// This is the turn number of the speech update (0-indexed).
    /// </summary>
    [JsonPropertyName("turn")]
    public double? Turn { get; set; }

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
