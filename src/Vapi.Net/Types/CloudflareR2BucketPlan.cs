using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record CloudflareR2BucketPlan
{
    /// <summary>
    /// Cloudflare R2 Access key ID.
    /// </summary>
    [JsonPropertyName("accessKeyId")]
    public string? AccessKeyId { get; set; }

    /// <summary>
    /// Cloudflare R2 access key secret. This is not returned in the API.
    /// </summary>
    [JsonPropertyName("secretAccessKey")]
    public string? SecretAccessKey { get; set; }

    /// <summary>
    /// Cloudflare R2 base url.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// This is the name of the bucket.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
