using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// A saved squad configuration that coordinates a group of assistants during a conversation. The first member starts the call, and member destinations control transfers between assistants.
/// </summary>
[Serializable]
public record Squad : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the latest version label (e.g. `v3`) of the squad in the version
    /// history. `null` while the org is not yet onboarded to versioning, or for
    /// squads that have not yet been published under it.
    /// </summary>
    [JsonPropertyName("latestVersion")]
    public string? LatestVersion { get; set; }

    /// <summary>
    /// Read-only. Present only when a model this configuration uses is deprecated or retired in Vapi's model deprecation registry, judged on the day of the response. Each entry names the slot (for example `model` or `model.fallbackModels[1]`), provider, stored model, and deprecation and retirement dates as `YYYY-MM-DD` in UTC. `replacementStatus` is `available` with a `replacementModel` when a replacement can be recommended, or `manual-action-required` with no replacement model when eligibility is unknown or no eligible replacement exists. `manual-action-required` can be transient when compliance context is unavailable; re-fetch before acting. HIPAA-required configurations, sparse drafts, and squads with unresolved assistant references currently require manual action. HIPAA requirements include the organization and assistant settings, including HIPAA with data retention. Recommendations reflect the response-time decision; they do not confirm a swap or authorize future execution. Examples: an available recommendation includes `{"replacementStatus":"available","replacementModel":"gpt-5"}`; a blocked recommendation includes `{"replacementStatus":"manual-action-required"}`. Ignored if sent back in a create or update request.
    /// </summary>
    [JsonPropertyName("modelDeprecations")]
    public IEnumerable<ModelDeprecationNotice>? ModelDeprecations { get; set; }

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

    /// <summary>
    /// This is the unique identifier for the squad.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the unique identifier for the org that this squad belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the squad was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the squad was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

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
