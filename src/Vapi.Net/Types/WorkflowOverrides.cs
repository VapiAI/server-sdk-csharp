using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record WorkflowOverrides
{
    /// <summary>
    /// These are values that will be used to replace the template variables in the workflow messages and other text-based fields.
    /// This uses LiquidJS syntax. https://liquidjs.com/tutorials/intro-to-liquid.html
    ///
    /// So for example, `{{ name }}` will be replaced with the value of `name` in `variableValues`.
    /// `{{"now" | date: "%b %d, %Y, %I:%M %p", "America/New_York"}}` will be replaced with the current date and time in New York.
    ///  Some VAPI reserved defaults:
    ///  - *customer* - the customer object
    /// </summary>
    [JsonPropertyName("variableValues")]
    public object? VariableValues { get; set; }

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
