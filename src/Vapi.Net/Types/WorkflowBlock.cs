using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record WorkflowBlock
{
    /// <summary>
    /// These are the pre-configured messages that will be spoken to the user while the block is running.
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<OneOf<BlockStartMessage, BlockCompleteMessage>>? Messages { get; set; }

    /// <summary>
    /// This is the input schema for the block. This is the input the block needs to run. It's given to the block as `steps[0].input`
    ///
    /// These are accessible as variables:
    ///
    /// - ({{input.propertyName}}) in context of the block execution (step)
    /// - ({{stepName.input.propertyName}}) in context of the workflow
    /// </summary>
    [JsonPropertyName("inputSchema")]
    public JsonSchema? InputSchema { get; set; }

    /// <summary>
    /// This is the output schema for the block. This is the output the block will return to the workflow (`{{stepName.output}}`).
    ///
    /// These are accessible as variables:
    ///
    /// - ({{output.propertyName}}) in context of the block execution (step)
    /// - ({{stepName.output.propertyName}}) in context of the workflow (read caveat #1)
    /// - ({{blockName.output.propertyName}}) in context of the workflow (read caveat #2)
    ///
    /// Caveats:
    ///
    /// 1. a workflow can execute a step multiple times. example, if a loop is used in the graph. {{stepName.output.propertyName}} will reference the latest usage of the step.
    /// 2. a workflow can execute a block multiple times. example, if a step is called multiple times or if a block is used in multiple steps. {{blockName.output.propertyName}} will reference the latest usage of the block. this liquid variable is just provided for convenience when creating blocks outside of a workflow with steps.
    /// </summary>
    [JsonPropertyName("outputSchema")]
    public JsonSchema? OutputSchema { get; set; }

    [JsonPropertyName("type")]
    public required string Type { get; set; }

    /// <summary>
    /// These are the steps in the workflow.
    /// </summary>
    [JsonPropertyName("steps")]
    public IEnumerable<OneOf<HandoffStep, CallbackStep>>? Steps { get; set; }

    /// <summary>
    /// This is the unique identifier for the block.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the unique identifier for the organization that this block belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the block was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the block was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// This is the name of the block. This is just for your reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
