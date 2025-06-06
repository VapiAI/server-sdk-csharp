using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ConversationNode
{
    /// <summary>
    /// This is the model for the Conversation Task.
    /// </summary>
    [JsonPropertyName("model")]
    public object? Model { get; set; }

    /// <summary>
    /// These are the options for the assistant's transcriber.
    /// </summary>
    [JsonPropertyName("transcriber")]
    public object? Transcriber { get; set; }

    /// <summary>
    /// These are the options for the assistant's voice.
    /// </summary>
    [JsonPropertyName("voice")]
    public object? Voice { get; set; }

    [JsonPropertyName("prompt")]
    public string? Prompt { get; set; }

    /// <summary>
    /// This is the plan for the global node.
    /// </summary>
    [JsonPropertyName("globalNodePlan")]
    public GlobalNodePlan? GlobalNodePlan { get; set; }

    /// <summary>
    /// This is the plan that controls the variable extraction from the user's response.
    /// </summary>
    [JsonPropertyName("variableExtractionPlan")]
    public VariableExtractionPlan? VariableExtractionPlan { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// This is whether or not the node is the start of the workflow.
    /// </summary>
    [JsonPropertyName("isStart")]
    public bool? IsStart { get; set; }

    /// <summary>
    /// This is for metadata you want to store on the task.
    /// </summary>
    [JsonPropertyName("metadata")]
    public object? Metadata { get; set; }

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
