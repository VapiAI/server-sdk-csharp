using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record AzureCredential
{
    [JsonPropertyName("provider")]
    public string Provider { get; set; } = "azure";

    /// <summary>
    /// This is the service being used in Azure.
    /// </summary>
    [JsonPropertyName("service")]
    public required AzureCredentialService Service { get; set; }

    /// <summary>
    /// This is the region of the Azure resource.
    /// </summary>
    [JsonPropertyName("region")]
    public AzureCredentialRegion? Region { get; set; }

    /// <summary>
    /// This is not returned in the API.
    /// </summary>
    [JsonPropertyName("apiKey")]
    public string? ApiKey { get; set; }

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
    /// This is the bucket plan that can be provided to store call artifacts in Azure Blob Storage.
    /// </summary>
    [JsonPropertyName("bucketPlan")]
    public AzureBlobStorageBucketPlan? BucketPlan { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
