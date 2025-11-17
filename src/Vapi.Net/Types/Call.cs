using System.Text.Json;
using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record Call
{
    /// <summary>
    /// This is the type of call.
    /// </summary>
    [JsonPropertyName("type")]
    public CallType? Type { get; set; }

    /// <summary>
    /// These are the costs of individual components of the call in USD.
    /// </summary>
    [JsonPropertyName("costs")]
    public IEnumerable<object>? Costs { get; set; }

    [JsonPropertyName("messages")]
    public IEnumerable<
        OneOf<UserMessage, SystemMessage, BotMessage, ToolCallMessage, ToolCallResultMessage>
    >? Messages { get; set; }

    /// <summary>
    /// This is the provider of the call.
    ///
    /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
    /// </summary>
    [JsonPropertyName("phoneCallProvider")]
    public CallPhoneCallProvider? PhoneCallProvider { get; set; }

    /// <summary>
    /// This is the transport of the phone call.
    ///
    /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
    /// </summary>
    [JsonPropertyName("phoneCallTransport")]
    public CallPhoneCallTransport? PhoneCallTransport { get; set; }

    /// <summary>
    /// This is the status of the call.
    /// </summary>
    [JsonPropertyName("status")]
    public CallStatus? Status { get; set; }

    /// <summary>
    /// This is the explanation for how the call ended.
    /// </summary>
    [JsonPropertyName("endedReason")]
    public CallEndedReason? EndedReason { get; set; }

    /// <summary>
    /// This is the destination where the call ended up being transferred to. If the call was not transferred, this will be empty.
    /// </summary>
    [JsonPropertyName("destination")]
    public object? Destination { get; set; }

    /// <summary>
    /// This is the unique identifier for the call.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the unique identifier for the org that this call belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the call was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the call was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the call was started.
    /// </summary>
    [JsonPropertyName("startedAt")]
    public DateTime? StartedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the call was ended.
    /// </summary>
    [JsonPropertyName("endedAt")]
    public DateTime? EndedAt { get; set; }

    /// <summary>
    /// This is the cost of the call in USD.
    /// </summary>
    [JsonPropertyName("cost")]
    public double? Cost { get; set; }

    /// <summary>
    /// This is the cost of the call in USD.
    /// </summary>
    [JsonPropertyName("costBreakdown")]
    public CostBreakdown? CostBreakdown { get; set; }

    /// <summary>
    /// This is a copy of assistant artifact plan. This isn't actually stored on the call but rather just returned in POST /call/web to enable artifact creation client side.
    /// </summary>
    [JsonPropertyName("artifactPlan")]
    public ArtifactPlan? ArtifactPlan { get; set; }

    /// <summary>
    /// This is the analysis of the call. Configure in `assistant.analysisPlan`.
    /// </summary>
    [JsonPropertyName("analysis")]
    public Analysis? Analysis { get; set; }

    /// <summary>
    /// This is to real-time monitor the call. Configure in `assistant.monitorPlan`.
    /// </summary>
    [JsonPropertyName("monitor")]
    public Monitor? Monitor { get; set; }

    /// <summary>
    /// These are the artifacts created from the call. Configure in `assistant.artifactPlan`.
    /// </summary>
    [JsonPropertyName("artifact")]
    public Artifact? Artifact { get; set; }

    /// <summary>
    /// This is the compliance of the call. Configure in `assistant.compliancePlan`.
    /// </summary>
    [JsonPropertyName("compliance")]
    public Compliance? Compliance { get; set; }

    /// <summary>
    /// The ID of the call as provided by the phone number service. callSid in Twilio. conversationUuid in Vonage. callControlId in Telnyx.
    ///
    /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
    /// </summary>
    [JsonPropertyName("phoneCallProviderId")]
    public string? PhoneCallProviderId { get; set; }

    /// <summary>
    /// This is the campaign ID that the call belongs to.
    /// </summary>
    [JsonPropertyName("campaignId")]
    public string? CampaignId { get; set; }

    /// <summary>
    /// This is the assistant ID that will be used for the call. To use a transient assistant, use `assistant` instead.
    ///
    /// To start a call with:
    /// - Assistant, use `assistantId` or `assistant`
    /// - Squad, use `squadId` or `squad`
    /// - Workflow, use `workflowId` or `workflow`
    /// </summary>
    [JsonPropertyName("assistantId")]
    public string? AssistantId { get; set; }

    /// <summary>
    /// This is the assistant that will be used for the call. To use an existing assistant, use `assistantId` instead.
    ///
    /// To start a call with:
    /// - Assistant, use `assistant`
    /// - Squad, use `squad`
    /// - Workflow, use `workflow`
    /// </summary>
    [JsonPropertyName("assistant")]
    public CreateAssistantDto? Assistant { get; set; }

    /// <summary>
    /// These are the overrides for the `assistant` or `assistantId`'s settings and template variables.
    /// </summary>
    [JsonPropertyName("assistantOverrides")]
    public AssistantOverrides? AssistantOverrides { get; set; }

    /// <summary>
    /// This is the squad that will be used for the call. To use a transient squad, use `squad` instead.
    ///
    /// To start a call with:
    /// - Assistant, use `assistant` or `assistantId`
    /// - Squad, use `squad` or `squadId`
    /// - Workflow, use `workflow` or `workflowId`
    /// </summary>
    [JsonPropertyName("squadId")]
    public string? SquadId { get; set; }

    /// <summary>
    /// This is a squad that will be used for the call. To use an existing squad, use `squadId` instead.
    ///
    /// To start a call with:
    /// - Assistant, use `assistant` or `assistantId`
    /// - Squad, use `squad` or `squadId`
    /// - Workflow, use `workflow` or `workflowId`
    /// </summary>
    [JsonPropertyName("squad")]
    public CreateSquadDto? Squad { get; set; }

    /// <summary>
    /// These are the overrides for the `squad` or `squadId`'s member settings and template variables.
    /// This will apply to all members of the squad.
    /// </summary>
    [JsonPropertyName("squadOverrides")]
    public AssistantOverrides? SquadOverrides { get; set; }

    /// <summary>
    /// This is the workflow that will be used for the call. To use a transient workflow, use `workflow` instead.
    ///
    /// To start a call with:
    /// - Assistant, use `assistant` or `assistantId`
    /// - Squad, use `squad` or `squadId`
    /// - Workflow, use `workflow` or `workflowId`
    /// </summary>
    [JsonPropertyName("workflowId")]
    public string? WorkflowId { get; set; }

    /// <summary>
    /// This is a workflow that will be used for the call. To use an existing workflow, use `workflowId` instead.
    ///
    /// To start a call with:
    /// - Assistant, use `assistant` or `assistantId`
    /// - Squad, use `squad` or `squadId`
    /// - Workflow, use `workflow` or `workflowId`
    /// </summary>
    [JsonPropertyName("workflow")]
    public CreateWorkflowDto? Workflow { get; set; }

    /// <summary>
    /// These are the overrides for the `workflow` or `workflowId`'s settings and template variables.
    /// </summary>
    [JsonPropertyName("workflowOverrides")]
    public WorkflowOverrides? WorkflowOverrides { get; set; }

    /// <summary>
    /// This is the phone number that will be used for the call. To use a transient number, use `phoneNumber` instead.
    ///
    /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
    /// </summary>
    [JsonPropertyName("phoneNumberId")]
    public string? PhoneNumberId { get; set; }

    /// <summary>
    /// This is the phone number that will be used for the call. To use an existing number, use `phoneNumberId` instead.
    ///
    /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
    /// </summary>
    [JsonPropertyName("phoneNumber")]
    public ImportTwilioPhoneNumberDto? PhoneNumber { get; set; }

    /// <summary>
    /// This is the customer that will be called. To call a transient customer , use `customer` instead.
    ///
    /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
    /// </summary>
    [JsonPropertyName("customerId")]
    public string? CustomerId { get; set; }

    /// <summary>
    /// This is the customer that will be called. To call an existing customer, use `customerId` instead.
    ///
    /// Only relevant for `outboundPhoneCall` and `inboundPhoneCall` type.
    /// </summary>
    [JsonPropertyName("customer")]
    public CreateCustomerDto? Customer { get; set; }

    /// <summary>
    /// This is the name of the call. This is just for your own reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the schedule plan of the call.
    /// </summary>
    [JsonPropertyName("schedulePlan")]
    public SchedulePlan? SchedulePlan { get; set; }

    /// <summary>
    /// This is the transport of the call.
    /// </summary>
    [JsonPropertyName("transport")]
    public object? Transport { get; set; }

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
