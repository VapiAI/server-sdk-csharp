using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record CreateWebhookCredentialDto
{
    /// <summary>
    /// This is the authentication plan. Currently supports OAuth2 RFC 6749.
    /// </summary>
    [JsonPropertyName("authenticationPlan")]
    public required OAuth2AuthenticationPlan AuthenticationPlan { get; set; }

    /// <summary>
    /// This is the name of credential. This is just for your reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
