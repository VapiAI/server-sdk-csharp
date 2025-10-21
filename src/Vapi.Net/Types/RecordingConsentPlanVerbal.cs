using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record RecordingConsentPlanVerbal
{
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
    /// Tool to execute if user verbally declines recording consent
    /// </summary>
    [JsonPropertyName("declineTool")]
    public object? DeclineTool { get; set; }

    /// <summary>
    /// ID of existing tool to execute if user verbally declines recording consent
    /// </summary>
    [JsonPropertyName("declineToolId")]
    public string? DeclineToolId { get; set; }

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
