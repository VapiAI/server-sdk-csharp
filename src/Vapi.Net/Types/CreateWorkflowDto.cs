using System.Text.Json;
using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateWorkflowDto
{
    [JsonPropertyName("nodes")]
    public IEnumerable<object> Nodes { get; set; } = new List<object>();

    /// <summary>
    /// This is the transcriber for the workflow.
    ///
    /// This can be overridden at node level using `nodes[n].transcriber`.
    /// </summary>
    [JsonPropertyName("transcriber")]
    public object? Transcriber { get; set; }

    /// <summary>
    /// This is the voice for the workflow.
    ///
    /// This can be overridden at node level using `nodes[n].voice`.
    /// </summary>
    [JsonPropertyName("voice")]
    public object? Voice { get; set; }

    /// <summary>
    /// This is the plan for observability of workflow's calls.
    ///
    /// Currently, only Langfuse is supported.
    /// </summary>
    [JsonPropertyName("observabilityPlan")]
    public LangfuseObservabilityPlan? ObservabilityPlan { get; set; }

    /// <summary>
    /// This is the background sound in the call. Default for phone calls is 'office' and default for web calls is 'off'.
    /// You can also provide a custom sound by providing a URL to an audio file.
    /// </summary>
    [JsonPropertyName("backgroundSound")]
    public OneOf<CreateWorkflowDtoBackgroundSoundZero, string>? BackgroundSound { get; set; }

    /// <summary>
    /// These are dynamic credentials that will be used for the workflow calls. By default, all the credentials are available for use in the call but you can supplement an additional credentials using this. Dynamic credentials override existing credentials.
    /// </summary>
    [JsonPropertyName("credentials")]
    public IEnumerable<object>? Credentials { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("edges")]
    public IEnumerable<Edge> Edges { get; set; } = new List<Edge>();

    [JsonPropertyName("globalPrompt")]
    public string? GlobalPrompt { get; set; }

    /// <summary>
    /// This is where Vapi will send webhooks. You can find all webhooks available along with their shape in ServerMessage schema.
    ///
    /// The order of precedence is:
    ///
    /// 1. tool.server
    /// 2. workflow.server / assistant.server
    /// 3. phoneNumber.server
    /// 4. org.server
    /// </summary>
    [JsonPropertyName("server")]
    public Server? Server { get; set; }

    /// <summary>
    /// This is the compliance plan for the workflow. It allows you to configure HIPAA and other compliance settings.
    /// </summary>
    [JsonPropertyName("compliancePlan")]
    public CompliancePlan? CompliancePlan { get; set; }

    /// <summary>
    /// This is the plan for analysis of workflow's calls. Stored in `call.analysis`.
    /// </summary>
    [JsonPropertyName("analysisPlan")]
    public AnalysisPlan? AnalysisPlan { get; set; }

    /// <summary>
    /// This is the plan for artifacts generated during workflow's calls. Stored in `call.artifact`.
    /// </summary>
    [JsonPropertyName("artifactPlan")]
    public ArtifactPlan? ArtifactPlan { get; set; }

    /// <summary>
    /// This is the plan for when the workflow nodes should start talking.
    ///
    /// You should configure this if you're running into these issues:
    /// - The assistant is too slow to start talking after the customer is done speaking.
    /// - The assistant is too fast to start talking after the customer is done speaking.
    /// - The assistant is so fast that it's actually interrupting the customer.
    /// </summary>
    [JsonPropertyName("startSpeakingPlan")]
    public StartSpeakingPlan? StartSpeakingPlan { get; set; }

    /// <summary>
    /// This is the plan for when workflow nodes should stop talking on customer interruption.
    ///
    /// You should configure this if you're running into these issues:
    /// - The assistant is too slow to recognize customer's interruption.
    /// - The assistant is too fast to recognize customer's interruption.
    /// - The assistant is getting interrupted by phrases that are just acknowledgments.
    /// - The assistant is getting interrupted by background noises.
    /// - The assistant is not properly stopping -- it starts talking right after getting interrupted.
    /// </summary>
    [JsonPropertyName("stopSpeakingPlan")]
    public StopSpeakingPlan? StopSpeakingPlan { get; set; }

    /// <summary>
    /// This is the plan for real-time monitoring of the workflow's calls.
    ///
    /// Usage:
    /// - To enable live listening of the workflow's calls, set `monitorPlan.listenEnabled` to `true`.
    /// - To enable live control of the workflow's calls, set `monitorPlan.controlEnabled` to `true`.
    /// </summary>
    [JsonPropertyName("monitorPlan")]
    public MonitorPlan? MonitorPlan { get; set; }

    /// <summary>
    /// This enables filtering of noise and background speech while the user is talking.
    ///
    /// Features:
    /// - Smart denoising using Krisp
    /// - Fourier denoising
    ///
    /// Both can be used together. Order of precedence:
    /// - Smart denoising
    /// - Fourier denoising
    /// </summary>
    [JsonPropertyName("backgroundSpeechDenoisingPlan")]
    public BackgroundSpeechDenoisingPlan? BackgroundSpeechDenoisingPlan { get; set; }

    /// <summary>
    /// These are the credentials that will be used for the workflow calls. By default, all the credentials are available for use in the call but you can provide a subset using this.
    /// </summary>
    [JsonPropertyName("credentialIds")]
    public IEnumerable<string>? CredentialIds { get; set; }

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
