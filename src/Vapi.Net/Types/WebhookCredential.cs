using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record WebhookCredential
{
    [JsonPropertyName("provider")]
    public string Provider { get; set; } = "webhook";

    /// <summary>
    /// This is the authentication plan. Currently supports OAuth2 RFC 6749.
    /// </summary>
    [JsonPropertyName("authenticationPlan")]
    public required OAuth2AuthenticationPlan AuthenticationPlan { get; set; }

    /// <summary>
    /// This is the unique identifier for the credential.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the unique identifier for the org that this credential belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the credential was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the assistant was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// This is the authentication session for the credential. Available for credentials that have an authentication plan.
    /// </summary>
    [JsonPropertyName("authenticationSession")]
    public required Oauth2AuthenticationSession AuthenticationSession { get; set; }

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
