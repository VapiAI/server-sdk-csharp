using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record RuleBasedCondition
{
    /// <summary>
    /// This is the operator you want to use to compare the left side and right side.
    ///
    /// The operation becomes `(leftSide) operator (rightSide)`.
    /// </summary>
    [JsonPropertyName("operator")]
    public required RuleBasedConditionOperator Operator { get; set; }

    /// <summary>
    /// This is the left side of the operation.
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
    /// Or, you can use a constant:
    /// - "1"
    /// - "text"
    /// - "true"
    /// - "false"
    ///
    /// Or, you can mix and match with string interpolation:
    /// - "{{your-property-name}}-{{input.your-property-name-2}}-1"
    ///
    /// Caveats:
    /// 1. a workflow can execute a step multiple times. example, if a loop is used in the graph. {{stepName.input/output.propertyName}} will reference the latest usage of the step.
    /// 2. a workflow can execute a block multiple times. example, if a step is called multiple times or if a block is used in multiple steps. {{blockName.input/output.propertyName}} will reference the latest usage of the block. this liquid variable is just provided for convenience when creating blocks outside of a workflow with steps.
    /// </summary>
    [JsonPropertyName("leftSide")]
    public required string LeftSide { get; set; }

    /// <summary>
    /// This is the right side of the operation.
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
    /// Or, you can use a constant:
    /// - "1"
    /// - "text"
    /// - "true"
    /// - "false"
    ///
    /// Or, you can mix and match with string interpolation:
    /// - "{{your-property-name}}-{{input.your-property-name-2}}-1"
    ///
    /// Caveats:
    /// 1. a workflow can execute a step multiple times. example, if a loop is used in the graph. {{stepName.input/output.propertyName}} will reference the latest usage of the step.
    /// 2. a workflow can execute a block multiple times. example, if a step is called multiple times or if a block is used in multiple steps. {{blockName.input/output.propertyName}} will reference the latest usage of the block. this liquid variable is just provided for convenience when creating blocks outside of a workflow with steps.
    /// </summary>
    [JsonPropertyName("rightSide")]
    public required string RightSide { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
