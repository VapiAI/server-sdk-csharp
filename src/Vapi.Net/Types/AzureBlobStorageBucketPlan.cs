using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record AzureBlobStorageBucketPlan
{
    /// <summary>
    /// This is the blob storage connection string for the Azure resource.
    /// </summary>
    [JsonPropertyName("connectionString")]
    public required string ConnectionString { get; set; }

    /// <summary>
    /// This is the container name for the Azure blob storage.
    /// </summary>
    [JsonPropertyName("containerName")]
    public required string ContainerName { get; set; }

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
