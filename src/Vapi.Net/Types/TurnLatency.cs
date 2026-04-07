using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TurnLatency : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the model latency for the first token.
    /// </summary>
    [JsonPropertyName("modelLatency")]
    public double? ModelLatency { get; set; }

    /// <summary>
    /// This is the voice latency from the model output.
    /// </summary>
    [JsonPropertyName("voiceLatency")]
    public double? VoiceLatency { get; set; }

    /// <summary>
    /// This is the transcriber latency from the user speech.
    /// </summary>
    [JsonPropertyName("transcriberLatency")]
    public double? TranscriberLatency { get; set; }

    /// <summary>
    /// This is the endpointing latency.
    /// </summary>
    [JsonPropertyName("endpointingLatency")]
    public double? EndpointingLatency { get; set; }

    /// <summary>
    /// This is the latency for the whole turn.
    /// </summary>
    [JsonPropertyName("turnLatency")]
    public double? TurnLatency_ { get; set; }

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
