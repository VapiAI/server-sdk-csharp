using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record HmacAuthenticationPlan : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the HMAC secret key used to sign requests.
    /// </summary>
    [JsonPropertyName("secretKey")]
    public required string SecretKey { get; set; }

    /// <summary>
    /// This is the HMAC algorithm to use for signing.
    /// </summary>
    [JsonPropertyName("algorithm")]
    public required HmacAuthenticationPlanAlgorithm Algorithm { get; set; }

    /// <summary>
    /// This is the header name where the signature will be sent. Defaults to 'x-signature'.
    /// </summary>
    [JsonPropertyName("signatureHeader")]
    public string? SignatureHeader { get; set; }

    /// <summary>
    /// This is the header name where the timestamp will be sent. Defaults to 'x-timestamp'.
    /// </summary>
    [JsonPropertyName("timestampHeader")]
    public string? TimestampHeader { get; set; }

    /// <summary>
    /// This is the prefix for the signature. For example, 'sha256=' for GitHub-style signatures.
    /// </summary>
    [JsonPropertyName("signaturePrefix")]
    public string? SignaturePrefix { get; set; }

    /// <summary>
    /// Whether to include a timestamp in the signature payload. Defaults to true.
    /// </summary>
    [JsonPropertyName("includeTimestamp")]
    public bool? IncludeTimestamp { get; set; }

    /// <summary>
    /// Custom payload format. Use {body} for request body, {timestamp} for timestamp, {method} for HTTP method, {url} for URL, {svix-id} for unique message ID. Defaults to '{timestamp}.{body}'.
    /// </summary>
    [JsonPropertyName("payloadFormat")]
    public string? PayloadFormat { get; set; }

    /// <summary>
    /// This is the header name where the unique message ID will be sent. Used for Svix-style webhooks.
    /// </summary>
    [JsonPropertyName("messageIdHeader")]
    public string? MessageIdHeader { get; set; }

    /// <summary>
    /// The encoding format for the signature. Defaults to 'hex'.
    /// </summary>
    [JsonPropertyName("signatureEncoding")]
    public HmacAuthenticationPlanSignatureEncoding? SignatureEncoding { get; set; }

    /// <summary>
    /// Whether the secret key is base64-encoded and should be decoded before use. Defaults to false.
    /// </summary>
    [JsonPropertyName("secretIsBase64")]
    public bool? SecretIsBase64 { get; set; }

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
