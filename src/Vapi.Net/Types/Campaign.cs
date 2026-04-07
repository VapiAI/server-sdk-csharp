using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record Campaign : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the status of the campaign.
    /// </summary>
    [JsonPropertyName("status")]
    public required CampaignStatus Status { get; set; }

    /// <summary>
    /// This is the explanation for how the campaign ended.
    /// </summary>
    [JsonPropertyName("endedReason")]
    public CampaignEndedReason? EndedReason { get; set; }

    /// <summary>
    /// This is the name of the campaign. This is just for your own reference.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// This is the assistant ID that will be used for the campaign calls. Note: Only one of assistantId, workflowId, or squadId can be used.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public string? AssistantId { get; set; }

    /// <summary>
    /// This is the workflow ID that will be used for the campaign calls. Note: Only one of assistantId, workflowId, or squadId can be used.
    /// </summary>
    [JsonPropertyName("workflowId")]
    public string? WorkflowId { get; set; }

    /// <summary>
    /// This is the squad ID that will be used for the campaign calls. Note: Only one of assistantId, workflowId, or squadId can be used.
    /// </summary>
    [JsonPropertyName("squadId")]
    public string? SquadId { get; set; }

    /// <summary>
    /// This is the phone number ID that will be used for the campaign calls. Required if dialPlan is not provided. Note: phoneNumberId and dialPlan are mutually exclusive.
    /// </summary>
    [JsonPropertyName("phoneNumberId")]
    public string? PhoneNumberId { get; set; }

    /// <summary>
    /// This is a list of dial entries, each specifying a phone number and the customers to call using that number. Use this when you want different phone numbers to call different sets of customers. Note: phoneNumberId and dialPlan are mutually exclusive.
    /// </summary>
    [JsonPropertyName("dialPlan")]
    public IEnumerable<DialPlanEntry>? DialPlan { get; set; }

    /// <summary>
    /// This is the schedule plan for the campaign. Calls will start at startedAt and continue until your organization’s concurrency limit is reached. Any remaining calls will be retried for up to one hour as capacity becomes available. After that hour or after latestAt, whichever comes first, any calls that couldn’t be placed won’t be retried.
    /// </summary>
    [JsonPropertyName("schedulePlan")]
    public SchedulePlan? SchedulePlan { get; set; }

    /// <summary>
    /// These are the customers that will be called in the campaign. Required if dialPlan is not provided.
    /// </summary>
    [JsonPropertyName("customers")]
    public IEnumerable<CreateCustomerDto>? Customers { get; set; }

    /// <summary>
    /// This is the unique identifier for the campaign.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the unique identifier for the org that this campaign belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the campaign was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the campaign was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// This is a map of call IDs to campaign call details.
    /// </summary>
    [JsonPropertyName("calls")]
    public object Calls { get; set; } = new Dictionary<string, object?>();

    /// <summary>
    /// This is the number of calls that have been scheduled.
    /// </summary>
    [JsonPropertyName("callsCounterScheduled")]
    public required double CallsCounterScheduled { get; set; }

    /// <summary>
    /// This is the number of calls that have been queued.
    /// </summary>
    [JsonPropertyName("callsCounterQueued")]
    public required double CallsCounterQueued { get; set; }

    /// <summary>
    /// This is the number of calls that have been in progress.
    /// </summary>
    [JsonPropertyName("callsCounterInProgress")]
    public required double CallsCounterInProgress { get; set; }

    /// <summary>
    /// This is the number of calls whose ended reason is 'voicemail'.
    /// </summary>
    [JsonPropertyName("callsCounterEndedVoicemail")]
    public required double CallsCounterEndedVoicemail { get; set; }

    /// <summary>
    /// This is the number of calls that have ended.
    /// </summary>
    [JsonPropertyName("callsCounterEnded")]
    public required double CallsCounterEnded { get; set; }

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
