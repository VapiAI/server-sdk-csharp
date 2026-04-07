using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CartesiaGenerationConfig : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Fine-grained speed control for sonic-3. Only available for sonic-3 model.
    /// </summary>
    [JsonPropertyName("speed")]
    public double? Speed { get; set; }

    /// <summary>
    /// Fine-grained volume control for sonic-3. Only available for sonic-3 model.
    /// </summary>
    [JsonPropertyName("volume")]
    public double? Volume { get; set; }

    /// <summary>
    /// Experimental model controls for sonic-3. These are subject to breaking changes.
    /// </summary>
    [JsonPropertyName("experimental")]
    public CartesiaGenerationConfigExperimental? Experimental { get; set; }

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
