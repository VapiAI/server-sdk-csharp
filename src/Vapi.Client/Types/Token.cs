using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record Token
{
    /// <summary>
    /// This is the tag for the token. It represents its scope.
    /// </summary>
    [JsonPropertyName("tag")]
    public TokenTag? Tag { get; set; }

    /// <summary>
    /// This is the unique identifier for the token.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is unique identifier for the org that this token belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the token was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the token was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// This is the token key.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }

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
