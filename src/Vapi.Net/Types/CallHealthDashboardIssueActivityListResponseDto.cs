using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallHealthDashboardIssueActivityListResponseDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Newest issue versions first; this is shared team activity, not per-user feedback.
    /// </summary>
    [JsonPropertyName("results")]
    public IEnumerable<CallHealthDashboardIssueActivityDto> Results { get; set; } =
        new List<CallHealthDashboardIssueActivityDto>();

    /// <summary>
    /// Signed continuation bound to the authenticated organization, issue and activity contract.
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
