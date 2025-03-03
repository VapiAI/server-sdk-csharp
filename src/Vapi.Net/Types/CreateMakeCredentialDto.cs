using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record CreateMakeCredentialDto
{
    /// <summary>
    /// Team ID
    /// </summary>
    [JsonPropertyName("teamId")]
    public required string TeamId { get; set; }

    /// <summary>
    /// Region of your application. For example: eu1, eu2, us1, us2
    /// </summary>
    [JsonPropertyName("region")]
    public required string Region { get; set; }

    /// <summary>
    /// This is not returned in the API.
    /// </summary>
    [JsonPropertyName("apiKey")]
    public required string ApiKey { get; set; }

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
