using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TransportConfigurationTwilio
{
    [JsonPropertyName("provider")]
    public string Provider { get; set; } = "twilio";

    /// <summary>
    /// The integer number of seconds that we should allow the phone to ring before assuming there is no answer.
    /// The default is `60` seconds and the maximum is `600` seconds.
    /// For some call flows, we will add a 5-second buffer to the timeout value you provide.
    /// For this reason, a timeout value of 10 seconds could result in an actual timeout closer to 15 seconds.
    /// You can set this to a short time, such as `15` seconds, to hang up before reaching an answering machine or voicemail.
    ///
    /// @default 60
    /// </summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>
    /// Whether to record the call.
    /// Can be `true` to record the phone call, or `false` to not.
    /// The default is `false`.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("record")]
    public bool? Record { get; set; }

    /// <summary>
    /// The number of channels in the final recording.
    /// Can be: `mono` or `dual`.
    /// The default is `mono`.
    /// `mono` records both legs of the call in a single channel of the recording file.
    /// `dual` records each leg to a separate channel of the recording file.
    /// The first channel of a dual-channel recording contains the parent call and the second channel contains the child call.
    ///
    /// @default 'mono'
    /// </summary>
    [JsonPropertyName("recordingChannels")]
    public TransportConfigurationTwilioRecordingChannels? RecordingChannels { get; set; }

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
