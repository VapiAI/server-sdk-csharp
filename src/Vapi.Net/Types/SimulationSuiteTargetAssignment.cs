using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationSuiteTargetAssignment : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the type of target assigned to the simulation suite.
    /// </summary>
    [JsonPropertyName("targetType")]
    public required SimulationSuiteTargetAssignmentTargetType TargetType { get; set; }

    /// <summary>
    /// This is the unique identifier of the assigned assistant or squad.
    /// </summary>
    [JsonPropertyName("targetId")]
    public required string TargetId { get; set; }

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
