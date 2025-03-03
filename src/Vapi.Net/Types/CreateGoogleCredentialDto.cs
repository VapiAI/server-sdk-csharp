using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record CreateGoogleCredentialDto
{
    /// <summary>
    /// This is the key for Gemini in Google AI Studio. Get it from here: https://aistudio.google.com/app/apikey
    /// </summary>
    [JsonPropertyName("provider")]
    public string Provider { get; set; } = "google";

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
