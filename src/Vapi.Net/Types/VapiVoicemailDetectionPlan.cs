using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record VapiVoicemailDetectionPlan : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
    /// This is the provider to use for voicemail detection.
    /// </summary>
    [JsonPropertyName("provider")]
    public required VapiVoicemailDetectionPlanProvider Provider { get; set; }

    /// <summary>
    /// This is the backoff plan for the voicemail detection.
    /// </summary>
    [JsonPropertyName("backoffPlan")]
    public VoicemailDetectionBackoffPlan? BackoffPlan { get; set; }

    /// <summary>
    /// This is the detection type to use for voicemail detection.
    /// - 'audio': Uses native audio models (default)
    /// - 'transcript': Uses ASR/transcript-based detection
    /// @default 'audio' (audio detection)
    /// </summary>
    [JsonPropertyName("type")]
    public VapiVoicemailDetectionPlanType? Type { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
