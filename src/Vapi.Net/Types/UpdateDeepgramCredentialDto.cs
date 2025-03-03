using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record UpdateDeepgramCredentialDto
{
    /// <summary>
    /// This is not returned in the API.
    /// </summary>
    [JsonPropertyName("apiKey")]
    public string? ApiKey { get; set; }

    /// <summary>
    /// This is the name of credential. This is just for your reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This can be used to point to an onprem Deepgram instance. Defaults to api.deepgram.com.
    /// </summary>
    [JsonPropertyName("apiUrl")]
    public string? ApiUrl { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
