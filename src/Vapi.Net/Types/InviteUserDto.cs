using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record InviteUserDto
{
    [JsonPropertyName("emails")]
    public IEnumerable<string> Emails { get; set; } = new List<string>();

    [JsonPropertyName("role")]
    public required InviteUserDtoRole Role { get; set; }

    [JsonPropertyName("redirectTo")]
    public string? RedirectTo { get; set; }

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
