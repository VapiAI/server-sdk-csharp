using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record UserWithRole : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the user's role in the org: a built-in role, the HIPAA special role, or a custom WorkOS role slug prefixed with `org-`.
    /// </summary>
    [JsonPropertyName("role")]
    public required OneOf<UserWithRoleRoleZero, string> Role { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of the user's most recent sign-in to the org's identity provider (WorkOS). It is a property of the user, not of this org membership, so a sign-in to another WorkOS org counts. Only returned to org admins; absent when the requester is not an admin, no sign-in has been recorded, or the org is not linked to WorkOS.
    /// </summary>
    [JsonPropertyName("lastActiveAt")]
    public DateTime? LastActiveAt { get; set; }

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

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
