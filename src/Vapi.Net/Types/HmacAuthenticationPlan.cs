using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record HmacAuthenticationPlan
{
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
