using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record Server
{
    /// <summary>
    /// This is the timeout in seconds for the request to your server. Defaults to 20 seconds.
    ///
    /// @default 20
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>
    /// API endpoint to send requests to.
    /// </summary>
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    /// <summary>
    /// This is the secret you can set that Vapi will send with every request to your server. Will be sent as a header called x-vapi-secret.
    ///
    /// Same precedence logic as server.
    /// </summary>
    [JsonPropertyName("secret")]
    public string? Secret { get; set; }

    /// <summary>
    /// These are the custom headers to include in the request sent to your server.
    ///
    /// Each key-value pair represents a header name and its value.
    /// </summary>
    [JsonPropertyName("headers")]
    public object? Headers { get; set; }

    /// <summary>
    /// This is the backoff plan to use if the request fails.
    /// </summary>
    [JsonPropertyName("backoffPlan")]
    public BackoffPlan? BackoffPlan { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
