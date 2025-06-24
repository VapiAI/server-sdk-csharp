using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SipAuthentication
{
    /// <summary>
    /// This will be expected in the `realm` field of the `authorization` header of the SIP INVITE. Defaults to sip.vapi.ai.
    /// </summary>
    [JsonPropertyName("realm")]
    public string? Realm { get; set; }

    /// <summary>
    /// This will be expected in the `username` field of the `authorization` header of the SIP INVITE.
    /// </summary>
    [JsonPropertyName("username")]
    public required string Username { get; set; }

    /// <summary>
    /// This will be expected to generate the `response` field of the `authorization` header of the SIP INVITE, through digest authentication.
    /// </summary>
    [JsonPropertyName("password")]
    public required string Password { get; set; }

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
