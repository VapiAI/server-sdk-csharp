using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record CreateCloudflareCredentialDto
{
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
    /// This is the bucket plan that can be provided to store call artifacts in R2
    /// </summary>
    [JsonPropertyName("bucketPlan")]
    public CloudflareR2BucketPlan? BucketPlan { get; set; }

    /// <summary>
    /// This is the name of credential. This is just for your reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
