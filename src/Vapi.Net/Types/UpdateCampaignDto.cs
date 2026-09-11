using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Fields used to update an outbound calling campaign, including its name, status, calling resource, phone-number or dial-plan settings, and schedule.
/// </summary>
[Serializable]
public record UpdateCampaignDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
    /// Set to 'cancelled' to stop the campaign ('ended' is a V1 alias). Scheduled
    /// calls are deleted; in-progress calls are allowed to finish.
    /// </summary>
    [JsonPropertyName("status")]
    public UpdateCampaignDtoStatus? Status { get; set; }

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
