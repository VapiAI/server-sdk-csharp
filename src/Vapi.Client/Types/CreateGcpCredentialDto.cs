using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record CreateGcpCredentialDto
{
    [JsonPropertyName("provider")]
    public required string Provider { get; set; }

    /// <summary>
    /// This is the name of the GCP credential. This is just for your reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the GCP key. This is the JSON that can be generated in the Google Cloud Console at https://console.cloud.google.com/iam-admin/serviceaccounts/details/<service-account-id>/keys.
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