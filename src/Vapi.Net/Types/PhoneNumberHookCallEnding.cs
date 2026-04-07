using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record PhoneNumberHookCallEnding : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Optional filters to decide when to trigger - restricted to assistant-request related ended reasons
    /// </summary>
    [JsonPropertyName("filters")]
    public IEnumerable<PhoneNumberCallEndingHookFilter>? Filters { get; set; }

    /// <summary>
    /// This is the action to perform when the hook triggers
    /// </summary>
    [JsonPropertyName("do")]
    public object? Do { get; set; }

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
