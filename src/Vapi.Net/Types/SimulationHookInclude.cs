using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SimulationHookInclude : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Include transcript in the hook payload
    /// </summary>
    [JsonPropertyName("transcript")]
    public bool? Transcript { get; set; }

    /// <summary>
    /// Include messages in the hook payload
    /// </summary>
    [JsonPropertyName("messages")]
    public bool? Messages { get; set; }

    /// <summary>
    /// Include recordingUrl in the hook payload
    /// </summary>
    [JsonPropertyName("recordingUrl")]
    public bool? RecordingUrl { get; set; }

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
