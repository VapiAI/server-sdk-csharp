using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Configuration for requesting explicit verbal recording consent, including the announcement voice and action to take when the customer declines.
/// </summary>
[Serializable]
public record RecordingConsentPlanVerbal : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the message asking for consent to record the call.
    /// If the type is `stay-on-line`, the message should ask the user to hang up if they do not consent.
    /// If the type is `verbal`, the message should ask the user to verbally consent or decline.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    /// <summary>
    /// This is the voice to use for the consent message. If not specified, inherits from the assistant's voice.
    /// Use a different voice for the consent message for a better user experience.
    /// </summary>
    [JsonPropertyName("voice")]
    public object? Voice { get; set; }

    /// <summary>
    /// This controls whether the consent assistant speaks first or waits for the caller to speak first.
    ///
    /// Use:
    /// - `assistant-speaks-first` (default) to have the consent assistant play the consent message as soon as the call is answered.
    /// - `assistant-waits-for-user` to have the consent assistant wait for the caller to speak before playing the consent message.
    ///
    /// We strongly recommend `assistant-waits-for-user` for outbound calls. Some telephony providers signal "answered" while the line is still ringing, which can cause the consent message to play into a ringing line and be missed by the caller. Waiting for the caller to speak first guarantees they hear the full consent message.
    ///
    /// Note: when combined with `type: 'stay-on-line'`, silence only counts toward consent after the caller has spoken at least once.
    ///
    /// @default 'assistant-speaks-first'
    /// </summary>
    [JsonPropertyName("firstMessageMode")]
    public RecordingConsentPlanVerbalFirstMessageMode? FirstMessageMode { get; set; }

    /// <summary>
    /// Tool to execute if user verbally declines recording consent
    /// </summary>
    [JsonPropertyName("declineTool")]
    public object? DeclineTool { get; set; }

    /// <summary>
    /// ID of existing tool to execute if user verbally declines recording consent
    /// </summary>
    [JsonPropertyName("declineToolId")]
    public string? DeclineToolId { get; set; }

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
