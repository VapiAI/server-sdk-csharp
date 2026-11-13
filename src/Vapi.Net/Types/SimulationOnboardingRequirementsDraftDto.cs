using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationOnboardingRequirementsDraftDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Draft version, 1 for a first draft.
    /// </summary>
    [JsonPropertyName("version")]
    public required double Version { get; set; }

    /// <summary>
    /// What changed since the previous draft.
    /// </summary>
    [JsonPropertyName("changeNote")]
    public string? ChangeNote { get; set; }

    /// <summary>
    /// What the draft was based on, e.g. the prompt and tools.
    /// </summary>
    [JsonPropertyName("sources")]
    public IEnumerable<string> Sources { get; set; } = new List<string>();

    /// <summary>
    /// Draft test requirements describing the expected assistant behavior. Review and refine these before generating a simulation suite.
    /// </summary>
    [JsonPropertyName("requirements")]
    public IEnumerable<SimulationOnboardingRequirementDto> Requirements { get; set; } =
        new List<SimulationOnboardingRequirementDto>();

    /// <summary>
    /// Questions about ambiguous or missing assistant behavior to resolve before generating a simulation suite.
    /// </summary>
    [JsonPropertyName("openQuestions")]
    public IEnumerable<SimulationOnboardingOpenQuestionDto> OpenQuestions { get; set; } =
        new List<SimulationOnboardingOpenQuestionDto>();

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
