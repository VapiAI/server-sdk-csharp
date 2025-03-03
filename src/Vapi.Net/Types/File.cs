using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record File
{
    [JsonPropertyName("object")]
    public string? Object { get; set; }

    [JsonPropertyName("status")]
    public FileStatus? Status { get; set; }

    /// <summary>
    /// This is the name of the file. This is just for your own reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("originalName")]
    public string? OriginalName { get; set; }

    [JsonPropertyName("bytes")]
    public double? Bytes { get; set; }

    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    [JsonPropertyName("mimetype")]
    public string? Mimetype { get; set; }

    [JsonPropertyName("key")]
    public string? Key { get; set; }

    [JsonPropertyName("path")]
    public string? Path { get; set; }

    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    [JsonPropertyName("url")]
    public string? Url { get; set; }

    [JsonPropertyName("metadata")]
    public object? Metadata { get; set; }

    /// <summary>
    /// This is the unique identifier for the file.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the unique identifier for the org that this file belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the file was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the file was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
