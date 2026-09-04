using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record VapiWebCallTransport : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the conversation type of the call (ie, voice or chat).
    /// </summary>
    [JsonPropertyName("conversationType")]
    public VapiWebCallTransportConversationType? ConversationType { get; set; }

    /// <summary>
    /// This determines whether the daily room will be deleted and all participants will be kicked once the user leaves the room.
    /// If set to `false`, the room will be kept alive even after the user leaves, allowing clients to reconnect to the same room.
    /// If set to `true`, the room will be deleted and reconnection will not be allowed.
    ///
    /// Defaults to `true`.
    /// </summary>
    [JsonPropertyName("roomDeleteOnUserLeaveEnabled")]
    public bool? RoomDeleteOnUserLeaveEnabled { get; set; }

    /// <summary>
    /// This is the meeting token the web client should join the call with.
    /// When video recording is enabled, joining with this token starts the cloud
    /// recording automatically server-side, which is more reliable than the
    /// client starting it after joining. Set by the server; only present when
    /// video recording is enabled.
    /// </summary>
    [JsonPropertyName("callToken")]
    public string? CallToken { get; set; }

    /// <summary>
    /// This is the URL of the web call.
    /// </summary>
    [JsonPropertyName("callUrl")]
    public string? CallUrl { get; set; }

    /// <summary>
    /// This is the SIP URI of the web call.
    /// </summary>
    [JsonPropertyName("callSipUri")]
    public string? CallSipUri { get; set; }

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
