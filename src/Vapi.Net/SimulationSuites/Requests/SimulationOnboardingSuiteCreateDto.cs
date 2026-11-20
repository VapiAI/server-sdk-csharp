using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationOnboardingSuiteCreateDto
{
    /// <summary>
    /// Assistant the suite tests and is assigned to.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public required string AssistantId { get; set; }

    /// <summary>
    /// A unique key for this suite generation request. Retrying with the same key returns the saved suite, or a 409 while generation is in progress. Use a new key for a different assistant or requirements.
    /// </summary>
    [JsonPropertyName("idempotencyKey")]
    public required string IdempotencyKey { get; set; }

    /// <summary>
    /// The reviewed test requirements to generate simulations for, from the requirements draft. Each requirement must have a unique id.
    /// </summary>
    [JsonPropertyName("requirements")]
    public IEnumerable<SimulationOnboardingRequirementDto> Requirements { get; set; } =
        new List<SimulationOnboardingRequirementDto>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
