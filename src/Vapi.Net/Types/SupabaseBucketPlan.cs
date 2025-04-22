using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record SupabaseBucketPlan
{
    /// <summary>
    /// This is the S3 Region. It should look like us-east-1
    /// It should be one of the supabase regions defined in the SUPABASE_REGION enum
    /// Check https://supabase.com/docs/guides/platform/regions for up to date regions
    /// </summary>
    [JsonPropertyName("region")]
    public required SupabaseBucketPlanRegion Region { get; set; }

    /// <summary>
    /// This is the S3 compatible URL for Supabase S3
    /// This should look like https://&lt;project-ID&gt;.supabase.co/storage/v1/s3
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    /// <summary>
    /// This is the Supabase S3 Access Key ID.
    /// The user creates this in the Supabase project Storage settings
    /// </summary>
    [JsonPropertyName("accessKeyId")]
    public required string AccessKeyId { get; set; }

    /// <summary>
    /// This is the Supabase S3 Secret Access Key.
    /// The user creates this in the Supabase project Storage settings along with the access key id
    /// </summary>
    [JsonPropertyName("secretAccessKey")]
    public required string SecretAccessKey { get; set; }

    /// <summary>
    /// This is the Supabase S3 Bucket Name.
    /// The user must create this in Supabase under Storage &gt; Buckets
    /// A bucket that does not exist will not be checked now, but file uploads will fail
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// This is the Supabase S3 Bucket Folder Path.
    /// The user can create this in Supabase under Storage &gt; Buckets
    /// A path that does not exist will not be checked now, but file uploads will fail
    /// A Path is like a folder in the bucket
    /// Eg. If the bucket is called "my-bucket" and the path is "my-folder", the full path is "my-bucket/my-folder"
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

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
