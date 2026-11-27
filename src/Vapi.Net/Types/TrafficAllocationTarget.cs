using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TrafficAllocationTarget : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The assistant version this target sends calls to, such as "v7".
    /// </summary>
    [JsonPropertyName("assistantVersion")]
    public required string AssistantVersion { get; set; }

    /// <summary>
    /// The target's place in the split, starting at 0. Set from the order of the targets array.
    /// </summary>
    [JsonPropertyName("position")]
    public required double Position { get; set; }

    /// <summary>
    /// Share of calls sent to this version, from 0 to 100 with up to three decimal places. Targets add up to exactly 100. A 0% target keeps the version in the split without sending it calls.
    /// </summary>
    [JsonPropertyName("percentage")]
    public required double Percentage { get; set; }

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
