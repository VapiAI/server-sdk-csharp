using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateTrafficAllocationTargetDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// A published version of this assistant, such as "v7". To split onto a new version, publish it first, then create the allocation.
    /// </summary>
    [JsonPropertyName("assistantVersion")]
    public required string AssistantVersion { get; set; }

    /// <summary>
    /// Share of calls sent to this version, from 0 to 100 with up to three decimal places. Finer values are rejected, not rounded. All targets together add up to exactly 100. Position is taken from array order.
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
