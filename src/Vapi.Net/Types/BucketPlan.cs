using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record BucketPlan
{
    /// <summary>
    /// This is the name of the bucket.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// This is the region of the bucket.
    ///
    /// Usage:
    /// - If `credential.type` is `aws`, then this is required.
    /// - If `credential.type` is `gcp`, then this is optional since GCP allows buckets to be accessed without a region but region is required for data residency requirements. Read here: https://cloud.google.com/storage/docs/request-endpoints
    /// </summary>
    [JsonPropertyName("region")]
    public string? Region { get; set; }

    /// <summary>
    /// This is the path where call artifacts will be stored.
    ///
    /// Usage:
    /// - To store call artifacts in a specific folder, set this to the full path. Eg. "/folder-name1/folder-name2".
    /// - To store call artifacts in the root of the bucket, leave this blank.
    ///
    /// @default "/"
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// This is the HMAC access key offered by GCP for interoperability with S3 clients. Here is the guide on how to create: https://cloud.google.com/storage/docs/authentication/managing-hmackeys#console
    ///
    /// Usage:
    /// - If `credential.type` is `gcp`, then this is required.
    /// - If `credential.type` is `aws`, then this is not required since credential.awsAccessKeyId is used instead.
    /// </summary>
    [JsonPropertyName("hmacAccessKey")]
    public string? HmacAccessKey { get; set; }

    /// <summary>
    /// This is the secret for the HMAC access key. Here is the guide on how to create: https://cloud.google.com/storage/docs/authentication/managing-hmackeys#console
    ///
    /// Usage:
    /// - If `credential.type` is `gcp`, then this is required.
    /// - If `credential.type` is `aws`, then this is not required since credential.awsSecretAccessKey is used instead.
    ///
    /// Note: This is not returned in the API.
    /// </summary>
    [JsonPropertyName("hmacSecret")]
    public string? HmacSecret { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
