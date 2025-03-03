using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ModelBasedCondition
{
    /// <summary>
    /// This is the instruction which should output a boolean value when passed to a model.
    ///
    /// You can reference any variable in the context of the current block execution (step):
    /// - "{{output.your-property-name}}" for current step's output
    /// - "{{input.your-property-name}}" for current step's input
    /// - "{{your-step-name.output.your-property-name}}" for another step's output (in the same workflow; read caveat #1)
    /// - "{{your-step-name.input.your-property-name}}" for another step's input (in the same workflow; read caveat #1)
    /// - "{{your-block-name.output.your-property-name}}" for another block's output (in the same workflow; read caveat #2)
    /// - "{{your-block-name.input.your-property-name}}" for another block's input (in the same workflow; read caveat #2)
    /// - "{{workflow.input.your-property-name}}" for the current workflow's input
    /// - "{{global.your-property-name}}" for the global context
    ///
    /// You can also talk about the current step's output or input directly:
    /// - "{{output.your-property-name}} is greater than 10"
    /// - "{{input.your-property-name}} is greater than 10"
    ///
    /// Examples:
    ///  - "{{input.age}} is greater than 10"
    ///  - "{{input.age}} is greater than {{input.age2}}"
    ///  - "{{output.age}} is greater than 10"
    ///
    /// Caveats:
    /// 1. a workflow can execute a step multiple times. example, if a loop is used in the graph. {{stepName.input/output.propertyName}} will reference the latest usage of the step.
    /// 2. a workflow can execute a block multiple times. example, if a step is called multiple times or if a block is used in multiple steps. {{blockName.input/output.propertyName}} will reference the latest usage of the block. this liquid variable is just provided for convenience when creating blocks outside of a workflow with steps.
    /// </summary>
    [JsonPropertyName("instruction")]
    public required string Instruction { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
