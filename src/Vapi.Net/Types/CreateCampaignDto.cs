using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Configuration used to create an outbound calling campaign. Choose an assistant, squad, or workflow, then provide customers, phone-number or dial-plan settings, and an optional schedule.
/// </summary>
[Serializable]
public record CreateCampaignDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
    /// These are the customers that will be called in the campaign. Required if dialPlan is not provided. Maximum of 10000 customers per campaign.
    /// </summary>
    [JsonPropertyName("customers")]
    public IEnumerable<CreateCustomerDto>? Customers { get; set; }

    /// <summary>
    /// This is the maximum number of concurrent calls that will be made for the campaign. Defaults to 10. Maximum of 500, and may not exceed your organization's concurrency limit.
    /// </summary>
    [JsonPropertyName("maxConcurrency")]
    public double? MaxConcurrency { get; set; }

    /// <summary>
    /// These are the overrides for the assistant's settings and template variables for the campaign. Use this when the campaign targets an `assistantId`.
    /// </summary>
    [JsonPropertyName("assistantOverrides")]
    public AssistantOverrides? AssistantOverrides { get; set; }

    /// <summary>
    /// These are the overrides for the squad and template variables for the campaign. Use this when the campaign targets a `squadId`. Per-contact `squadOverrides` are deep-merged on top of this at dispatch time.
    /// </summary>
    [JsonPropertyName("squadOverrides")]
    public AssistantOverrides? SquadOverrides { get; set; }

    /// <summary>
    /// This is the server (URL, auth headers, timeout, etc.) for the campaign webhooks.
    /// </summary>
    [JsonPropertyName("server")]
    public Server? Server { get; set; }

    /// <summary>
    /// These are the messages that will be sent to your Server URL.
    /// </summary>
    [JsonPropertyName("serverMessages")]
    public IEnumerable<CreateCampaignDtoServerMessagesItem>? ServerMessages { get; set; }

    /// <summary>
    /// This opts the campaign into the blocking `campaign.predial` eligibility webhook. When set, every contact triggers a `campaign.predial` POST to the Server URL before dialing, and the response `{ eligible: boolean }` decides whether the call is placed. Requires `server`. When unset, no pre-dial webhook is sent.
    /// </summary>
    [JsonPropertyName("predialPlan")]
    public CampaignPredialPlan? PredialPlan { get; set; }

    /// <summary>
    /// Optional campaign ID to duplicate config from. Provided fields in the request override the source. If `customers` is omitted, contacts are copied from the source.
    /// </summary>
    [JsonPropertyName("duplicateFromCampaignId")]
    public string? DuplicateFromCampaignId { get; set; }

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
