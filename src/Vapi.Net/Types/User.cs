using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record User
{
    /// <summary>
    /// This is the unique identifier for the profile or user.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the profile was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the profile was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// This is the email of the user that is associated with the profile.
    /// </summary>
    [JsonPropertyName("email")]
    public required string Email { get; set; }

    /// <summary>
    /// This is the full name of the user that is associated with the profile.
    /// </summary>
    [JsonPropertyName("fullName")]
    public string? FullName { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
