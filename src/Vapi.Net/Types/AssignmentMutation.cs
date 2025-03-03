using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record AssignmentMutation
{
    /// <summary>
    /// This is an optional array of conditions that must be met for this mutation to be triggered.
    /// </summary>
    [JsonPropertyName("conditions")]
    public IEnumerable<object>? Conditions { get; set; }

    /// <summary>
    /// This mutation assigns a new value to an existing or new variable.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "assignment";

    /// <summary>
    /// This is the variable to assign a new value to.
    ///
    /// You can reference any variable in the context of the current block execution (step):
    /// - "output.your-property-name" for current step's output
    /// - "your-step-name.output.your-property-name" for another step's output (in the same workflow; read caveat #1)
    /// - "your-block-name.output.your-property-name" for another block's output (in the same workflow; read caveat #2)
    /// - "global.your-property-name" for the global context
    ///
    /// This needs to be the key path of the variable. If you use {{}}, it'll dereference that to the value of the variable before assignment. This can be useful if the path is dynamic. Example:
    /// - "global.{{my-tool-call-step.output.my-key-name}}"
    ///
    /// You can also string interpolate multiple variables to get the key name:
    /// - "global.{{my-tool-call-step.output.my-key-name-suffix}}-{{my-tool-call-step.output.my-key-name}}"
    ///
    /// The path to the new variable is created if it doesn't exist. Example:
    /// - "global.this-does-not-exist.neither-does-this" will create `this-does-not-exist` object with `neither-does-this` as a key
    ///
    /// Caveats:
    /// 1. a workflow can execute a step multiple times. example, if a loop is used in the graph. {{stepName.output.propertyName}} will reference the latest usage of the step.
    /// 2. a workflow can execute a block multiple times. example, if a step is called multiple times or if a block is used in multiple steps. {{blockName.output.propertyName}} will reference the latest usage of the block. this liquid variable is just provided for convenience when creating blocks outside of a workflow.
    /// </summary>
    [JsonPropertyName("variable")]
    public required string Variable { get; set; }

    /// <summary>
    /// The value to assign to the variable.
    ///
    /// You can reference any variable in the context of the current block execution (step):
    /// - "{{output.your-property-name}}" for current step's output
    /// - "{{your-step-name.output.your-property-name}}" for another step's output (in the same workflow; read caveat #1)
    /// - "{{your-block-name.output.your-property-name}}" for another block's output (in the same workflow; read caveat #2)
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
    /// 1. a workflow can execute a step multiple times. example, if a loop is used in the graph. {{stepName.output.propertyName}} will reference the latest usage of the step.
    /// 2. a workflow can execute a block multiple times. example, if a step is called multiple times or if a block is used in multiple steps. {{blockName.output.propertyName}} will reference the latest usage of the block. this liquid variable is just provided for convenience when creating blocks outside of a workflow.
    /// </summary>
    [JsonPropertyName("value")]
    public required string Value { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
