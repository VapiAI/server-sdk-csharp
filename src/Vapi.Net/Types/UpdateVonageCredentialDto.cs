using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record UpdateVonageCredentialDto
{
    /// <summary>
    /// This is not returned in the API.
    /// </summary>
    [JsonPropertyName("apiSecret")]
    public string? ApiSecret { get; set; }

    /// <summary>
    /// This is the name of credential. This is just for your reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("apiKey")]
    public string? ApiKey { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
