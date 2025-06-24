using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateCampaignDto
{
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
    public required SchedulePlan SchedulePlan { get; set; }

    /// <summary>
    /// These are the customers that will be called in the campaign.
    /// </summary>
    [JsonPropertyName("customers")]
    public IEnumerable<CreateCustomerDto> Customers { get; set; } = new List<CreateCustomerDto>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
