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
    /// The ID of an existing structured output to evaluate. Use this to reuse a structured output across scenarios. Provide either `structuredOutputId` or an inline `structuredOutput`.
    /// </summary>
    [JsonPropertyName("structuredOutputId")]
    public string? StructuredOutputId { get; set; }

    /// <summary>
    /// An inline structured output to evaluate, defined by its name and schema. Only primitive types (string, number, integer, boolean) are allowed. Provide either this or `structuredOutputId`.
    /// </summary>
    [JsonPropertyName("structuredOutput")]
    public CreateStructuredOutputDto? StructuredOutput { get; set; }

    /// <summary>
    /// Optional dot-notation path to a primitive leaf when evaluating an object structured output.
    /// </summary>
    [JsonPropertyName("path")]
    public string? Path { get; set; }

    /// <summary>
    /// How the structured output value is compared against `value`. Available operators depend on the output type. Boolean and string support `=` and `!=`; number and integer support `=`, `!=`, `&gt;`, `&lt;`, `&gt;=`, `&lt;=`.
    /// </summary>
    [JsonPropertyName("comparator")]
    public required EvaluationPlanItemComparator Comparator { get; set; }

    /// <summary>
    /// The expected value the structured output is compared against. Its type should match the structured output's type, for example `true` for a boolean.
    /// </summary>
    [JsonPropertyName("value")]
    public required OneOf<double, string, bool> Value { get; set; }

    /// <summary>
    /// Set to `false` to record this evaluation's result without requiring it to pass. Default is `true`.
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
