using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TurnLatency
{
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
