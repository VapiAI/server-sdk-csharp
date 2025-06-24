using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CredentialWebhookDto
{
    [JsonPropertyName("type")]
    public required CredentialWebhookDtoType Type { get; set; }

    [JsonPropertyName("operation")]
    public required CredentialWebhookDtoOperation Operation { get; set; }

    [JsonPropertyName("from")]
    public required string From { get; set; }

    [JsonPropertyName("connectionId")]
    public required string ConnectionId { get; set; }

    [JsonPropertyName("authMode")]
    public required CredentialWebhookDtoAuthMode AuthMode { get; set; }

    [JsonPropertyName("providerConfigKey")]
    public required string ProviderConfigKey { get; set; }

    [JsonPropertyName("provider")]
    public required string Provider { get; set; }

    [JsonPropertyName("environment")]
    public required string Environment { get; set; }

    [JsonPropertyName("success")]
    public required bool Success { get; set; }

    [JsonPropertyName("endUser")]
    public required CredentialEndUser EndUser { get; set; }

    [JsonPropertyName("error")]
    public CredentialSessionError? Error { get; set; }

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
