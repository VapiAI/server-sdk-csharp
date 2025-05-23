using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record VariableExtractionSchema
{
    /// <summary>
    /// This is the type of output you'd like.
    ///
    /// `string`, `number`, `boolean` are primitive types.
    /// </summary>
    [JsonPropertyName("type")]
    public required VariableExtractionSchemaType Type { get; set; }

    /// <summary>
    /// This is the title of the variable.
    ///
    /// It can only contain letters, numbers, and underscores.
    /// </summary>
    [JsonPropertyName("title")]
    public required string Title { get; set; }

    /// <summary>
    /// This is the description to help the model understand what it needs to output.
    /// </summary>
    [JsonPropertyName("description")]
    public required string Description { get; set; }

    /// <summary>
    /// This is the enum values to choose from. Only used if the type is `string`.
    /// </summary>
    [JsonPropertyName("enum")]
    public IEnumerable<string>? Enum { get; set; }

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
