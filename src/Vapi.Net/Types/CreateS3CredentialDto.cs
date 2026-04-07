using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateS3CredentialDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// AWS access key ID.
    /// </summary>
    [JsonPropertyName("awsAccessKeyId")]
    public required string AwsAccessKeyId { get; set; }

    /// <summary>
    /// AWS access key secret. This is not returned in the API.
    /// </summary>
    [JsonPropertyName("awsSecretAccessKey")]
    public required string AwsSecretAccessKey { get; set; }

    /// <summary>
    /// AWS region in which the S3 bucket is located.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>
    /// AWS S3 bucket name.
    /// </summary>
    [JsonPropertyName("s3BucketName")]
    public required string S3BucketName { get; set; }

    /// <summary>
    /// The path prefix for the uploaded recording. Ex. "recordings/"
    /// </summary>
    [JsonPropertyName("s3PathPrefix")]
    public required string S3PathPrefix { get; set; }

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
