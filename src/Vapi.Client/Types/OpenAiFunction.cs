using System.Text.Json.Serialization;
using Vapi.Client.Core;

#nullable enable

namespace Vapi.Client;

public record OpenAiFunction
{
    /// <summary>
    /// This is the the name of the function to be called.
    ///
    /// Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 64.
    /// </summary>
    [JsonPropertyName("name")]
    public required string Name { get; set; }

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

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}