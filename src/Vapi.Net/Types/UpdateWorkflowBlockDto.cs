using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record UpdateWorkflowBlockDto
{
    /// <summary>
    /// These are the pre-configured messages that will be spoken to the user while the block is running.
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<object>? Messages { get; set; }

    /// <summary>
    /// This is the input schema for the block. This is the input the block needs to run. It's given to the block as `steps[0].input`
    ///
    /// These are accessible as variables:
    /// - ({{input.propertyName}}) in context of the block execution (step)
    /// - ({{stepName.input.propertyName}}) in context of the workflow
    /// </summary>
    [JsonPropertyName("inputSchema")]
    public JsonSchema? InputSchema { get; set; }

    /// <summary>
    /// This is the output schema for the block. This is the output the block will return to the workflow (`{{stepName.output}}`).
    ///
    /// These are accessible as variables:
    /// - ({{output.propertyName}}) in context of the block execution (step)
    /// - ({{stepName.output.propertyName}}) in context of the workflow (read caveat #1)
    /// - ({{blockName.output.propertyName}}) in context of the workflow (read caveat #2)
    ///
    /// Caveats:
    /// 1. a workflow can execute a step multiple times. example, if a loop is used in the graph. {{stepName.output.propertyName}} will reference the latest usage of the step.
    /// 2. a workflow can execute a block multiple times. example, if a step is called multiple times or if a block is used in multiple steps. {{blockName.output.propertyName}} will reference the latest usage of the block. this liquid variable is just provided for convenience when creating blocks outside of a workflow with steps.
    /// </summary>
    [JsonPropertyName("outputSchema")]
    public JsonSchema? OutputSchema { get; set; }

    /// <summary>
    /// These are the steps in the workflow.
    /// </summary>
    [JsonPropertyName("steps")]
    public IEnumerable<object>? Steps { get; set; }

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
