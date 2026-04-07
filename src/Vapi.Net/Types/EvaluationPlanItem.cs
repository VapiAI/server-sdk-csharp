using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record EvaluationPlanItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the ID of an existing structured output to use for evaluation.
    /// Mutually exclusive with structuredOutput.
    /// </summary>
    [JsonPropertyName("structuredOutputId")]
    public string? StructuredOutputId { get; set; }

    /// <summary>
    /// This is an inline structured output definition for evaluation.
    /// Mutually exclusive with structuredOutputId.
    /// Only primitive schema types (string, number, integer, boolean) are allowed.
    /// </summary>
    [JsonPropertyName("structuredOutput")]
    public CreateStructuredOutputDto? StructuredOutput { get; set; }

    /// <summary>
    /// This is the comparison operator to use when evaluating the extracted value against the expected value.
    /// Available operators depend on the structured output's schema type:
    /// - boolean: '=', '!='
    /// - string: '=', '!='
    /// - number/integer: '=', '!=', '&gt;', '&lt;', '&gt;=', '&lt;='
    /// </summary>
    [JsonPropertyName("comparator")]
    public required EvaluationPlanItemComparator Comparator { get; set; }

    /// <summary>
    /// This is the expected value to compare against the extracted structured output result.
    /// Type should match the structured output's schema type.
    /// </summary>
    [JsonPropertyName("value")]
    public required OneOf<double, string, bool> Value { get; set; }

    /// <summary>
    /// This is whether this evaluation must pass for the simulation to pass.
    /// Defaults to true. If false, the result is informational only.
    /// </summary>
    [JsonPropertyName("required")]
    public bool? Required { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
