using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record CreateTwilioCredentialDto
{
    /// <summary>
    /// This is not returned in the API.
    /// </summary>
    [JsonPropertyName("authToken")]
    public required string AuthToken { get; set; }

    [JsonPropertyName("accountSid")]
    public required string AccountSid { get; set; }

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
