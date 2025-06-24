using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ServerMessageResponseAssistantRequest
{
    /// <summary>
    /// This is the destination to transfer the inbound call to. This will immediately transfer without using any assistants.
    ///
    /// If this is sent, `assistantId`, `assistant`, `squadId`, and `squad` are ignored.
    /// </summary>
    [JsonPropertyName("destination")]
    public object? Destination { get; set; }

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
    /// This is the error if the call shouldn't be accepted. This is spoken to the customer.
    ///
    /// If this is sent, `assistantId`, `assistant`, `squadId`, `squad`, and `destination` are ignored.
    /// </summary>
    [JsonPropertyName("error")]
    public string? Error { get; set; }

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
