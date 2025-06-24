using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateTokenDto
{
    /// <summary>
    /// This is the tag for the token. It represents its scope.
    /// </summary>
    [JsonPropertyName("tag")]
    public CreateTokenDtoTag? Tag { get; set; }

    /// <summary>
    /// This is the name of the token. This is just for your own reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This are the restrictions for the token.
    /// </summary>
    [JsonPropertyName("restrictions")]
    public TokenRestrictions? Restrictions { get; set; }

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
