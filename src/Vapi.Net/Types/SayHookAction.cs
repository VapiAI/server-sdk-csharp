using System.Text.Json;
using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record SayHookAction
{
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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
