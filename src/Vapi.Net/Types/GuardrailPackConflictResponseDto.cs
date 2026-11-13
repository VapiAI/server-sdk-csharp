using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record GuardrailPackConflictResponseDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// Machine-readable cause; clients branch on this, never on `message`.
    /// </summary>
    [JsonPropertyName("error")]
    public required GuardrailPackConflictResponseDtoError Error { get; set; }

    /// <summary>
    /// Sentence-case copy safe to show the user.
    /// </summary>
    [JsonPropertyName("message")]
    public required string Message { get; set; }

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
