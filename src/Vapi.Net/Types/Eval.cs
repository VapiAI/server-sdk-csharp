using System.Text.Json;
using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record Eval
{
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

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

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
    public required EvalType Type { get; set; }

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
