using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record UpdateTwilioCredentialDto
{
    /// <summary>
    /// This is not returned in the API.
    /// </summary>
    [JsonPropertyName("authToken")]
    public string? AuthToken { get; set; }

    /// <summary>
    /// This is the name of credential. This is just for your reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("accountSid")]
    public string? AccountSid { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
