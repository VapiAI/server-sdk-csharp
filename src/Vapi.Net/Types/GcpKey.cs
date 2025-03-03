using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record GcpKey
{
    /// <summary>
    /// This is the type of the key. Most likely, this is "service_account".
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// This is the ID of the Google Cloud project associated with this key.
    /// </summary>
    [JsonPropertyName("projectId")]
    public required string ProjectId { get; set; }

    /// <summary>
    /// This is the unique identifier for the private key.
    /// </summary>
    [JsonPropertyName("privateKeyId")]
    public required string PrivateKeyId { get; set; }

    /// <summary>
    /// This is the private key in PEM format.
    ///
    /// Note: This is not returned in the API.
    /// </summary>
    [JsonPropertyName("privateKey")]
    public required string PrivateKey { get; set; }

    /// <summary>
    /// This is the email address associated with the service account.
    /// </summary>
    [JsonPropertyName("clientEmail")]
    public required string ClientEmail { get; set; }

    /// <summary>
    /// This is the unique identifier for the client.
    /// </summary>
    [JsonPropertyName("clientId")]
    public required string ClientId { get; set; }

    /// <summary>
    /// This is the URI for the auth provider's authorization endpoint.
    /// </summary>
    [JsonPropertyName("authUri")]
    public required string AuthUri { get; set; }

    /// <summary>
    /// This is the URI for the auth provider's token endpoint.
    /// </summary>
    [JsonPropertyName("tokenUri")]
    public required string TokenUri { get; set; }

    /// <summary>
    /// This is the URL of the public x509 certificate for the auth provider.
    /// </summary>
    [JsonPropertyName("authProviderX509CertUrl")]
    public required string AuthProviderX509CertUrl { get; set; }

    /// <summary>
    /// This is the URL of the public x509 certificate for the client.
    /// </summary>
    [JsonPropertyName("clientX509CertUrl")]
    public required string ClientX509CertUrl { get; set; }

    /// <summary>
    /// This is the domain associated with the universe this service account belongs to.
    /// </summary>
    [JsonPropertyName("universeDomain")]
    public required string UniverseDomain { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
