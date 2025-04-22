using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record CreateAzureCredentialDto
{
    /// <summary>
    /// This is the service being used in Azure.
    /// </summary>
    [JsonPropertyName("service")]
    public required CreateAzureCredentialDtoService Service { get; set; }

    /// <summary>
    /// This is the region of the Azure resource.
    /// </summary>
    [JsonPropertyName("region")]
    public CreateAzureCredentialDtoRegion? Region { get; set; }

    /// <summary>
    /// This is not returned in the API.
    /// </summary>
    [JsonPropertyName("apiKey")]
    public string? ApiKey { get; set; }

    /// <summary>
    /// This is the bucket plan that can be provided to store call artifacts in Azure Blob Storage.
    /// </summary>
    [JsonPropertyName("bucketPlan")]
    public AzureBlobStorageBucketPlan? BucketPlan { get; set; }

    /// <summary>
    /// This is the name of credential. This is just for your reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
