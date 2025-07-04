using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record OpenAiFunction
{
    /// <summary>
    /// This is a boolean that controls whether to enable strict schema adherence when generating the function call. If set to true, the model will follow the exact schema defined in the parameters field. Only a subset of JSON Schema is supported when strict is true. Learn more about Structured Outputs in the [OpenAI guide](https://openai.com/index/introducing-structured-outputs-in-the-api/).
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("strict")]
    public bool? Strict { get; set; }

    /// <summary>
    /// This is the the name of the function to be called.
    ///
    /// Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

    /// <summary>
    /// This is the description of what the function does, used by the AI to choose when and how to call the function.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// These are the parameters the functions accepts, described as a JSON Schema object.
    ///
    /// See the [OpenAI guide](https://platform.openai.com/docs/guides/function-calling) for examples, and the [JSON Schema reference](https://json-schema.org/understanding-json-schema) for documentation about the format.
    ///
    /// Omitting parameters defines a function with an empty parameter list.
    /// </summary>
    [JsonPropertyName("parameters")]
    public OpenAiFunctionParameters? Parameters { get; set; }

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
