using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationOnboardingRequirementsCreateDto
{
    /// <summary>
    /// Assistant to draft requirements for.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public required string AssistantId { get; set; }

    /// <summary>
    /// The draft being revised, exactly as this endpoint returned it. Send it with `feedback`.
    /// </summary>
    [JsonPropertyName("previousDraft")]
    public SimulationOnboardingRequirementsDraftDto? PreviousDraft { get; set; }

    /// <summary>
    /// Natural-language instructions for revising the requirements in `previousDraft`, including answers to open questions. Required when `previousDraft` is provided.
    /// </summary>
    [JsonPropertyName("feedback")]
    public string? Feedback { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
