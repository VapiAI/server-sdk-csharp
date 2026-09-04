using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ScenarioToolMock : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// The name of the assistant or squad's tool to mock. Must match the tool's name exactly.
    /// </summary>
    [JsonPropertyName("toolName")]
    public required string ToolName { get; set; }

    /// <summary>
    /// The result string returned to the assistant or squad in place of calling the real tool.
    /// </summary>
    [JsonPropertyName("result")]
    public string? Result { get; set; }

    /// <summary>
    /// Set to `true` to apply this mock during the simulation. Defaults to `true`.
    /// </summary>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }

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
