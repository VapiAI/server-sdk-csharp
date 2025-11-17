using System.Text.Json;
using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record Artifact
{
    /// <summary>
    /// These are the messages that were spoken during the call.
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<
        OneOf<UserMessage, SystemMessage, BotMessage, ToolCallMessage, ToolCallResultMessage>
    >? Messages { get; set; }

    /// <summary>
    /// These are the messages that were spoken during the call, formatted for OpenAI.
    /// </summary>
    [JsonPropertyName("messagesOpenAIFormatted")]
    public IEnumerable<OpenAiMessage>? MessagesOpenAiFormatted { get; set; }

    /// <summary>
    /// This is the recording url for the call. To enable, set `assistant.artifactPlan.recordingEnabled`.
    /// </summary>
    [JsonPropertyName("recordingUrl")]
    public string? RecordingUrl { get; set; }

    /// <summary>
    /// This is the stereo recording url for the call. To enable, set `assistant.artifactPlan.recordingEnabled`.
    /// </summary>
    [JsonPropertyName("stereoRecordingUrl")]
    public string? StereoRecordingUrl { get; set; }

    /// <summary>
    /// This is video recording url for the call. To enable, set `assistant.artifactPlan.videoRecordingEnabled`.
    /// </summary>
    [JsonPropertyName("videoRecordingUrl")]
    public string? VideoRecordingUrl { get; set; }

    /// <summary>
    /// This is video recording start delay in ms. To enable, set `assistant.artifactPlan.videoRecordingEnabled`. This can be used to align the playback of the recording with artifact.messages timestamps.
    /// </summary>
    [JsonPropertyName("videoRecordingStartDelaySeconds")]
    public double? VideoRecordingStartDelaySeconds { get; set; }

    /// <summary>
    /// This is the recording url for the call. To enable, set `assistant.artifactPlan.recordingEnabled`.
    /// </summary>
    [JsonPropertyName("recording")]
    public Recording? Recording { get; set; }

    /// <summary>
    /// This is the transcript of the call. This is derived from `artifact.messages` but provided for convenience.
    /// </summary>
    [JsonPropertyName("transcript")]
    public string? Transcript { get; set; }

    /// <summary>
    /// This is the packet capture url for the call. This is only available for `phone` type calls where phone number's provider is `vapi` or `byo-phone-number`.
    /// </summary>
    [JsonPropertyName("pcapUrl")]
    public string? PcapUrl { get; set; }

    /// <summary>
    /// This is the url for the call logs. This includes all logging output during the call for debugging purposes.
    /// </summary>
    [JsonPropertyName("logUrl")]
    public string? LogUrl { get; set; }

    /// <summary>
    /// This is the history of workflow nodes that were executed during the call.
    /// </summary>
    [JsonPropertyName("nodes")]
    public IEnumerable<NodeArtifact>? Nodes { get; set; }

    /// <summary>
    /// These are the variable values at the end of the workflow execution.
    /// </summary>
    [JsonPropertyName("variableValues")]
    public object? VariableValues { get; set; }

    /// <summary>
    /// This is the performance metrics for the call. It contains the turn latency, broken down by component.
    /// </summary>
    [JsonPropertyName("performanceMetrics")]
    public PerformanceMetrics? PerformanceMetrics { get; set; }

    /// <summary>
    /// These are the structured outputs that will be extracted from the call.
    /// To enable, set `assistant.artifactPlan.structuredOutputIds` with the IDs of the structured outputs you want to extract.
    /// </summary>
    [JsonPropertyName("structuredOutputs")]
    public object? StructuredOutputs { get; set; }

    /// <summary>
    /// These are the scorecards that have been evaluated based on the structured outputs extracted during the call.
    /// To enable, set `assistant.artifactPlan.scorecardIds` or `assistant.artifactPlan.scorecards` with the IDs or objects of the scorecards you want to evaluate.
    /// </summary>
    [JsonPropertyName("scorecards")]
    public object? Scorecards { get; set; }

    /// <summary>
    /// These are the transfer records from warm transfers, including destinations, transcripts, and status.
    /// </summary>
    [JsonPropertyName("transfers")]
    public IEnumerable<string>? Transfers { get; set; }

    /// <summary>
    /// This is when the structured outputs were last updated
    /// </summary>
    [JsonPropertyName("structuredOutputsLastUpdatedAt")]
    public DateTime? StructuredOutputsLastUpdatedAt { get; set; }

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
