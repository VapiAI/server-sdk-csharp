using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record InsightTimeRange : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the start date for the time range.
    ///
    /// Should be a valid ISO 8601 date-time string or relative time string.
    /// If not provided, defaults to the 7 days ago.
    ///
    /// Relative time strings of the format "-{number}{unit}" are allowed.
    ///
    /// Valid units are:
    /// - d: days
    /// - h: hours
    /// - w: weeks
    /// - m: months
    /// - y: years
    /// </summary>
    [JsonPropertyName("start")]
    public object? Start { get; set; }

    /// <summary>
    /// This is the end date for the time range.
    ///
    /// Should be a valid ISO 8601 date-time string or relative time string.
    /// If not provided, defaults to now.
    ///
    /// Relative time strings of the format "-{number}{unit}" are allowed.
    ///
    /// Valid units are:
    /// - d: days
    /// - h: hours
    /// - w: weeks
    /// - m: months
    /// - y: years
    /// </summary>
    [JsonPropertyName("end")]
    public object? End { get; set; }

    /// <summary>
    /// This is the timezone you want to set for the query.
    ///
    /// If not provided, defaults to UTC.
    /// </summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

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
