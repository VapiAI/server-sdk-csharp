using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record GcpCredential
{
    [JsonPropertyName("provider")]
    public string Provider { get; set; } = "gcp";

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
    /// This is the GCP key. This is the JSON that can be generated in the Google Cloud Console at https://console.cloud.google.com/iam-admin/serviceaccounts/details/&lt;service-account-id&gt;/keys.
    ///
    /// The schema is identical to the JSON that GCP outputs.
    /// </summary>
    [JsonPropertyName("gcpKey")]
    public required GcpKey GcpKey { get; set; }

    /// <summary>
    /// This is the bucket plan that can be provided to store call artifacts in GCP.
    /// </summary>
    [JsonPropertyName("bucketPlan")]
    public BucketPlan? BucketPlan { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
