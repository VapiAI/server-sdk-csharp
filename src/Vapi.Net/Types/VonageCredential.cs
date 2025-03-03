using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record VonageCredential
{
    /// <summary>
    /// This is not returned in the API.
    /// </summary>
    [JsonPropertyName("vonageApplicationPrivateKey")]
    public required string VonageApplicationPrivateKey { get; set; }

    [JsonPropertyName("provider")]
    public string Provider { get; set; } = "vonage";

    /// <summary>
    /// This is not returned in the API.
    /// </summary>
    [JsonPropertyName("apiSecret")]
    public required string ApiSecret { get; set; }

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
    /// This is the Vonage Application ID for the credential.
    ///
    /// Only relevant for Vonage credentials.
    /// </summary>
    [JsonPropertyName("vonageApplicationId")]
    public required string VonageApplicationId { get; set; }

    /// <summary>
    /// This is the name of credential. This is just for your reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("apiKey")]
    public required string ApiKey { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
