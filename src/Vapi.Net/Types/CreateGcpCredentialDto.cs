using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Service-account credentials for Google Cloud resources and optional call-artifact storage, including region, bucket configuration, and upload fallback order.
/// </summary>
[Serializable]
public record CreateGcpCredentialDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the order in which this storage provider is tried during upload retries. Lower numbers are tried first in increasing order.
    /// </summary>
    [JsonPropertyName("fallbackIndex")]
    public double? FallbackIndex { get; set; }

    /// <summary>
    /// This is the GCP key. This is the JSON that can be generated in the Google Cloud Console at https://console.cloud.google.com/iam-admin/serviceaccounts/details/&lt;service-account-id&gt;/keys.
    ///
    /// The schema is identical to the JSON that GCP outputs.
    /// </summary>
    [JsonPropertyName("gcpKey")]
    public required GcpKey GcpKey { get; set; }

    /// <summary>
    /// This is the region of the GCP resource.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// Bucket configuration used to store call artifacts in Google Cloud Storage.
    /// </summary>
    [JsonPropertyName("bucketPlan")]
    public BucketPlan? BucketPlan { get; set; }

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
