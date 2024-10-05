using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record CallbackStep
{
    /// <summary>
    /// This is the block to use. To use an existing block, use `blockId`.
    /// </summary>
    [JsonPropertyName("block")]
    public OneOf<
        CreateConversationBlockDto,
        CreateToolCallBlockDto,
        CreateWorkflowBlockDto
    >? Block { get; set; }

    /// <summary>
    /// This is a step that calls back to the previous step after it's done. This effectively means we're spawning a new conversation thread. The previous conversation thread will resume where it left off once this step is done.
    ///
    /// Use case:
    ///
    /// - You are collecting a customer's order and while they were on one item, they start a new item or try to modify a previous one. You would make a OrderUpdate block which calls the same block repeatedly when a new update starts.
    /// </summary>
    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// This is the mutations to apply to the context after the step is done.
    /// </summary>
    [JsonPropertyName("mutations")]
    public IEnumerable<AssignmentMutation>? Mutations { get; set; }

    /// <summary>
    /// This is the name of the step.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// This is the id of the block to use. To use a transient block, use `block`.
    /// </summary>
    [JsonPropertyName("blockId")]
    public string? BlockId { get; set; }

    /// <summary>
    /// This is the input to the block. You can use any key-value map as input to the block.
    ///
    /// Example:
    /// {
    /// "name": "John Doe",
    /// "age": 20
    /// }
    ///
    /// You can reference any variable in the context of the current block:
    ///
    /// - "{{your-step-name.output.your-property-name}}" for another step's output (in the same workflow; read caveat #1)
    /// - "{{your-step-name.input.your-property-name}}" for another step's input (in the same workflow; read caveat #1)
    /// - "{{your-block-name.output.your-property-name}}" for another block's output (in the same workflow; read caveat #2)
    /// - "{{your-block-name.input.your-property-name}}" for another block's input (in the same workflow; read caveat #2)
    /// - "{{workflow.input.your-property-name}}" for the current workflow's input
    /// - "{{global.your-property-name}}" for the global context
    ///
    /// Example:
    /// {
    /// "name": "{{my-tool-call-step.output.name}}",
    /// "age": "{{my-tool-call-step.input.age}}",
    /// "date": "{{workflow.input.date}}"
    /// }
    ///
    /// You can dynamically change the key name.
    ///
    /// Example:
    /// {
    /// "{{my-tool-call-step.output.key-name-for-name}}": "{{name}}",
    /// "{{my-tool-call-step.input.key-name-for-age}}": "{{age}}",
    /// "{{workflow.input.key-name-for-date}}": "{{date}}"
    /// }
    ///
    /// You can represent the value as a string, number, boolean, array, or object.
    ///
    /// Example:
    /// {
    /// "name": "john",
    /// "age": 20,
    /// "date": "2021-01-01",
    /// "metadata": {
    /// "unique-key": "{{my-tool-call-step.output.unique-key}}"
    /// },
    /// "array": ["A", "B", "C"],
    /// }
    ///
    /// Caveats:
    ///
    /// 1. a workflow can execute a step multiple times. example, if a loop is used in the graph. {{stepName.input/output.propertyName}} will reference the latest usage of the step.
    /// 2. a workflow can execute a block multiple times. example, if a step is called multiple times or if a block is used in multiple steps. {{blockName.input/output.propertyName}} will reference the latest usage of the block. this liquid variable is just provided for convenience when creating blocks outside of a workflow.
    /// </summary>
    [JsonPropertyName("input")]
    public object? Input { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
