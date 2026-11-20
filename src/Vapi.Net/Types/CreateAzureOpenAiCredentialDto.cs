using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

/// <summary>
/// Credentials for authenticating assistant model requests with Azure OpenAI, including region, endpoint, and available models.
/// </summary>
[Serializable]
public record CreateAzureOpenAiCredentialDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Azure region that hosts the OpenAI resource.
    /// </summary>
    [JsonPropertyName("region")]
    public required CreateAzureOpenAiCredentialDtoRegion Region { get; set; }

    /// <summary>
    /// Azure OpenAI models available through this credential.
    /// </summary>
    [JsonPropertyName("models")]
    public IEnumerable<CreateAzureOpenAiCredentialDtoModelsItem> Models { get; set; } =
        new List<CreateAzureOpenAiCredentialDtoModelsItem>();

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
    /// Endpoint URL for the Azure OpenAI resource.
    /// </summary>
    [JsonPropertyName("openAIEndpoint")]
    public required string OpenAiEndpoint { get; set; }

    /// <summary>
    /// This is the name of credential. This is just for your reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
