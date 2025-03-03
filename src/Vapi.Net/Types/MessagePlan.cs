using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record MessagePlan
{
    /// <summary>
    /// This are the messages that the assistant will speak when the user hasn't responded for `idleTimeoutSeconds`. Each time the timeout is triggered, a random message will be chosen from this array.
    ///
    /// Usage:
    /// - If user gets distracted and doesn't respond for a while, this can be used to grab their attention.
    /// - If the transcriber doesn't pick up what the user said, this can be used to ask the user to repeat themselves. (From the perspective of the assistant, the conversation is idle since it didn't "hear" any user messages.)
    ///
    /// @default null (no idle message is spoken)
    /// </summary>
    [JsonPropertyName("idleMessages")]
    public IEnumerable<string>? IdleMessages { get; set; }

    /// <summary>
    /// This determines the maximum number of times `idleMessages` can be spoken during the call.
    ///
    /// @default 3
    /// </summary>
    [JsonPropertyName("idleMessageMaxSpokenCount")]
    public double? IdleMessageMaxSpokenCount { get; set; }

    /// <summary>
    /// This is the timeout in seconds before a message from `idleMessages` is spoken. The clock starts when the assistant finishes speaking and remains active until the user speaks.
    ///
    /// @default 10
    /// </summary>
    [JsonPropertyName("idleTimeoutSeconds")]
    public double? IdleTimeoutSeconds { get; set; }

    /// <summary>
    /// This is the message that the assistant will say if the call ends due to silence.
    ///
    /// If unspecified, it will hang up without saying anything.
    /// </summary>
    [JsonPropertyName("silenceTimeoutMessage")]
    public string? SilenceTimeoutMessage { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
