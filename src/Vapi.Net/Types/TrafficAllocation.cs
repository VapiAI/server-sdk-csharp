using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TrafficAllocation : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Unique identifier. The most recently created allocation for an assistant is the one in effect.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// The assistant this allocation splits calls for.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public string? AssistantId { get; set; }

    /// <summary>
    /// 'explicit' splits calls across this allocation's targets. 'follow-latest' sends every call to the newest published version.
    /// </summary>
    [JsonPropertyName("allocationIntent")]
    public required TrafficAllocationAllocationIntent AllocationIntent { get; set; }

    /// <summary>
    /// When this allocation was created, which is also when it took effect.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// Who created this allocation. 'system' means Vapi created it automatically, for example when a publish advances a follow-latest allocation.
    /// </summary>
    [JsonPropertyName("actorType")]
    public required TrafficAllocationActorType ActorType { get; set; }

    /// <summary>
    /// The user id or API key id that created this allocation. Absent for system rows.
    /// </summary>
    [JsonPropertyName("actorId")]
    public string? ActorId { get; set; }

    /// <summary>
    /// Email of the user who created this allocation, as of that time.
    /// </summary>
    [JsonPropertyName("actorEmail")]
    public string? ActorEmail { get; set; }

    /// <summary>
    /// The note given when this allocation was created, if any.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// The versions this allocation splits calls across, in position order. Empty for follow-latest allocations.
    /// </summary>
    [JsonPropertyName("targets")]
    public IEnumerable<TrafficAllocationTarget> Targets { get; set; } =
        new List<TrafficAllocationTarget>();

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
