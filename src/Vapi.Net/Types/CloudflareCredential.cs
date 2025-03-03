using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record CloudflareCredential
{
    /// <summary>
    /// Credential provider. Only allowed value is cloudflare
    /// </summary>
    [JsonPropertyName("provider")]
    public string Provider { get; set; } = "cloudflare";

    /// <summary>
    /// Cloudflare Account Id.
    /// </summary>
    [JsonPropertyName("accountId")]
    public string? AccountId { get; set; }

    /// <summary>
    /// Cloudflare API Key / Token.
    /// </summary>
    [JsonPropertyName("apiKey")]
    public string? ApiKey { get; set; }

    /// <summary>
    /// Cloudflare Account Email.
    /// </summary>
    [JsonPropertyName("accountEmail")]
    public string? AccountEmail { get; set; }

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
    /// This is the name of credential. This is just for your reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the bucket plan that can be provided to store call artifacts in R2
    /// </summary>
    [JsonPropertyName("bucketPlan")]
    public CloudflareR2BucketPlan? BucketPlan { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
