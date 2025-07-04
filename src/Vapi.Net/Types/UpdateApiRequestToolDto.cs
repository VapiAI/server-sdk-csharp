using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record UpdateApiRequestToolDto
{
    /// <summary>
    /// These are the messages that will be spoken to the user as the tool is running.
    ///
    /// For some tools, this is auto-filled based on special fields like `tool.destinations`. For others like the function tool, these can be custom configured.
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<object>? Messages { get; set; }

    [JsonPropertyName("method")]
    public UpdateApiRequestToolDtoMethod? Method { get; set; }

    /// <summary>
    /// This is the timeout in seconds for the request. Defaults to 20 seconds.
    ///
    /// @default 20
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>
    /// This is the function definition of the tool.
    ///
    /// For `endCall`, `transferCall`, and `dtmf` tools, this is auto-filled based on tool-specific fields like `tool.destinations`. But, even in those cases, you can provide a custom function definition for advanced use cases.
    ///
    /// An example of an advanced use case is if you want to customize the message that's spoken for `endCall` tool. You can specify a function where it returns an argument "reason". Then, in `messages` array, you can have many "request-complete" messages. One of these messages will be triggered if the `messages[].conditions` matches the "reason" argument.
    /// </summary>
    [JsonPropertyName("function")]
    public OpenAiFunction? Function { get; set; }

    /// <summary>
    /// This is the name of the tool. This will be passed to the model.
    ///
    /// Must be a-z, A-Z, 0-9, or contain underscores and dashes, with a maximum length of 40.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    /// <summary>
    /// This is the description of the tool. This will be passed to the model.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    /// <summary>
    /// This is where the request will be sent.
    /// </summary>
    [JsonPropertyName("url")]
    public string? Url { get; set; }

    /// <summary>
    /// This is the body of the request.
    /// </summary>
    [JsonPropertyName("body")]
    public JsonSchema? Body { get; set; }

    /// <summary>
    /// These are the headers to send in the request.
    /// </summary>
    [JsonPropertyName("headers")]
    public JsonSchema? Headers { get; set; }

    /// <summary>
    /// This is the backoff plan if the request fails. Defaults to undefined (the request will not be retried).
    ///
    /// @default undefined (the request will not be retried)
    /// </summary>
    [JsonPropertyName("backoffPlan")]
    public BackoffPlan? BackoffPlan { get; set; }

    /// <summary>
    /// This is the plan to extract variables from the tool's response. These will be accessible during the call and stored in `call.artifact.variableValues` after the call.
    ///
    /// Usage:
    /// 1. Use `aliases` to extract variables from the tool's response body. (Most common case)
    ///
    /// ```json
    /// {
    ///   "aliases": [
    ///     {
    ///       "key": "customerName",
    ///       "value": "{{customer.name}}"
    ///     },
    ///     {
    ///       "key": "customerAge",
    ///       "value": "{{customer.age}}"
    ///     }
    ///   ]
    /// }
    /// ```
    ///
    /// The tool response body is made available to the liquid template.
    ///
    /// 2. Use `aliases` to extract variables from the tool's response body if the response is an array.
    ///
    /// ```json
    /// {
    ///   "aliases": [
    ///     {
    ///       "key": "customerName",
    ///       "value": "{{$[0].name}}"
    ///     },
    ///     {
    ///       "key": "customerAge",
    ///       "value": "{{$[0].age}}"
    ///     }
    ///   ]
    /// }
    /// ```
    ///
    /// $ is a shorthand for the tool's response body. `$[0]` is the first item in the array. `$[n]` is the nth item in the array. Note, $ is available regardless of the response body type (both object and array).
    ///
    /// 3. Use `aliases` to extract variables from the tool's response headers.
    ///
    /// ```json
    /// {
    ///   "aliases": [
    ///     {
    ///       "key": "customerName",
    ///       "value": "{{tool.response.headers.customer-name}}"
    ///     },
    ///     {
    ///       "key": "customerAge",
    ///       "value": "{{tool.response.headers.customer-age}}"
    ///     }
    ///   ]
    /// }
    /// ```
    ///
    /// `tool.response` is made available to the liquid template. Particularly, both `tool.response.headers` and `tool.response.body` are available. Note, `tool.response` is available regardless of the response body type (both object and array).
    ///
    /// 4. Use `schema` to extract a large portion of the tool's response body.
    ///
    /// 4.1. If you hit example.com and it returns `{"name": "John", "age": 30}`, then you can specify the schema as:
    ///
    /// ```json
    /// {
    ///   "schema": {
    ///     "type": "object",
    ///     "properties": {
    ///       "name": {
    ///         "type": "string"
    ///       },
    ///       "age": {
    ///         "type": "number"
    ///       }
    ///     }
    ///   }
    /// }
    /// ```
    ///
    /// 4.2. If you hit example.com and it returns `{"name": {"first": "John", "last": "Doe"}}`, then you can specify the schema as:
    ///
    /// ```json
    /// {
    ///   "schema": {
    ///     "type": "object",
    ///     "properties": {
    ///       "name": {
    ///         "type": "object",
    ///         "properties": {
    ///           "first": {
    ///             "type": "string"
    ///           },
    ///           "last": {
    ///             "type": "string"
    ///           }
    ///         }
    ///       }
    ///     }
    ///   }
    /// }
    /// ```
    ///
    /// These will be extracted as `{{ name }}` and `{{ age }}` respectively. To emphasize, object properties are extracted as direct global variables.
    ///
    /// 4.3. If you hit example.com and it returns `{"name": {"first": "John", "last": "Doe"}}`, then you can specify the schema as:
    ///
    /// ```json
    /// {
    ///   "schema": {
    ///     "type": "object",
    ///     "properties": {
    ///       "name": {
    ///         "type": "object",
    ///         "properties": {
    ///           "first": {
    ///             "type": "string"
    ///           },
    ///           "last": {
    ///             "type": "string"
    ///           }
    ///         }
    ///       }
    ///     }
    ///   }
    /// }
    /// ```
    ///
    /// These will be extracted as `{{ name }}`. And, `{{ name.first }}` and `{{ name.last }}` will be accessible.
    ///
    /// 4.4. If you hit example.com and it returns `["94123", "94124"]`, then you can specify the schema as:
    ///
    /// ```json
    /// {
    ///   "schema": {
    ///     "type": "array",
    ///     "title": "zipCodes",
    ///     "items": {
    ///       "type": "string"
    ///     }
    ///   }
    /// }
    /// ```
    ///
    /// This will be extracted as `{{ zipCodes }}`. To access the array items, you can use `{{ zipCodes[0] }}` and `{{ zipCodes[1] }}`.
    ///
    /// 4.5. If you hit example.com and it returns `[{"name": "John", "age": 30, "zipCodes": ["94123", "94124"]}, {"name": "Jane", "age": 25, "zipCodes": ["94125", "94126"]}]`, then you can specify the schema as:
    ///
    /// ```json
    /// {
    ///   "schema": {
    ///     "type": "array",
    ///     "title": "people",
    ///     "items": {
    ///       "type": "object",
    ///       "properties": {
    ///         "name": {
    ///           "type": "string"
    ///         },
    ///         "age": {
    ///           "type": "number"
    ///         },
    ///         "zipCodes": {
    ///           "type": "array",
    ///           "items": {
    ///             "type": "string"
    ///           }
    ///         }
    ///       }
    ///     }
    ///   }
    /// }
    /// ```
    ///
    /// This will be extracted as `{{ people }}`. To access the array items, you can use `{{ people[n].name }}`, `{{ people[n].age }}`, `{{ people[n].zipCodes }}`, `{{ people[n].zipCodes[0] }}` and `{{ people[n].zipCodes[1] }}`.
    ///
    /// Note: Both `aliases` and `schema` can be used together.
    /// </summary>
    [JsonPropertyName("variableExtractionPlan")]
    public VariableExtractionPlan? VariableExtractionPlan { get; set; }

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
