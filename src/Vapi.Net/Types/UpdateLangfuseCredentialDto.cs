using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record UpdateLangfuseCredentialDto
{
    /// <summary>
    /// The public key for Langfuse project. Eg: pk-lf-...
    /// </summary>
    [JsonPropertyName("publicKey")]
    public string? PublicKey { get; set; }

    /// <summary>
    /// The secret key for Langfuse project. Eg: sk-lf-... .This is not returned in the API.
    /// </summary>
    [JsonPropertyName("apiKey")]
    public string? ApiKey { get; set; }

    /// <summary>
    /// The host URL for Langfuse project. Eg: https://cloud.langfuse.com
    /// </summary>
    [JsonPropertyName("apiUrl")]
    public string? ApiUrl { get; set; }

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
