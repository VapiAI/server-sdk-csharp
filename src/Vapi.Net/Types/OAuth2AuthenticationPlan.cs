using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Client-credentials configuration for obtaining an OAuth 2.0 access token used to authenticate outbound requests.
/// </summary>
[Serializable]
public record OAuth2AuthenticationPlan : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Selects OAuth 2.0 authentication.
    /// </summary>
    [JsonPropertyName("type")]
    public required OAuth2AuthenticationPlanType Type { get; set; }

    /// <summary>
    /// This is the OAuth2 URL.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    /// <summary>
    /// This is the OAuth2 client ID.
    /// </summary>
    [JsonPropertyName("clientId")]
    public required string ClientId { get; set; }

    /// <summary>
    /// This is the OAuth2 client secret.
    /// </summary>
    [JsonPropertyName("clientSecret")]
    public required string ClientSecret { get; set; }

    /// <summary>
    /// This is the scope of the OAuth2 token.
    /// </summary>
    [JsonPropertyName("scope")]
    public string? Scope { get; set; }

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
