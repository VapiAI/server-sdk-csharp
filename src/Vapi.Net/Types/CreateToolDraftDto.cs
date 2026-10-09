using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateToolDraftDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Messages spoken while the tool is running. Multiple request-start messages are variants. For request-response-delayed, same timing means variants and different timings mean staged updates.
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<object>? Messages { get; set; }

    /// <summary>
    /// This is the type of the tool.
    /// </summary>
    [JsonPropertyName("type")]
    public CreateToolDraftDtoType? Type { get; set; }

    /// <summary>
    /// Optional pointer to the published version this draft was forked from.
    /// When omitted, defaults server-side to the parent tool's current
    /// `latestVersion` (lazy-created via `toolBaselineVersionEnsureInTx` if the
    /// tool has never been versioned). Immutable for the lifetime of the draft.
    /// </summary>
    [JsonPropertyName("baseVersion")]
    public string? BaseVersion { get; set; }

    /// <summary>
    /// This is the function definition of the tool.
    /// </summary>
    [JsonPropertyName("function")]
    public OpenAiFunction? Function { get; set; }

    /// <summary>
    /// Provider-specific metadata. Polymorphic across tool variants with no shared
    /// discriminator, so it is validated as a plain object (mirrors how
    /// `ToolCallResult.metadata` is typed).
    /// </summary>
    [JsonPropertyName("metadata")]
    public object? Metadata { get; set; }

    /// <summary>
    /// This is the unique identifier for the template this tool was created from.
    /// </summary>
    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }

    [JsonPropertyName("server")]
    public Server? Server { get; set; }

    [JsonPropertyName("async")]
    public bool? Async { get; set; }

    /// <summary>
    /// These are the destinations that the call can be transferred to.
    /// </summary>
    [JsonPropertyName("destinations")]
    public IEnumerable<object>? Destinations { get; set; }

    /// <summary>
    /// This is the name of the tool. This will be passed to the model.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the sub type of the tool (e.g. for computer, bash and text-editor tools).
    /// </summary>
    [JsonPropertyName("subType")]
    public string? SubType { get; set; }

    /// <summary>
    /// The display width in pixels (computer tool).
    /// </summary>
    [JsonPropertyName("displayWidthPx")]
    public double? DisplayWidthPx { get; set; }

    /// <summary>
    /// The display height in pixels (computer tool).
    /// </summary>
    [JsonPropertyName("displayHeightPx")]
    public double? DisplayHeightPx { get; set; }

    /// <summary>
    /// Optional display number (computer tool).
    /// </summary>
    [JsonPropertyName("displayNumber")]
    public double? DisplayNumber { get; set; }

    /// <summary>
    /// The knowledge bases to query (query tool).
    /// </summary>
    [JsonPropertyName("knowledgeBases")]
    public IEnumerable<KnowledgeBase>? KnowledgeBases { get; set; }

    /// <summary>
    /// This is where the request will be sent (api-request tool).
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// This is the HTTP method for the request (api-request tool).
    /// </summary>
    [JsonPropertyName("method")]
    public CreateToolDraftDtoMethod? Method { get; set; }

    /// <summary>
    /// These are the headers to send with the request (api-request / sip-request tool).
    /// </summary>
    [JsonPropertyName("headers")]
    public JsonSchema? Headers { get; set; }

    /// <summary>
    /// This is the body of the request. Either a JSON schema (api-request) or a
    /// literal string / schema (sip-request).
    /// </summary>
    [JsonPropertyName("body")]
    public object? Body { get; set; }

    /// <summary>
    /// This is the backoff plan if the request fails.
    /// </summary>
    [JsonPropertyName("backoffPlan")]
    public BackoffPlan? BackoffPlan { get; set; }

    /// <summary>
    /// This is the timeout in seconds for the request.
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>
    /// This is the description of the tool. This will be passed to the model.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// This is the plan to extract variables from the tool's response.
    /// </summary>
    [JsonPropertyName("variableExtractionPlan")]
    public VariableExtractionPlan? VariableExtractionPlan { get; set; }

    /// <summary>
    /// This is the credential ID that will be used for authorization.
    /// </summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    [JsonPropertyName("extendedDelayWhenPrecededByTextEnabled")]
    public bool? ExtendedDelayWhenPrecededByTextEnabled { get; set; }

    [JsonPropertyName("beepDetectionEnabled")]
    public bool? BeepDetectionEnabled { get; set; }

    /// <summary>
    /// This is the TypeScript code that will be executed when the tool is called (code tool).
    /// </summary>
    [JsonPropertyName("code")]
    public string? Code { get; set; }

    /// <summary>
    /// These are the environment variables available in the code via the `env` object (code tool).
    /// </summary>
    [JsonPropertyName("environmentVariables")]
    public IEnumerable<CodeToolEnvironmentVariable>? EnvironmentVariables { get; set; }

    /// <summary>
    /// These are the static parameters to merge into the tool's request body.
    /// </summary>
    [JsonPropertyName("parameters")]
    public IEnumerable<ToolParameter>? Parameters { get; set; }

    /// <summary>
    /// This is the paths to encrypt in the request body.
    /// </summary>
    [JsonPropertyName("encryptedPaths")]
    public IEnumerable<string>? EncryptedPaths { get; set; }

    /// <summary>
    /// This enables sending DTMF tones via SIP INFO messages instead of RFC 2833.
    /// </summary>
    [JsonPropertyName("sipInfoDtmfEnabled")]
    public bool? SipInfoDtmfEnabled { get; set; }

    /// <summary>
    /// This is the SIP method to send (sip-request tool).
    /// </summary>
    [JsonPropertyName("verb")]
    public CreateToolDraftDtoVerb? Verb { get; set; }

    /// <summary>
    /// This is the default local tool result message used when no runtime override is returned (handoff tool).
    /// </summary>
    [JsonPropertyName("defaultResult")]
    public string? DefaultResult { get; set; }

    /// <summary>
    /// Per-tool message overrides for individual tools loaded from the MCP server (mcp tool).
    /// </summary>
    [JsonPropertyName("toolMessages")]
    public IEnumerable<McpToolMessages>? ToolMessages { get; set; }

    /// <summary>
    /// This is the plan to reject a tool call based on the conversation state.
    ///
    /// // Example 1: Reject endCall if user didn't say goodbye
    /// ```json
    /// {
    ///   conditions: [{
    ///     type: 'regex',
    ///     regex: '(?i)\\b(bye|goodbye|farewell|see you later|take care)\\b',
    ///     target: { position: -1, role: 'user' },
    ///     negate: true  // Reject if pattern does NOT match
    ///   }]
    /// }
    /// ```
    ///
    /// // Example 2: Reject transfer if user is actually asking a question
    /// ```json
    /// {
    ///   conditions: [{
    ///     type: 'regex',
    ///     regex: '\\?',
    ///     target: { position: -1, role: 'user' }
    ///   }]
    /// }
    /// ```
    ///
    /// // Example 3: Reject transfer if user didn't mention transfer recently
    /// ```json
    /// {
    ///   conditions: [{
    ///     type: 'liquid',
    ///     liquid: `{% assign recentMessages = messages | last: 5 %}
    /// {% assign userMessages = recentMessages | where: 'role', 'user' %}
    /// {% assign mentioned = false %}
    /// {% for msg in userMessages %}
    ///   {% if msg.content contains 'transfer' or msg.content contains 'connect' or msg.content contains 'speak to' %}
    ///     {% assign mentioned = true %}
    ///     {% break %}
    ///   {% endif %}
    /// {% endfor %}
    /// {% if mentioned %}
    ///   false
    /// {% else %}
    ///   true
    /// {% endif %}`
    ///   }]
    /// }
    /// ```
    ///
    /// // Example 4: Reject endCall if the bot is looping and trying to exit
    /// ```json
    /// {
    ///   conditions: [{
    ///     type: 'liquid',
    ///     liquid: `{% assign recentMessages = messages | last: 6 %}
    /// {% assign userMessages = recentMessages | where: 'role', 'user' | reverse %}
    /// {% if userMessages.size &lt; 3 %}
    ///   false
    /// {% else %}
    ///   {% assign msg1 = userMessages[0].content | downcase %}
    ///   {% assign msg2 = userMessages[1].content | downcase %}
    ///   {% assign msg3 = userMessages[2].content | downcase %}
    ///   {% comment %} Check for repetitive messages {% endcomment %}
    ///   {% if msg1 == msg2 or msg1 == msg3 or msg2 == msg3 %}
    ///     true
    ///   {% comment %} Check for common loop phrases {% endcomment %}
    ///   {% elsif msg1 contains 'cool thanks' or msg2 contains 'cool thanks' or msg3 contains 'cool thanks' %}
    ///     true
    ///   {% elsif msg1 contains 'okay thanks' or msg2 contains 'okay thanks' or msg3 contains 'okay thanks' %}
    ///     true
    ///   {% elsif msg1 contains 'got it' or msg2 contains 'got it' or msg3 contains 'got it' %}
    ///     true
    ///   {% else %}
    ///     false
    ///   {% endif %}
    /// {% endif %}`
    ///   }]
    /// }
    /// ```
    /// </summary>
    [JsonPropertyName("rejectionPlan")]
    public ToolRejectionPlan? RejectionPlan { get; set; }

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
