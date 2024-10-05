using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record CreatePlayHtCredentialDto
{
    [JsonPropertyName("provider")]
    public required string Provider { get; set; }

    /// <summary>
    /// This is not returned in the API.
    /// </summary>
    [JsonPropertyName("apiKey")]
    public required string ApiKey { get; set; }

    [JsonPropertyName("userId")]
    public required string UserId { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}