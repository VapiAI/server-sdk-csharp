using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallHealthDashboardSeriesPageDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Full resolved completion window used by every total, rate and coverage count.
    /// </summary>
    [JsonPropertyName("window")]
    public required CallHealthDashboardWindowDto Window { get; set; }

    /// <summary>
    /// Clipped completion window represented by this page's daily buckets.
    /// </summary>
    [JsonPropertyName("pageWindow")]
    public required CallHealthDashboardWindowDto PageWindow { get; set; }

    /// <summary>
    /// Continue chart dates only; independent of the issue-row nextCursor.
    /// </summary>
    [JsonPropertyName("nextCursor")]
    public string? NextCursor { get; set; }

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
