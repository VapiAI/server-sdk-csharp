using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record CreatePlayHtCredentialDto
{
    /// <summary>
    /// This is not returned in the API.
    /// </summary>
    [JsonPropertyName("apiKey")]
    public required string ApiKey { get; set; }

    [JsonPropertyName("userId")]
    public required string UserId { get; set; }

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
