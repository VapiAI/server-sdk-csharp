using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// An uploaded file record, including its processing status, storage details, extracted-text location, metadata, and lifecycle timestamps.
/// </summary>
[Serializable]
public record File : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The object type. This is always `file`.
    /// </summary>
    [JsonPropertyName("object")]
    public FileObject? Object { get; set; }

    /// <summary>
    /// The current processing status of the uploaded file.
    /// </summary>
    [JsonPropertyName("status")]
    public FileStatus? Status { get; set; }

    /// <summary>
    /// This is the name of the file. This is just for your own reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The original name of the uploaded file.
    /// </summary>
    [JsonPropertyName("originalName")]
    public string? OriginalName { get; set; }

    /// <summary>
    /// The size of the uploaded file in bytes.
    /// </summary>
    [JsonPropertyName("bytes")]
    public double? Bytes { get; set; }

    /// <summary>
    /// The intended use assigned to the uploaded file.
    /// </summary>
    [JsonPropertyName("purpose")]
    public string? Purpose { get; set; }

    /// <summary>
    /// The MIME type of the uploaded file.
    /// </summary>
    [JsonPropertyName("mimetype")]
    public string? Mimetype { get; set; }

    /// <summary>
    /// The object-storage key for the uploaded file.
    /// </summary>
    [JsonPropertyName("key")]
    public string? Key { get; set; }

    /// <summary>
    /// The object-storage path for the uploaded file.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// The object-storage bucket containing the uploaded file.
    /// </summary>
    [JsonPropertyName("bucket")]
    public string? Bucket { get; set; }

    /// <summary>
    /// The URL used to access the uploaded file.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// The URL used to access text extracted from the file.
    /// </summary>
    [JsonPropertyName("parsedTextUrl")]
    public string? ParsedTextUrl { get; set; }

    /// <summary>
    /// The size of the extracted text in bytes.
    /// </summary>
    [JsonPropertyName("parsedTextBytes")]
    public double? ParsedTextBytes { get; set; }

    /// <summary>
    /// Additional metadata associated with the uploaded file.
    /// </summary>
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
