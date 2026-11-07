using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallHealthDashboardIssueDailyDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// UTC calendar date, with boundary buckets clipped to the requested window.
    /// </summary>
    [JsonPropertyName("date")]
    public required DateOnly Date { get; set; }

    /// <summary>
    /// Distinct visible calls matching this issue in the bucket.
    /// </summary>
    [JsonPropertyName("affectedCallCount")]
    public required int AffectedCallCount { get; set; }

    /// <summary>
    /// All accepted current-goal outcomes for the issue's assistant in the bucket.
    /// </summary>
    [JsonPropertyName("analyzedCallCount")]
    public required int AnalyzedCallCount { get; set; }

    /// <summary>
    /// affectedCallCount / analyzedCallCount; omitted for a zero denominator.
    /// </summary>
    [JsonPropertyName("affectedCallRate")]
    public double? AffectedCallRate { get; set; }

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
