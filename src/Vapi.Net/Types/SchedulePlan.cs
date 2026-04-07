using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SchedulePlan : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the ISO 8601 date-time string of the earliest time the call can be scheduled.
    /// </summary>
    [JsonPropertyName("earliestAt")]
    public required DateTime EarliestAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of the latest time the call can be scheduled.
    /// </summary>
    [JsonPropertyName("latestAt")]
    public DateTime? LatestAt { get; set; }

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
