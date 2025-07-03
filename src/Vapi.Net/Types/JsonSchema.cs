using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record JsonSchema
{
    /// <summary>
    /// This is the type of output you'd like.
    ///
    /// `string`, `number`, `integer`, `boolean` are the primitive types and should be obvious.
    ///
    /// `array` and `object` are more interesting and quite powerful. They allow you to define nested structures.
    ///
    /// For `array`, you can define the schema of the items in the array using the `items` property.
    ///
    /// For `object`, you can define the properties of the object using the `properties` property.
    /// </summary>
    [JsonPropertyName("type")]
    public required JsonSchemaType Type { get; set; }

    /// <summary>
    /// This is required if the type is "array". This is the schema of the items in the array.
    ///
    /// This is of type JsonSchema. However, Swagger doesn't support circular references.
    /// </summary>
    [JsonPropertyName("items")]
    public object? Items { get; set; }

    /// <summary>
    /// This is required if the type is "object". This specifies the properties of the object.
    ///
    /// This is a map of string to JsonSchema. However, Swagger doesn't support circular references.
    /// </summary>
    [JsonPropertyName("properties")]
    public object? Properties { get; set; }

    /// <summary>
    /// This is the description to help the model understand what it needs to output.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// This is the pattern of the string. This is a regex that will be used to validate the data in question. To use a common format, use the `format` property instead.
    ///
    /// OpenAI documentation: https://platform.openai.com/docs/guides/structured-outputs#supported-properties
    /// </summary>
    [JsonPropertyName("pattern")]
    public string? Pattern { get; set; }

    /// <summary>
    /// This is the format of the string. To pass a regex, use the `pattern` property instead.
    ///
    /// OpenAI documentation: https://platform.openai.com/docs/guides/structured-outputs?api-mode=chat&type-restrictions=string-restrictions
    /// </summary>
    [JsonPropertyName("format")]
    public JsonSchemaFormat? Format { get; set; }

    /// <summary>
    /// This is a list of properties that are required.
    ///
    /// This only makes sense if the type is "object".
    /// </summary>
    [JsonPropertyName("required")]
    public IEnumerable<string>? Required { get; set; }

    /// <summary>
    /// This array specifies the allowed values that can be used to restrict the output of the model.
    /// </summary>
    [JsonPropertyName("enum")]
    public IEnumerable<string>? Enum { get; set; }

    /// <summary>
    /// This is the title of the schema.
    /// </summary>
    [JsonPropertyName("title")]
    public string? Title { get; set; }

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
