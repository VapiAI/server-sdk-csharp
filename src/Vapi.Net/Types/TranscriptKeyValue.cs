using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TranscriptKeyValue : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the value as the answer key writes it. It matches the same words in
    /// the same order, ignoring case and punctuation, or the value spelled out letter
    /// by letter ("Maria" matches "M A R I A"). Split into different words, it
    /// scores near ("HubSpot" heard as "hub spot"), so list such forms in
    /// acceptedVariants when the value is required.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }

    /// <summary>
    /// These are other spellings that count as the same value, such as "Rayner"
    /// for "Raynor".
    /// </summary>
    [JsonPropertyName("acceptedVariants")]
    public IEnumerable<string>? AcceptedVariants { get; set; }

    /// <summary>
    /// This is whether the simulation fails unless this value comes through
    /// exactly. Defaults to false: the verdict is reported but does not decide
    /// pass or fail.
    /// </summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

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
