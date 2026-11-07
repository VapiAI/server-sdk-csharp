using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationOnboardingToolGapDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Function name of the tool, e.g. `handoff_to_group_1` or `transferCall`.
    /// </summary>
    [JsonPropertyName("toolName")]
    public required string ToolName { get; set; }

    /// <summary>
    /// Assistant the tool belongs to, when it is a handoff destination's tool. Unset for the assistant's own tools.
    /// </summary>
    [JsonPropertyName("assistantName")]
    public string? AssistantName { get; set; }

    /// <summary>
    /// Why the path is not exercised: a reason the simulations mock the tool, or why a native path is never reached. New reasons may be added.
    /// </summary>
    [JsonPropertyName("reason")]
    public required SimulationOnboardingToolGapDtoReason Reason { get; set; }

    /// <summary>
    /// Static destinations the simulations do not reach through this tool.
    /// </summary>
    [JsonPropertyName("destinationNames")]
    public IEnumerable<string>? DestinationNames { get; set; }

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
