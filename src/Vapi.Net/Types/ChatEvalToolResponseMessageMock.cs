using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ChatEvalToolResponseMessageMock : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the role of the message author.
    /// For a mock tool response message, the role is always 'tool'
    /// @default 'tool'
    /// </summary>
    [JsonPropertyName("role")]
    public required ChatEvalToolResponseMessageMockRole Role { get; set; }

    /// <summary>
    /// This is the content of the tool response message. JSON Objects should be stringified.
    /// </summary>
    [JsonPropertyName("content")]
    public required string Content { get; set; }

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
