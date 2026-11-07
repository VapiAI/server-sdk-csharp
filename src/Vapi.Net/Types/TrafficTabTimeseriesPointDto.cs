using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TrafficTabTimeseriesPointDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Start of the bucket, ISO 8601 (UTC).
    /// </summary>
    [JsonPropertyName("bucketStart")]
    public required string BucketStart { get; set; }

    [JsonPropertyName("calls")]
    public required double Calls { get; set; }

    [JsonPropertyName("durationSecondsMean")]
    public double? DurationSecondsMean { get; set; }

    [JsonPropertyName("costPerMinuteMean")]
    public double? CostPerMinuteMean { get; set; }

    [JsonPropertyName("turnLatencyMsMean")]
    public double? TurnLatencyMsMean { get; set; }

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
