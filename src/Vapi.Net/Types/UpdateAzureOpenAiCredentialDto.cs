using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record UpdateAzureOpenAiCredentialDto
{
    [JsonPropertyName("region")]
    public UpdateAzureOpenAiCredentialDtoRegion? Region { get; set; }

    [JsonPropertyName("models")]
    public IEnumerable<UpdateAzureOpenAiCredentialDtoModelsItem>? Models { get; set; }

    /// <summary>
    /// This is not returned in the API.
    /// </summary>
    [JsonPropertyName("openAIKey")]
    public string? OpenAiKey { get; set; }

    /// <summary>
    /// This is not returned in the API.
    /// </summary>
    [JsonPropertyName("ocpApimSubscriptionKey")]
    public string? OcpApimSubscriptionKey { get; set; }

    /// <summary>
    /// This is the name of credential. This is just for your reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("openAIEndpoint")]
    public string? OpenAiEndpoint { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
