using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationOnboardingSuiteViewDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The generated simulation suite id and name.
    /// </summary>
    [JsonPropertyName("suite")]
    public required SimulationOnboardingSuiteRefDto Suite { get; set; }

    /// <summary>
    /// Assistant the suite is assigned to.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public required string AssistantId { get; set; }

    /// <summary>
    /// The suite's simulations, in order.
    /// </summary>
    [JsonPropertyName("simulations")]
    public IEnumerable<SimulationOnboardingSuiteSimulationDto> Simulations { get; set; } =
        new List<SimulationOnboardingSuiteSimulationDto>();

    /// <summary>
    /// Counts of covered and total requirements, uncovered requirements, and scenarios available to retry.
    /// </summary>
    [JsonPropertyName("coverage")]
    public required SimulationOnboardingSuiteCoverageDto Coverage { get; set; }

    /// <summary>
    /// The test requirements used to generate the suite. Match their ids to `coverage.gaps` to identify uncovered requirements.
    /// </summary>
    [JsonPropertyName("requirements")]
    public IEnumerable<SimulationOnboardingRequirementDto> Requirements { get; set; } =
        new List<SimulationOnboardingRequirementDto>();

    /// <summary>
    /// Links to simulation testing best practices and tool mocking documentation.
    /// </summary>
    [JsonPropertyName("docs")]
    public required SimulationOnboardingSuiteDocsDto Docs { get; set; }

    /// <summary>
    /// True when the request matched one already applied (same `idempotencyKey` or `patchKey`) and nothing changed.
    /// </summary>
    [JsonPropertyName("reused")]
    public required bool Reused { get; set; }

    /// <summary>
    /// Simulations an edit asked to rewrite that were not rewritten, for example because the rewrite did not generate in time. Retry them with a new `patchKey`.
    /// </summary>
    [JsonPropertyName("failedEditSimulationIds")]
    public IEnumerable<string>? FailedEditSimulationIds { get; set; }

    /// <summary>
    /// Tool paths the suite's simulations do not exercise as configured, such as a tool mocked although it runs natively. Omitted when there are none.
    /// </summary>
    [JsonPropertyName("toolGaps")]
    public IEnumerable<SimulationOnboardingToolGapDto>? ToolGaps { get; set; }

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
