using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CreateEvalDto : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the mock conversation that will be used to evaluate the flow of the conversation.
    ///
    /// Mock Messages are used to simulate the flow of the conversation
    ///
    /// Evaluation Messages are used as checkpoints in the flow where the model's response to previous conversation needs to be evaluated to check the content and tool calls
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<
        OneOf<
            ChatEvalAssistantMessageMock,
            ChatEvalSystemMessageMock,
            ChatEvalToolResponseMessageMock,
            ChatEvalToolResponseMessageEvaluation,
            ChatEvalUserMessageMock,
            ChatEvalAssistantMessageEvaluation
        >
    > Messages { get; set; } =
        new List<
            OneOf<
                ChatEvalAssistantMessageMock,
                ChatEvalSystemMessageMock,
                ChatEvalToolResponseMessageMock,
                ChatEvalToolResponseMessageEvaluation,
                ChatEvalUserMessageMock,
                ChatEvalAssistantMessageEvaluation
            >
        >();

    /// <summary>
    /// This is the name of the eval.
    /// It helps identify what the eval is checking for.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the description of the eval.
    /// This helps describe the eval and its purpose in detail. It will not be used to evaluate the flow of the conversation.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// This is the type of the eval.
    /// Currently it is fixed to `chat.mockConversation`.
    /// </summary>
    [JsonPropertyName("type")]
    public required CreateEvalDtoType Type { get; set; }

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
