using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record MessageTarget : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the role of the message to target.
    ///
    /// If not specified, will find the position in the message history ignoring role (effectively `any`).
    /// </summary>
    [JsonPropertyName("role")]
    public MessageTargetRole? Role { get; set; }

    /// <summary>
    /// This is the position of the message to target.
    /// - Negative numbers: Count from end (-1 = most recent, -2 = second most recent)
    /// - 0: First/oldest message in history
    /// - Positive numbers: Specific position (0-indexed from start)
    ///
    /// @default -1 (most recent message)
    /// </summary>
    [JsonPropertyName("position")]
    public double? Position { get; set; }

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
