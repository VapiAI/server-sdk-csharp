using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record UpdateTokenDto
{
    /// <summary>
    /// This is the tag for the token. It represents its scope.
    /// </summary>
    [JsonPropertyName("tag")]
    public UpdateTokenDtoTag? Tag { get; set; }

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
