using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SquadVersion : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Optional human-readable label for this version. Set when the version is published.
    /// </summary>
    [JsonPropertyName("versionName")]
    public string? VersionName { get; set; }

    /// <summary>
    /// Optional description for this version. Set when the version is published.
    /// </summary>
    [JsonPropertyName("versionDescription")]
    public string? VersionDescription { get; set; }

    /// <summary>
    /// This is the unique identifier for the version row.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the unique identifier for the org that owns this version.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// This is the unique identifier for the squad this version was snapshotted from.
    /// </summary>
    [JsonPropertyName("squadId")]
    public required string SquadId { get; set; }

    /// <summary>
    /// This is the public monotonic version label, e.g. "v1".
    /// System-owned and incremented per squad; never user-supplied.
    /// </summary>
    [JsonPropertyName("version")]
    public required string Version { get; set; }

    /// <summary>
    /// This is the SHA-256 hex of the snapshotted content used for no-op detection.
    /// </summary>
    [JsonPropertyName("configHash")]
    public required string ConfigHash { get; set; }

    /// <summary>
    /// This is the prior version label (vN-1). Null on v1 or for branch roots.
    /// </summary>
    [JsonPropertyName("parentVersion")]
    public string? ParentVersion { get; set; }

    /// <summary>
    /// The version this version was restored from. Null when it was not restored.
    /// </summary>
    [JsonPropertyName("restoredFromVersion")]
    public string? RestoredFromVersion { get; set; }

    /// <summary>
    /// This is the actor that wrote this version. Email when created via JWT; null
    /// when created via API key, and null for a baseline version authored by nobody.
    /// </summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>
    /// This is the soft-delete timestamp. Null when active.
    /// </summary>
    [JsonPropertyName("deletedAt")]
    public DateTime? DeletedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the version was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// This is the name of the squad.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the list of assistants that make up the squad.
    ///
    /// The call will start with the first assistant in the list.
    /// </summary>
    [JsonPropertyName("members")]
    public IEnumerable<SquadMemberDto> Members { get; set; } = new List<SquadMemberDto>();

    /// <summary>
    /// This can be used to override all the assistants' settings and provide values for their template variables.
    ///
    /// Both `membersOverrides` and `members[n].assistantOverrides` can be used together. First, `members[n].assistantOverrides` is applied. Then, `membersOverrides` is applied as a global override.
    /// </summary>
    [JsonPropertyName("membersOverrides")]
    public AssistantOverrides? MembersOverrides { get; set; }

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
