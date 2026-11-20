using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateWebCallDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the assistant version to use for this call. Supported only with
    /// direct `assistantId`. Omit to follow the latest version.
    /// </summary>
    [JsonPropertyName("assistantVersion")]
    public string? AssistantVersion { get; set; }

    /// <summary>
    /// This is the squad version to use for this call. Supported only with
    /// direct `squadId`. Omit to follow the latest version.
    /// </summary>
    [JsonPropertyName("squadVersion")]
    public string? SquadVersion { get; set; }

    [JsonPropertyName("roomDeleteOnUserLeaveEnabled")]
    public bool? RoomDeleteOnUserLeaveEnabled { get; set; }

    /// <summary>
    /// This determines who starts the video recording. Only applies when video
    /// recording is enabled (`artifactPlan.videoRecordingEnabled`).
    ///
    /// - `client`: the web client starts the recording when it joins.
    /// - `server`: Vapi starts the recording once when the user first joins, so a
    ///   weak client connection can't stop it from starting. The returned
    ///   `transport.callToken` doesn't start the recording, and the client should
    ///   not start it either. If Vapi can't set up the server-side start, no token
    ///   is returned. If the start itself fails, the client is told during the
    ///   call.
    ///
    /// Defaults to `client`.
    /// </summary>
    [JsonPropertyName("videoRecordingStartMode")]
    public CreateWebCallDtoVideoRecordingStartMode? VideoRecordingStartMode { get; set; }

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
    public TransientAssistantDto? Assistant { get; set; }

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
