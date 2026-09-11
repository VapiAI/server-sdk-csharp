using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ToolVersion : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Optional human-readable label for this version. Pass `null` to clear.
    /// </summary>
    [JsonPropertyName("versionName")]
    public string? VersionName { get; set; }

    /// <summary>
    /// Optional description for this version. Pass `null` to clear.
    /// </summary>
    [JsonPropertyName("versionDescription")]
    public string? VersionDescription { get; set; }

    [JsonPropertyName("type")]
    public object? Type { get; set; }

    [JsonPropertyName("function")]
    public object? Function { get; set; }

    [JsonPropertyName("messages")]
    public IEnumerable<object>? Messages { get; set; }

    [JsonPropertyName("metadata")]
    public object? Metadata { get; set; }

    [JsonPropertyName("templateId")]
    public string? TemplateId { get; set; }

    [JsonPropertyName("server")]
    public Server? Server { get; set; }

    [JsonPropertyName("async")]
    public bool? Async { get; set; }

    [JsonPropertyName("destinations")]
    public IEnumerable<object>? Destinations { get; set; }

    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("subType")]
    public string? SubType { get; set; }

    [JsonPropertyName("displayWidthPx")]
    public double? DisplayWidthPx { get; set; }

    [JsonPropertyName("displayHeightPx")]
    public double? DisplayHeightPx { get; set; }

    [JsonPropertyName("displayNumber")]
    public double? DisplayNumber { get; set; }

    [JsonPropertyName("knowledgeBases")]
    public IEnumerable<object>? KnowledgeBases { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("method")]
    public string? Method { get; set; }

    [JsonPropertyName("headers")]
    public object? Headers { get; set; }

    [JsonPropertyName("body")]
    public object? Body { get; set; }

    [JsonPropertyName("backoffPlan")]
    public object? BackoffPlan { get; set; }

    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("variableExtractionPlan")]
    public object? VariableExtractionPlan { get; set; }

    [JsonPropertyName("rejectionPlan")]
    public object? RejectionPlan { get; set; }

    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    [JsonPropertyName("extendedDelayWhenPrecededByTextEnabled")]
    public bool? ExtendedDelayWhenPrecededByTextEnabled { get; set; }

    [JsonPropertyName("beepDetectionEnabled")]
    public bool? BeepDetectionEnabled { get; set; }

    [JsonPropertyName("code")]
    public string? Code { get; set; }

    [JsonPropertyName("environmentVariables")]
    public IEnumerable<object>? EnvironmentVariables { get; set; }

    [JsonPropertyName("parameters")]
    public IEnumerable<object>? Parameters { get; set; }

    [JsonPropertyName("encryptedPaths")]
    public IEnumerable<string>? EncryptedPaths { get; set; }

    [JsonPropertyName("sipInfoDtmfEnabled")]
    public bool? SipInfoDtmfEnabled { get; set; }

    [JsonPropertyName("verb")]
    public string? Verb { get; set; }

    [JsonPropertyName("defaultResult")]
    public string? DefaultResult { get; set; }

    [JsonPropertyName("toolMessages")]
    public IEnumerable<object>? ToolMessages { get; set; }

    /// <summary>
    /// This is the unique identifier for the version row.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the unique identifier for the org that owns this version.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// This is the unique identifier for the tool this version was snapshotted from.
    /// </summary>
    [JsonPropertyName("toolId")]
    public required string ToolId { get; set; }

    /// <summary>
    /// This is the public monotonic version label, e.g. "v1".
    /// System-owned and incremented per tool; never user-supplied.
    /// </summary>
    [JsonPropertyName("version")]
    public required string Version { get; set; }

    /// <summary>
    /// This is the SHA-256 hex of the snapshotted content used for no-op detection.
    /// </summary>
    [JsonPropertyName("configHash")]
    public required string ConfigHash { get; set; }

    /// <summary>
    /// This is the prior version label (vN-1). Null on v1 or for branch roots.
    /// </summary>
    [JsonPropertyName("parentVersion")]
    public string? ParentVersion { get; set; }

    /// <summary>
    /// This is the actor that wrote this version. Email when created via JWT, null when created via API.
    /// </summary>
    [JsonPropertyName("createdBy")]
    public string? CreatedBy { get; set; }

    /// <summary>
    /// This is the soft-delete timestamp. Null when active.
    /// </summary>
    [JsonPropertyName("deletedAt")]
    public DateTime? DeletedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the version was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

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
