using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record RecordingConsentPlanStayOnLine : IJsonOnDeserialized
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
    /// Number of seconds to wait before transferring to the assistant if user stays on the call
    /// </summary>
    [JsonPropertyName("waitSeconds")]
    public double? WaitSeconds { get; set; }

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
