using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record BearerAuthenticationPlan
{
    /// <summary>
    /// This is the bearer token value.
    /// </summary>
    [JsonPropertyName("token")]
    public required string Token { get; set; }

    /// <summary>
    /// This is the header name where the bearer token will be sent. Defaults to 'Authorization'.
    /// </summary>
    [JsonPropertyName("headerName")]
    public string? HeaderName { get; set; }

    /// <summary>
    /// Whether to include the 'Bearer ' prefix in the header value. Defaults to true.
    /// </summary>
    [JsonPropertyName("bearerPrefixEnabled")]
    public bool? BearerPrefixEnabled { get; set; }

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
