using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record Server : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the timeout in seconds for the request. Defaults to 20 seconds.
    ///
    /// @default 20
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>
    /// The credential ID for server authentication
    /// </summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    /// <summary>
    /// If enabled, requests will originate from a static set of IPs owned and managed by Vapi.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("staticIpAddressesEnabled")]
    public bool? StaticIpAddressesEnabled { get; set; }

    /// <summary>
    /// This is the paths to encrypt in the request body if credentialId and encryptionPlan are defined.
    /// </summary>
    [JsonPropertyName("encryptedPaths")]
    public IEnumerable<string>? EncryptedPaths { get; set; }

    /// <summary>
    /// This is where the request will be sent.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// These are the headers to include in the request.
    ///
    /// Each key-value pair represents a header name and its value.
    ///
    /// Note: Specifying an Authorization header here will override the authorization provided by the `credentialId` (if provided). This is an anti-pattern and should be avoided outside of edge case scenarios.
    /// </summary>
    [JsonPropertyName("headers")]
    public object? Headers { get; set; }

    /// <summary>
    /// This is the backoff plan if the request fails. Defaults to undefined (the request will not be retried).
    ///
    /// @default undefined (the request will not be retried)
    /// </summary>
    [JsonPropertyName("backoffPlan")]
    public BackoffPlan? BackoffPlan { get; set; }

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
