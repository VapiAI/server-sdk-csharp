using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record UpdateStructuredOutputDto
{
    [JsonIgnore]
    public required string SchemaOverride { get; set; }

    /// <summary>
    /// This is the type of structured output.
    ///
    /// - 'ai': Uses an LLM to extract structured data from the conversation (default).
    /// - 'regex': Uses a regex pattern to extract data from the transcript without an LLM.
    /// </summary>
    [JsonPropertyName("type")]
    public UpdateStructuredOutputDtoType? Type { get; set; }

    /// <summary>
    /// This is the regex pattern to match against the transcript.
    ///
    /// Only used when type is 'regex'. Supports both raw patterns (e.g. '\d+') and
    /// regex literal format (e.g. '/\d+/gi'). Uses RE2 syntax for safety.
    ///
    /// The result depends on the schema type:
    /// - boolean: true if the pattern matches, false otherwise
    /// - string: the first match or first capture group
    /// - number/integer: the first match parsed as a number
    /// - array: all matches
    /// </summary>
    [JsonPropertyName("regex")]
    public string? Regex { get; set; }

    /// <summary>
    /// This is the model that will be used to extract the structured output.
    ///
    /// To provide your own custom system and user prompts for structured output extraction, populate the messages array with your system and user messages. You can specify liquid templating in your system and user messages.
    /// Between the system or user messages, you must reference either 'transcript' or 'messages' with the `{{}}` syntax to access the conversation history.
    /// Between the system or user messages, you must reference a variation of the structured output with the `{{}}` syntax to access the structured output definition.
    /// i.e.:
    /// `{{structuredOutput}}`
    /// `{{structuredOutput.name}}`
    /// `{{structuredOutput.description}}`
    /// `{{structuredOutput.schema}}`
    ///
    /// If model is not specified, GPT-4.1 will be used by default for extraction, utilizing default system and user prompts.
    /// If messages or required fields are not specified, the default system and user prompts will be used.
    /// </summary>
    [JsonPropertyName("model")]
    public object? Model { get; set; }

    /// <summary>
    /// Compliance configuration for this output. Only enable overrides if no sensitive data will be stored.
    /// </summary>
    [JsonPropertyName("compliancePlan")]
    public ComplianceOverride? CompliancePlan { get; set; }

    /// <summary>
    /// This is the name of the structured output.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the description of what the structured output extracts.
    ///
    /// Use this to provide context about what data will be extracted and how it will be used.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// These are the assistant IDs that this structured output is linked to.
    ///
    /// When linked to assistants, this structured output will be available for extraction during those assistant's calls.
    /// </summary>
    [JsonPropertyName("assistantIds")]
    public IEnumerable<string>? AssistantIds { get; set; }

    /// <summary>
    /// These are the workflow IDs that this structured output is linked to.
    ///
    /// When linked to workflows, this structured output will be available for extraction during those workflow's execution.
    /// </summary>
    [JsonPropertyName("workflowIds")]
    public IEnumerable<string>? WorkflowIds { get; set; }

    /// <summary>
    /// This is the JSON Schema definition for the structured output.
    ///
    /// Defines the structure and validation rules for the data that will be extracted. Supports all JSON Schema features including:
    /// - Objects and nested properties
    /// - Arrays and array validation
    /// - String, number, boolean, and null types
    /// - Enums and const values
    /// - Validation constraints (min/max, patterns, etc.)
    /// - Composition with allOf, anyOf, oneOf
    /// </summary>
    [JsonPropertyName("schema")]
    public JsonSchema? Schema { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
