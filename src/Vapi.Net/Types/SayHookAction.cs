using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SayHookAction : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the prompt for the assistant to generate a response based on existing conversation.
    /// Can be a string or an array of chat messages.
    /// </summary>
    [JsonPropertyName("prompt")]
    public OneOf<
        string,
        IEnumerable<
            OneOf<SystemMessage, UserMessage, AssistantMessage, ToolMessage, DeveloperMessage>
        >
    >? Prompt { get; set; }

    /// <summary>
    /// This is the message to say
    /// </summary>
    [JsonPropertyName("exact")]
    public object? Exact { get; set; }

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
