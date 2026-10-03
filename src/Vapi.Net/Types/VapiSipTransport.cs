using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record VapiSipTransport : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the conversation type of the call (ie, voice or chat).
    /// </summary>
    [JsonPropertyName("conversationType")]
    public VapiSipTransportConversationType? ConversationType { get; set; }

    /// <summary>
    /// This sets the timeout for outbound dial operations in seconds. This is the duration the call will ring before timing out.
    ///
    /// @default 60
    /// </summary>
    [JsonPropertyName("dialTimeout")]
    public double? DialTimeout { get; set; }

    /// <summary>
    /// This is the call SID of the Vapi SIP call.
    /// </summary>
    [JsonPropertyName("sbcCallSid")]
    public string? SbcCallSid { get; set; }

    /// <summary>
    /// This is the call ID of the Vapi SIP call.
    /// </summary>
    [JsonPropertyName("callSid")]
    public string? CallSid { get; set; }

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
