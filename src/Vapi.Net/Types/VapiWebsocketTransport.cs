using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record VapiWebsocketTransport : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the conversation type of the call (ie, voice or chat).
    /// </summary>
    [JsonPropertyName("conversationType")]
    public VapiWebsocketTransportConversationType? ConversationType { get; set; }

    /// <summary>
    /// This is the audio format of the call. Defaults to 16KHz raw pcm_s16le
    /// </summary>
    [JsonPropertyName("audioFormat")]
    public AudioFormat? AudioFormat { get; set; }

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
