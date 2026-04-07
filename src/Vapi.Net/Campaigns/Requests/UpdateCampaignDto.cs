using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record UpdateCampaignDto
{
    /// <summary>
    /// This is the name of the campaign. This is just for your own reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the assistant ID that will be used for the campaign calls.
    /// Can only be updated if campaign is not in progress or has ended.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public string? AssistantId { get; set; }

    /// <summary>
    /// This is the workflow ID that will be used for the campaign calls.
    /// Can only be updated if campaign is not in progress or has ended.
    /// </summary>
    [JsonPropertyName("workflowId")]
    public string? WorkflowId { get; set; }

    /// <summary>
    /// This is the squad ID that will be used for the campaign calls.
    /// Can only be updated if campaign is not in progress or has ended.
    /// </summary>
    [JsonPropertyName("squadId")]
    public string? SquadId { get; set; }

    /// <summary>
    /// This is the phone number ID that will be used for the campaign calls.
    /// Can only be updated if campaign is not in progress or has ended.
    /// Note: `phoneNumberId` and `dialPlan` are mutually exclusive.
    /// </summary>
    [JsonPropertyName("phoneNumberId")]
    public string? PhoneNumberId { get; set; }

    /// <summary>
    /// This is a list of dial entries, each specifying a phone number and the customers to call using that number. Can only be updated if campaign is not in progress or has ended. Note: phoneNumberId and dialPlan are mutually exclusive.
    /// </summary>
    [JsonPropertyName("dialPlan")]
    public IEnumerable<DialPlanEntry>? DialPlan { get; set; }

    /// <summary>
    /// This is the schedule plan for the campaign.
    /// Can only be updated if campaign is not in progress or has ended.
    /// </summary>
    [JsonPropertyName("schedulePlan")]
    public SchedulePlan? SchedulePlan { get; set; }

    /// <summary>
    /// This is the status of the campaign.
    /// Can only be updated to 'ended' if you want to end the campaign.
    /// When set to 'ended', it will delete all scheduled calls. Calls in progress will be allowed to complete.
    /// </summary>
    [JsonPropertyName("status")]
    public UpdateCampaignDtoStatus? Status { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
