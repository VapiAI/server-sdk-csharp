using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record HandoffDestinationAssistant
{
    /// <summary>
    /// This is the plan for manipulating the message context before handing off the call to the next assistant.
    /// </summary>
    [JsonPropertyName("contextEngineeringPlan")]
    public object? ContextEngineeringPlan { get; set; }

    /// <summary>
    /// This is the assistant to transfer the call to. You must provide either assistantName or assistantId.
    /// </summary>
    [JsonPropertyName("assistantName")]
    public string? AssistantName { get; set; }

    /// <summary>
    /// This is the assistant id to transfer the call to. You must provide either assistantName or assistantId.
    /// </summary>
    [JsonPropertyName("assistantId")]
    public string? AssistantId { get; set; }

    /// <summary>
    /// This is a transient assistant to transfer the call to. You may provide a transient assistant in the response  `handoff-destination-request` in a dynamic handoff.
    /// </summary>
    [JsonPropertyName("assistant")]
    public CreateAssistantDto? Assistant { get; set; }

    /// <summary>
    /// This is the variable extraction plan for the handoff tool.
    /// </summary>
    [JsonPropertyName("variableExtractionPlan")]
    public VariableExtractionPlan? VariableExtractionPlan { get; set; }

    /// <summary>
    /// This is the description of the destination, used by the AI to choose when and how to transfer the call.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

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
