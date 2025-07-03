using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record Campaign
{
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
    /// This is the assistant ID that will be used for the campaign calls. Note: Either assistantId or workflowId can be used, but not both.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public string? AssistantId { get; set; }

    /// <summary>
    /// This is the workflow ID that will be used for the campaign calls. Note: Either assistantId or workflowId can be used, but not both.
    /// </summary>
    [JsonPropertyName("workflowId")]
    public string? WorkflowId { get; set; }

    /// <summary>
    /// This is the phone number ID that will be used for the campaign calls.
    /// </summary>
    [JsonPropertyName("phoneNumberId")]
    public required string PhoneNumberId { get; set; }

    /// <summary>
    /// This is the schedule plan for the campaign.
    /// </summary>
    [JsonPropertyName("schedulePlan")]
    public SchedulePlan? SchedulePlan { get; set; }

    /// <summary>
    /// These are the customers that will be called in the campaign.
    /// </summary>
    [JsonPropertyName("customers")]
    public IEnumerable<CreateCustomerDto> Customers { get; set; } = new List<CreateCustomerDto>();

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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
