using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record AzureOpenAiCredential
{
    [JsonPropertyName("provider")]
    public string Provider { get; set; } = "azure-openai";

    [JsonPropertyName("region")]
    public required AzureOpenAiCredentialRegion Region { get; set; }

    [JsonPropertyName("models")]
    public IEnumerable<AzureOpenAiCredentialModelsItem> Models { get; set; } =
        new List<AzureOpenAiCredentialModelsItem>();

    /// <summary>
    /// This is not returned in the API.
    /// </summary>
    [JsonPropertyName("openAIKey")]
    public required string OpenAiKey { get; set; }

    /// <summary>
    /// This is not returned in the API.
    /// </summary>
    [JsonPropertyName("ocpApimSubscriptionKey")]
    public string? OcpApimSubscriptionKey { get; set; }

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
    /// This is the name of credential. This is just for your reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("openAIEndpoint")]
    public required string OpenAiEndpoint { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
