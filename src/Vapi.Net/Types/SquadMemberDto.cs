using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record SquadMemberDto
{
    /// <summary>
    /// This is the assistant that will be used for the call. To use a transient assistant, use `assistant` instead.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public string? AssistantId { get; set; }

    /// <summary>
    /// This is the assistant that will be used for the call. To use an existing assistant, use `assistantId` instead.
    /// </summary>
    [JsonPropertyName("assistant")]
    public CreateAssistantDto? Assistant { get; set; }

    /// <summary>
    /// This can be used to override the assistant's settings and provide values for it's template variables.
    /// </summary>
    [JsonPropertyName("assistantOverrides")]
    public AssistantOverrides? AssistantOverrides { get; set; }

    /// <summary>
    /// These are the others assistants that this assistant can transfer to.
    ///
    /// If the assistant already has transfer call tool, these destinations are just appended to existing ones.
    /// </summary>
    [JsonPropertyName("assistantDestinations")]
    public IEnumerable<TransferDestinationAssistant>? AssistantDestinations { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
