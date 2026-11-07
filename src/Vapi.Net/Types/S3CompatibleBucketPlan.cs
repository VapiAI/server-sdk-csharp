using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record S3CompatibleBucketPlan : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// S3-compatible endpoint URL, such as https://s3.us-west-004.backblazeb2.com. Must be public HTTPS.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    /// <summary>
    /// SigV4 signing region expected by the object store. Most stores accept us-east-1.
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>
    /// S3 access key ID.
    /// </summary>
    [JsonPropertyName("accessKeyId")]
    public required string AccessKeyId { get; set; }

    /// <summary>
    /// S3 secret access key. This is not returned in the API.
    /// </summary>
    [JsonAccess(JsonAccessType.WriteOnly)]
    [JsonPropertyName("secretAccessKey")]
    public required string SecretAccessKey { get; set; }

    /// <summary>
    /// Bucket name.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// Optional key prefix inside the bucket, such as recordings/.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

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
