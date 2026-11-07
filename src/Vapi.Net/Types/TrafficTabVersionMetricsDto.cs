using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TrafficTabVersionMetricsDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("assistantVersionId")]
    public string? AssistantVersionId { get; set; }

    /// <summary>
    /// The published version label, such as "v7". Null when no version row resolves (unversioned calls, or a since-purged version).
    /// </summary>
    [JsonPropertyName("assistantVersionLabel")]
    public string? AssistantVersionLabel { get; set; }

    /// <summary>
    /// True for the row aggregating calls with no assistant version (stored as SQL NULL).
    /// </summary>
    [JsonPropertyName("unversioned")]
    public bool? Unversioned { get; set; }

    [JsonPropertyName("calls")]
    public required double Calls { get; set; }

    /// <summary>
    /// The version's share in the currently-governing allocation. Null when the version is not in the current split — never rendered as 0%.
    /// </summary>
    [JsonPropertyName("configuredPercentage")]
    public double? ConfiguredPercentage { get; set; }

    /// <summary>
    /// calls / totalCalls * 100 over the window, rounded to 3 decimals.
    /// </summary>
    [JsonPropertyName("actualPercentage")]
    public required double ActualPercentage { get; set; }

    [JsonPropertyName("durationSeconds")]
    public required TrafficTabDurationSecondsDto DurationSeconds { get; set; }

    [JsonPropertyName("costPerMinute")]
    public required TrafficTabCostPerMinuteDto CostPerMinute { get; set; }

    [JsonPropertyName("latencyMs")]
    public required TrafficTabLatencyMsDto LatencyMs { get; set; }

    /// <summary>
    /// Full per-reason counts; the UI unions and top-Ns.
    /// </summary>
    [JsonPropertyName("endedReasons")]
    public IEnumerable<TrafficTabEndedReasonCountDto> EndedReasons { get; set; } =
        new List<TrafficTabEndedReasonCountDto>();

    [JsonPropertyName("timeseries")]
    public IEnumerable<TrafficTabTimeseriesPointDto> Timeseries { get; set; } =
        new List<TrafficTabTimeseriesPointDto>();

    /// <summary>
    /// Present only when structuredOutputIds was given.
    /// </summary>
    [JsonPropertyName("structuredOutputs")]
    public IEnumerable<TrafficTabStructuredOutputDto>? StructuredOutputs { get; set; }

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
