using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record Oauth2AuthenticationSession
{
    /// <summary>
    /// This is the OAuth2 access token.
    /// </summary>
    [JsonPropertyName("accessToken")]
    public string? AccessToken { get; set; }

    /// <summary>
    /// This is the OAuth2 access token expiration.
    /// </summary>
    [JsonPropertyName("expiresAt")]
    public DateTime? ExpiresAt { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
