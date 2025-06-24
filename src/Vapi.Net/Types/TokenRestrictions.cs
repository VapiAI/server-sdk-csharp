using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TokenRestrictions
{
    /// <summary>
    /// This determines whether the token is enabled or disabled. Default is true, it's enabled.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

    /// <summary>
    /// This determines the allowed origins for this token. Validates the `Origin` header. Default is any origin.
    ///
    /// Only relevant for `public` tokens.
    /// </summary>
    [JsonPropertyName("allowedOrigins")]
    public IEnumerable<string>? AllowedOrigins { get; set; }

    /// <summary>
    /// This determines which assistantIds can be used when creating a call. Default is any assistantId.
    ///
    /// Only relevant for `public` tokens.
    /// </summary>
    [JsonPropertyName("allowedAssistantIds")]
    public IEnumerable<string>? AllowedAssistantIds { get; set; }

    /// <summary>
    /// This determines whether transient assistants can be used when creating a call. Default is true.
    ///
    /// If `allowedAssistantIds` is provided, this is automatically false.
    ///
    /// Only relevant for `public` tokens.
    /// </summary>
    [JsonPropertyName("allowTransientAssistant")]
    public bool? AllowTransientAssistant { get; set; }

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
