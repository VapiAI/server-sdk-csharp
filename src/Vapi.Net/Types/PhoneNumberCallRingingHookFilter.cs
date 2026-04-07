using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record PhoneNumberCallRingingHookFilter : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the type of filter - matches when the specified field starts with any of the given prefixes
    /// </summary>
    [JsonPropertyName("type")]
    public required PhoneNumberCallRingingHookFilterType Type { get; set; }

    /// <summary>
    /// The field to check. Currently only "number" (the caller's phone number) is supported.
    /// </summary>
    [JsonPropertyName("key")]
    public required PhoneNumberCallRingingHookFilterKey Key { get; set; }

    /// <summary>
    /// Array of prefixes to match. Do not include the + prefix. Inbound calls from numbers starting with any of these prefixes will trigger the hook actions.
    /// </summary>
    [JsonPropertyName("startsWith")]
    public IEnumerable<string> StartsWith { get; set; } = new List<string>();

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
