using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateSquadDto
{
    /// <summary>
    /// This is the name of the squad.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the list of assistants that make up the squad.
    ///
    /// The call will start with the first assistant in the list.
    /// </summary>
    [JsonPropertyName("members")]
    public IEnumerable<SquadMemberDto> Members { get; set; } = new List<SquadMemberDto>();

    /// <summary>
    /// This can be used to override all the assistants' settings and provide values for their template variables.
    ///
    /// Both `membersOverrides` and `members[n].assistantOverrides` can be used together. First, `members[n].assistantOverrides` is applied. Then, `membersOverrides` is applied as a global override.
    /// </summary>
    [JsonPropertyName("membersOverrides")]
    public AssistantOverrides? MembersOverrides { get; set; }

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
