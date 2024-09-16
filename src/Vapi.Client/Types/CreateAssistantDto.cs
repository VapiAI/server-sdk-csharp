using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record CreateAssistantDto
{
    /// <summary>
    /// These are the options for the assistant's transcriber.
    /// </summary>
    [JsonPropertyName("transcriber")]
    public object? Transcriber { get; set; }

    /// <summary>
    /// These are the options for the assistant's LLM.
    /// </summary>
    [JsonPropertyName("model")]
    public object? Model { get; set; }

    /// <summary>
    /// These are the options for the assistant's voice.
    /// </summary>
    [JsonPropertyName("voice")]
    public object? Voice { get; set; }

    /// <summary>
    /// This is the mode for the first message. Default is 'assistant-speaks-first'.
    ///
    /// Use:
    ///
    /// - 'assistant-speaks-first' to have the assistant speak first.
    /// - 'assistant-waits-for-user' to have the assistant wait for the user to speak first.
    /// - 'assistant-speaks-first-with-model-generated-message' to have the assistant speak first with a message generated by the model based on the conversation state. (`assistant.model.messages` at call start, `call.messages` at squad transfer points).
    ///
    /// @default 'assistant-speaks-first'
    /// </summary>
    [JsonPropertyName("firstMessageMode")]
    public CreateAssistantDtoFirstMessageMode? FirstMessageMode { get; set; }

    /// <summary>
    /// When this is enabled, no logs, recordings, or transcriptions will be stored. At the end of the call, you will still receive an end-of-call-report message to store on your server. Defaults to false.
    /// </summary>
    [JsonPropertyName("hipaaEnabled")]
    public bool? HipaaEnabled { get; set; }

    /// <summary>
    /// These are the messages that will be sent to your Client SDKs. Default is conversation-update,function-call,hang,model-output,speech-update,status-update,transcript,tool-calls,user-interrupted,voice-input. You can check the shape of the messages in ClientMessage schema.
    /// </summary>
    [JsonPropertyName("clientMessages")]
    public IEnumerable<CreateAssistantDtoClientMessagesItem>? ClientMessages { get; set; }

    /// <summary>
    /// These are the messages that will be sent to your Server URL. Default is conversation-update,end-of-call-report,function-call,hang,speech-update,status-update,tool-calls,transfer-destination-request,user-interrupted. You can check the shape of the messages in ServerMessage schema.
    /// </summary>
    [JsonPropertyName("serverMessages")]
    public IEnumerable<CreateAssistantDtoServerMessagesItem>? ServerMessages { get; set; }

    /// <summary>
    /// How many seconds of silence to wait before ending the call. Defaults to 30.
    ///
    /// @default 30
    /// </summary>
    [JsonPropertyName("silenceTimeoutSeconds")]
    public double? SilenceTimeoutSeconds { get; set; }

    /// <summary>
    /// This is the maximum number of seconds that the call will last. When the call reaches this duration, it will be ended.
    ///
    /// @default 600 (10 minutes)
    /// </summary>
    [JsonPropertyName("maxDurationSeconds")]
    public double? MaxDurationSeconds { get; set; }

    /// <summary>
    /// This is the background sound in the call. Default for phone calls is 'office' and default for web calls is 'off'.
    /// </summary>
    [JsonPropertyName("backgroundSound")]
    public CreateAssistantDtoBackgroundSound? BackgroundSound { get; set; }

    /// <summary>
    /// This determines whether the model says 'mhmm', 'ahem' etc. while user is speaking.
    ///
    /// Default `false` while in beta.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("backchannelingEnabled")]
    public bool? BackchannelingEnabled { get; set; }

    /// <summary>
    /// This enables filtering of noise and background speech while the user is talking.
    ///
    /// Default `false` while in beta.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("backgroundDenoisingEnabled")]
    public bool? BackgroundDenoisingEnabled { get; set; }

    /// <summary>
    /// This determines whether the model's output is used in conversation history rather than the transcription of assistant's speech.
    ///
    /// Default `false` while in beta.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("modelOutputInMessagesEnabled")]
    public bool? ModelOutputInMessagesEnabled { get; set; }

    /// <summary>
    /// These are the configurations to be passed to the transport providers of assistant's calls, like Twilio. You can store multiple configurations for different transport providers. For a call, only the configuration matching the call transport provider is used.
    /// </summary>
    [JsonPropertyName("transportConfigurations")]
    public IEnumerable<TransportConfigurationTwilio>? TransportConfigurations { get; set; }

    /// <summary>
    /// This is the name of the assistant.
    ///
    /// This is required when you want to transfer between assistants in a call.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the first message that the assistant will say. This can also be a URL to a containerized audio file (mp3, wav, etc.).
    ///
    /// If unspecified, assistant will wait for user to speak and use the model to respond once they speak.
    /// </summary>
    [JsonPropertyName("firstMessage")]
    public string? FirstMessage { get; set; }

    /// <summary>
    /// These are the settings to configure or disable voicemail detection. Alternatively, voicemail detection can be configured using the model.tools=[VoicemailTool].
    /// This uses Twilio's built-in detection while the VoicemailTool relies on the model to detect if a voicemail was reached.
    /// You can use neither of them, one of them, or both of them. By default, Twilio built-in detection is enabled while VoicemailTool is not.
    /// </summary>
    [JsonPropertyName("voicemailDetection")]
    public TwilioVoicemailDetection? VoicemailDetection { get; set; }

    /// <summary>
    /// This is the message that the assistant will say if the call is forwarded to voicemail.
    ///
    /// If unspecified, it will hang up.
    /// </summary>
    [JsonPropertyName("voicemailMessage")]
    public string? VoicemailMessage { get; set; }

    /// <summary>
    /// This is the message that the assistant will say if it ends the call.
    ///
    /// If unspecified, it will hang up without saying anything.
    /// </summary>
    [JsonPropertyName("endCallMessage")]
    public string? EndCallMessage { get; set; }

    /// <summary>
    /// This list contains phrases that, if spoken by the assistant, will trigger the call to be hung up. Case insensitive.
    /// </summary>
    [JsonPropertyName("endCallPhrases")]
    public IEnumerable<string>? EndCallPhrases { get; set; }

    /// <summary>
    /// This is for metadata you want to store on the assistant.
    /// </summary>
    [JsonPropertyName("metadata")]
    public object? Metadata { get; set; }

    /// <summary>
    /// This is the URL Vapi will communicate with via HTTP GET and POST Requests. This is used for retrieving context, function calling, and end-of-call reports.
    ///
    /// All requests will be sent with the call object among other things relevant to that message. You can find more details in the Server URL documentation.
    ///
    /// This overrides the serverUrl set on the org and the phoneNumber. Order of precedence: tool.server.url > assistant.serverUrl > phoneNumber.serverUrl > org.serverUrl
    /// </summary>
    [JsonPropertyName("serverUrl")]
    public string? ServerUrl { get; set; }

    /// <summary>
    /// This is the secret you can set that Vapi will send with every request to your server. Will be sent as a header called x-vapi-secret.
    ///
    /// Same precedence logic as serverUrl.
    /// </summary>
    [JsonPropertyName("serverUrlSecret")]
    public string? ServerUrlSecret { get; set; }

    /// <summary>
    /// This is the plan for analysis of assistant's calls. Stored in `call.analysis`.
    /// </summary>
    [JsonPropertyName("analysisPlan")]
    public AnalysisPlan? AnalysisPlan { get; set; }

    /// <summary>
    /// This is the plan for artifacts generated during assistant's calls. Stored in `call.artifact`.
    ///
    /// Note: `recordingEnabled` is currently at the root level. It will be moved to `artifactPlan` in the future, but will remain backwards compatible.
    /// </summary>
    [JsonPropertyName("artifactPlan")]
    public ArtifactPlan? ArtifactPlan { get; set; }

    /// <summary>
    /// This is the plan for static predefined messages that can be spoken by the assistant during the call, like `idleMessages`.
    ///
    /// Note: `firstMessage`, `voicemailMessage`, and `endCallMessage` are currently at the root level. They will be moved to `messagePlan` in the future, but will remain backwards compatible.
    /// </summary>
    [JsonPropertyName("messagePlan")]
    public MessagePlan? MessagePlan { get; set; }

    /// <summary>
    /// This is the plan for when the assistant should start talking.
    ///
    /// You should configure this if you're running into these issues:
    ///
    /// - The assistant is too slow to start talking after the customer is done speaking.
    /// - The assistant is too fast to start talking after the customer is done speaking.
    /// - The assistant is so fast that it's actually interrupting the customer.
    /// </summary>
    [JsonPropertyName("startSpeakingPlan")]
    public StartSpeakingPlan? StartSpeakingPlan { get; set; }

    /// <summary>
    /// This is the plan for when assistant should stop talking on customer interruption.
    ///
    /// You should configure this if you're running into these issues:
    ///
    /// - The assistant is too slow to recognize customer's interruption.
    /// - The assistant is too fast to recognize customer's interruption.
    /// - The assistant is getting interrupted by phrases that are just acknowledgments.
    /// - The assistant is getting interrupted by background noises.
    /// - The assistant is not properly stopping -- it starts talking right after getting interrupted.
    /// </summary>
    [JsonPropertyName("stopSpeakingPlan")]
    public StopSpeakingPlan? StopSpeakingPlan { get; set; }

    /// <summary>
    /// This is the plan for real-time monitoring of the assistant's calls.
    ///
    /// Usage:
    ///
    /// - To enable live listening of the assistant's calls, set `monitorPlan.listenEnabled` to `true`.
    /// - To enable live control of the assistant's calls, set `monitorPlan.controlEnabled` to `true`.
    ///
    /// Note, `serverMessages`, `clientMessages`, `serverUrl` and `serverUrlSecret` are currently at the root level but will be moved to `monitorPlan` in the future. Will remain backwards compatible
    /// </summary>
    [JsonPropertyName("monitorPlan")]
    public MonitorPlan? MonitorPlan { get; set; }

    /// <summary>
    /// These are the credentials that will be used for the assistant calls. By default, all the credentials are available for use in the call but you can provide a subset using this.
    /// </summary>
    [JsonPropertyName("credentialIds")]
    public IEnumerable<string>? CredentialIds { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
