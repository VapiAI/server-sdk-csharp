using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallHealthDashboardIssueActivityDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Existing issue version after this transition; also the per-issue activity identity.
    /// </summary>
    [JsonPropertyName("rowVersion")]
    public required int RowVersion { get; set; }

    /// <summary>
    /// User resolve, dismiss or restore, or the system reopen written when a new match reopens a resolved issue.
    /// </summary>
    [JsonPropertyName("action")]
    public required CallHealthDashboardIssueActivityDtoAction Action { get; set; }

    /// <summary>
    /// Omitted for private-key actors and system entries; names/emails are not copied.
    /// </summary>
    [JsonPropertyName("actorUserId")]
    public string? ActorUserId { get; set; }

    /// <summary>
    /// Optional team-visible comment; omitted after privacy scrubbing.
    /// </summary>
    [JsonPropertyName("comment")]
    public string? Comment { get; set; }

    /// <summary>
    /// Database action time; ordering uses rowVersion rather than rounded timestamps.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

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
