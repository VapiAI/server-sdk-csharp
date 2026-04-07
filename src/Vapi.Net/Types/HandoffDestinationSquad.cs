using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record HandoffDestinationSquad : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the plan for manipulating the message context before handing off the call to the squad.
    /// </summary>
    [JsonPropertyName("contextEngineeringPlan")]
    public object? ContextEngineeringPlan { get; set; }

    /// <summary>
    /// This is the squad id to transfer the call to.
    /// </summary>
    [JsonPropertyName("squadId")]
    public string? SquadId { get; set; }

    /// <summary>
    /// This is a transient squad to transfer the call to.
    /// </summary>
    [JsonPropertyName("squad")]
    public CreateSquadDto? Squad { get; set; }

    /// <summary>
    /// This is the name of the entry assistant to start with when handing off to the squad.
    /// If not provided, the first member of the squad will be used.
    /// </summary>
    [JsonPropertyName("entryAssistantName")]
    public string? EntryAssistantName { get; set; }

    /// <summary>
    /// This is the variable extraction plan for the handoff tool.
    /// </summary>
    [JsonPropertyName("variableExtractionPlan")]
    public VariableExtractionPlan? VariableExtractionPlan { get; set; }

    /// <summary>
    /// These are the overrides to apply to the squad configuration.
    /// Maps to squad-level membersOverrides.
    /// </summary>
    [JsonPropertyName("squadOverrides")]
    public AssistantOverrides? SquadOverrides { get; set; }

    /// <summary>
    /// This is the description of the destination, used by the AI to choose when and how to transfer the call.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

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
