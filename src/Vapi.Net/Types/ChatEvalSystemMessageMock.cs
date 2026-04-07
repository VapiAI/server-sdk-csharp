using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ChatEvalSystemMessageMock : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the role of the message author.
    /// For a mock system message, the role is always 'system'
    /// @default 'system'
    /// </summary>
    [JsonPropertyName("role")]
    public required ChatEvalSystemMessageMockRole Role { get; set; }

    /// <summary>
    /// This is the content of the system message that would have been added in the middle of the conversation.
    /// Do not include the assistant prompt as a part of this message. It will automatically be fetched during runtime.
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
