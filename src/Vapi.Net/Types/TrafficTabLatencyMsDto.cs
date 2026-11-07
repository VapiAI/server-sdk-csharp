using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TrafficTabLatencyMsDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("model")]
    public required TrafficTabLatencyStatsDto Model { get; set; }

    [JsonPropertyName("voice")]
    public required TrafficTabLatencyStatsDto Voice { get; set; }

    [JsonPropertyName("transcriber")]
    public required TrafficTabLatencyStatsDto Transcriber { get; set; }

    [JsonPropertyName("turn")]
    public required TrafficTabLatencyStatsDto Turn { get; set; }

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
