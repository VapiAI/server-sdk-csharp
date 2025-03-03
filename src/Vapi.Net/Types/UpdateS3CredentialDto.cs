using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record UpdateS3CredentialDto
{
    /// <summary>
    /// AWS access key ID.
    /// </summary>
    [JsonPropertyName("awsAccessKeyId")]
    public string? AwsAccessKeyId { get; set; }

    /// <summary>
    /// AWS access key secret. This is not returned in the API.
    /// </summary>
    [JsonPropertyName("awsSecretAccessKey")]
    public string? AwsSecretAccessKey { get; set; }

    /// <summary>
    /// AWS region in which the S3 bucket is located.
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// AWS S3 bucket name.
    /// </summary>
    [JsonPropertyName("s3BucketName")]
    public string? S3BucketName { get; set; }

    /// <summary>
    /// The path prefix for the uploaded recording. Ex. "recordings/"
    /// </summary>
    [JsonPropertyName("s3PathPrefix")]
    public string? S3PathPrefix { get; set; }

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
