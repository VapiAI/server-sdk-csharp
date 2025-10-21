using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record ApiRequestTool
{
    /// <summary>
    /// These are the messages that will be spoken to the user as the tool is running.
    ///
    /// For some tools, this is auto-filled based on special fields like `tool.destinations`. For others like the function tool, these can be custom configured.
    /// </summary>
    [JsonPropertyName("messages")]
    public IEnumerable<object>? Messages { get; set; }

    [JsonPropertyName("method")]
    public required ApiRequestToolMethod Method { get; set; }

    /// <summary>
    /// This is the timeout in seconds for the request. Defaults to 20 seconds.
    ///
    /// @default 20
    /// </summary>
    [JsonPropertyName("timeoutSeconds")]
    public double? TimeoutSeconds { get; set; }

    /// <summary>
    /// The credential ID for API request authentication
    /// </summary>
    [JsonPropertyName("credentialId")]
    public string? CredentialId { get; set; }

    /// <summary>
    /// This is the unique identifier for the tool.
    /// </summary>
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    /// <summary>
    /// This is the unique identifier for the organization that this tool belongs to.
    /// </summary>
    [JsonPropertyName("orgId")]
    public required string OrgId { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the tool was created.
    /// </summary>
    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

    /// <summary>
    /// This is the ISO 8601 date-time string of when the tool was last updated.
    /// </summary>
    [JsonPropertyName("updatedAt")]
    public required DateTime UpdatedAt { get; set; }

    /// <summary>
    /// This is the plan to reject a tool call based on the conversation state.
    ///
    /// // Example 1: Reject endCall if user didn't say goodbye
    /// ```json
    /// {
    ///   conditions: [{
    ///     type: 'regex',
    ///     regex: '(?i)\\b(bye|goodbye|farewell|see you later|take care)\\b',
    ///     target: { position: -1, role: 'user' },
    ///     negate: true  // Reject if pattern does NOT match
    ///   }]
    /// }
    /// ```
    ///
    /// // Example 2: Reject transfer if user is actually asking a question
    /// ```json
    /// {
    ///   conditions: [{
    ///     type: 'regex',
    ///     regex: '\\?',
    ///     target: { position: -1, role: 'user' }
    ///   }]
    /// }
    /// ```
    ///
    /// // Example 3: Reject transfer if user didn't mention transfer recently
    /// ```json
    /// {
    ///   conditions: [{
    ///     type: 'liquid',
    ///     liquid: `{% assign recentMessages = messages | last: 5 %}
    /// {% assign userMessages = recentMessages | where: 'role', 'user' %}
    /// {% assign mentioned = false %}
    /// {% for msg in userMessages %}
    ///   {% if msg.content contains 'transfer' or msg.content contains 'connect' or msg.content contains 'speak to' %}
    ///     {% assign mentioned = true %}
    ///     {% break %}
    ///   {% endif %}
    /// {% endfor %}
    /// {% if mentioned %}
    ///   false
    /// {% else %}
    ///   true
    /// {% endif %}`
    ///   }]
    /// }
    /// ```
    ///
    /// // Example 4: Reject endCall if the bot is looping and trying to exit
    /// ```json
    /// {
    ///   conditions: [{
    ///     type: 'liquid',
    ///     liquid: `{% assign recentMessages = messages | last: 6 %}
    /// {% assign userMessages = recentMessages | where: 'role', 'user' | reverse %}
    /// {% if userMessages.size &lt; 3 %}
    ///   false
    /// {% else %}
    ///   {% assign msg1 = userMessages[0].content | downcase %}
    ///   {% assign msg2 = userMessages[1].content | downcase %}
    ///   {% assign msg3 = userMessages[2].content | downcase %}
    ///   {% comment %} Check for repetitive messages {% endcomment %}
    ///   {% if msg1 == msg2 or msg1 == msg3 or msg2 == msg3 %}
    ///     true
    ///   {% comment %} Check for common loop phrases {% endcomment %}
    ///   {% elsif msg1 contains 'cool thanks' or msg2 contains 'cool thanks' or msg3 contains 'cool thanks' %}
    ///     true
    ///   {% elsif msg1 contains 'okay thanks' or msg2 contains 'okay thanks' or msg3 contains 'okay thanks' %}
    ///     true
    ///   {% elsif msg1 contains 'got it' or msg2 contains 'got it' or msg3 contains 'got it' %}
    ///     true
    ///   {% else %}
    ///     false
    ///   {% endif %}
    /// {% endif %}`
    ///   }]
    /// }
    /// ```
    /// </summary>
    [JsonPropertyName("rejectionPlan")]
    public ToolRejectionPlan? RejectionPlan { get; set; }

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
    public required string Url { get; set; }

    /// <summary>
    /// This is the body of the request.
    /// </summary>
    [JsonPropertyName("body")]
    public JsonSchema? Body { get; set; }

    /// <summary>
    /// These are the headers to send with the request.
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
    /// These will be extracted as `{{ name }}` and `{{ age }}` respectively. To emphasize, object properties are extracted as direct global variables.
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
    /// These will be extracted as `{{ name }}`. And, `{{ name.first }}` and `{{ name.last }}` will be accessible.
    ///
    /// 4.3. If you hit example.com and it returns `["94123", "94124"]`, then you can specify the schema as:
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
    /// 4.4. If you hit example.com and it returns `[{"name": "John", "age": 30, "zipCodes": ["94123", "94124"]}, {"name": "Jane", "age": 25, "zipCodes": ["94125", "94126"]}]`, then you can specify the schema as:
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
