using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record UpdateGcpCredentialDto
{
    /// <summary>
    /// This is the order in which this storage provider is tried during upload retries. Lower numbers are tried first in increasing order.
    /// </summary>
    [JsonPropertyName("fallbackIndex")]
    public double? FallbackIndex { get; set; }

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
    public GcpKey? GcpKey { get; set; }

    /// <summary>
    /// This is the region of the GCP resource.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    [JsonPropertyName("bucketPlan")]
    public BucketPlan? BucketPlan { get; set; }

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
