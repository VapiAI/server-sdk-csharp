using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record OAuth2AuthenticationPlan
{
    [JsonPropertyName("type")]
    public string Type { get; set; } = "oauth2";

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
