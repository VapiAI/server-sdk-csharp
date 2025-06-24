using System.Text.Json.Serialization;
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
    /// This is the phone number ID that will be used for the campaign calls.
    /// Can only be updated if campaign is not in progress or has ended.
    /// </summary>
    [JsonPropertyName("phoneNumberId")]
    public string? PhoneNumberId { get; set; }

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
    public string? Status { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
