using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record VapiVoicemailDetectionPlan
{
    /// <summary>
    /// This is the maximum duration from the start of the call that we will wait for a voicemail beep, before speaking our message
    ///
    /// - If we detect a voicemail beep before this, we will speak the message at that point.
    ///
    /// - Setting too low a value means that the bot will start speaking its voicemail message too early. If it does so before the actual beep, it will get cut off. You should definitely tune this to your use case.
    ///
    /// @default 30
    /// @min 0
    /// @max 60
    /// </summary>
    [JsonPropertyName("beepMaxAwaitSeconds")]
    public double? BeepMaxAwaitSeconds { get; set; }

    /// <summary>
    /// This is the backoff plan for the voicemail detection.
    /// </summary>
    [JsonPropertyName("backoffPlan")]
    public VoicemailDetectionBackoffPlan? BackoffPlan { get; set; }

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
