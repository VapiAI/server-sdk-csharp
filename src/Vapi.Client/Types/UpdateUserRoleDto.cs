using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record UpdateUserRoleDto
{
    [JsonPropertyName("userId")]
    public required string UserId { get; set; }

    [JsonPropertyName("role")]
    public required UpdateUserRoleDtoRole Role { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
