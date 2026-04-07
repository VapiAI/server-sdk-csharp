using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record WorkflowOverrides : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

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
