using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record Server
{
    /// <summary>
    /// This is the timeout in seconds for the request. Defaults to 20 seconds.
    ///
    /// @default 20
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>
    /// This is where the request will be sent.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// These are the headers to include in the request.
    ///
    /// Each key-value pair represents a header name and its value.
    /// </summary>
    [JsonPropertyName("headers")]
    public object? Headers { get; set; }

    /// <summary>
    /// This is the backoff plan if the request fails. Defaults to undefined (the request will not be retried).
    ///
    /// @default undefined (the request will not be retried)
    /// </summary>
    [JsonPropertyName("backoffPlan")]
    public BackoffPlan? BackoffPlan { get; set; }

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
