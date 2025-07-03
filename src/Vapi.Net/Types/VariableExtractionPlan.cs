using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record VariableExtractionPlan
{
    /// <summary>
    /// This is the schema to extract.
    ///
    /// Examples:
    /// 1. To extract object properties, you can use the following schema:
    /// ```json
    /// {
    ///   "type": "object",
    ///   "properties": {
    ///     "name": {
    ///       "type": "string"
    ///     },
    ///     "age": {
    ///       "type": "number"
    ///     }
    ///   }
    /// }
    /// ```
    ///
    /// These will be extracted as `{{ name }}` and `{{ age }}` respectively. To emphasize, object properties are extracted as direct global variables.
    ///
    /// 2. To extract nested properties, you can use the following schema:
    /// ```json
    /// {
    ///   "type": "object",
    ///   "properties": {
    ///     "name": {
    ///       "type": "object",
    ///       "properties": {
    ///         "first": {
    ///           "type": "string"
    ///         },
    ///         "last": {
    ///           "type": "string"
    ///         }
    ///       }
    ///     }
    ///   }
    /// }
    /// ```
    ///
    /// These will be extracted as `{{ name }}`. And, `{{ name.first }}` and `{{ name.last }}` will be accessible.
    ///
    /// 3. To extract array items, you can use the following schema:
    /// ```json
    /// {
    ///   "type": "array",
    ///   "title": "zipCodes",
    ///   "items": {
    ///     "type": "string"
    ///   }
    /// }
    /// ```
    ///
    /// This will be extracted as `{{ zipCodes }}`. To access the array items, you can use `{{ zipCodes[0] }}` and `{{ zipCodes[1] }}`.
    ///
    /// 4. To extract array of objects, you can use the following schema:
    ///
    /// ```json
    /// {
    ///   "type": "array",
    ///   "name": "people",
    ///   "items": {
    ///     "type": "object",
    ///     "properties": {
    ///       "name": {
    ///         "type": "string"
    ///       },
    ///       "age": {
    ///         "type": "number"
    ///       },
    ///       "zipCodes": {
    ///         "type": "array",
    ///         "items": {
    ///           "type": "string"
    ///         }
    ///       }
    ///     }
    ///   }
    /// }
    /// ```
    ///
    /// This will be extracted as `{{ people }}`. To access the array items, you can use `{{ people[n].name }}`, `{{ people[n].age }}`, `{{ people[n].zipCodes }}`, `{{ people[n].zipCodes[0] }}` and `{{ people[n].zipCodes[1] }}`.
    /// </summary>
    [JsonPropertyName("schema")]
    public JsonSchema? Schema { get; set; }

    /// <summary>
    /// These are additional variables to create.
    ///
    /// These will be accessible during the call as `{{key}}` and stored in `call.artifact.variableValues` after the call.
    ///
    /// Example:
    /// ```json
    /// {
    ///   "aliases": [
    ///     {
    ///       "key": "customerName",
    ///       "value": "{{name}}"
    ///     },
    ///     {
    ///       "key": "fullName",
    ///       "value": "{{firstName}} {{lastName}}"
    ///     },
    ///     {
    ///       "key": "greeting",
    ///       "value": "Hello {{name}}, welcome to {{company}}!"
    ///     },
    ///     {
    ///       "key": "customerEmail",
    ///       "value": "{{addresses[0].city}}"
    ///     },
    ///     {
    ///       "key": "something",
    ///       "value": "{{any liquid}}"
    ///     }
    ///   ]
    /// }
    /// ```
    ///
    /// This will create variables `customerName`, `fullName`, `customerEmail`, `greeting`, and `something`. To access these variables, you can reference them as `{{customerName}}`, `{{fullName}}`, `{{customerEmail}}`, `{{greeting}}`, and `{{something}}`.
    /// </summary>
    [JsonPropertyName("aliases")]
    public IEnumerable<VariableExtractionAlias>? Aliases { get; set; }

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
