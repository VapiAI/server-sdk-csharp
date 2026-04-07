using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record PhoneNumberCallEndingHookFilter : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the type of filter - currently only "oneOf" is supported
    /// </summary>
    [JsonPropertyName("type")]
    public required PhoneNumberCallEndingHookFilterType Type { get; set; }

    /// <summary>
    /// This is the key to filter on - only "call.endedReason" is allowed for phone number call ending hooks
    /// </summary>
    [JsonPropertyName("key")]
    public required PhoneNumberCallEndingHookFilterKey Key { get; set; }

    /// <summary>
    /// This is the array of assistant-request related ended reasons to match against
    /// </summary>
    [JsonPropertyName("oneOf")]
    public IEnumerable<PhoneNumberCallEndingHookFilterOneOfItem> OneOf { get; set; } =
        new List<PhoneNumberCallEndingHookFilterOneOfItem>();

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
