using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AnthropicBedrockCredential : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("provider")]
    public required AnthropicBedrockCredentialProvider Provider { get; set; }

    /// <summary>
    /// AWS region where Bedrock is configured.
    /// </summary>
    [JsonPropertyName("region")]
    public required AnthropicBedrockCredentialRegion Region { get; set; }

    /// <summary>
    /// Authentication method - either direct IAM credentials or cross-account role assumption.
    /// </summary>
    [JsonPropertyName("authenticationPlan")]
    public required object AuthenticationPlan { get; set; }

    /// <summary>
    /// This is the unique identifier for the credential.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the unique identifier for the org that this credential belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the credential was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the assistant was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// Stores the external ID (generated or user-provided) for future AssumeRole calls.
    /// </summary>
    [JsonPropertyName("authenticationArtifact")]
    public AwsStsAuthenticationArtifact? AuthenticationArtifact { get; set; }

    /// <summary>
    /// Cached authentication session from AssumeRole (temporary credentials).
    /// Managed by the system, auto-refreshed when expired.
    /// </summary>
    [JsonPropertyName("authenticationSession")]
    public AwsStsAuthenticationSession? AuthenticationSession { get; set; }

    /// <summary>
    /// This is the name of credential. This is just for your reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
