using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record LiquidCondition : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    /// <summary>
    /// This is the Liquid template that must return exactly "true" or "false" as a string.
    /// The template is evaluated and the entire output must be either "true" or "false" - nothing else.
    ///
    /// Available variables:
    /// - `messages`: Array of recent messages in OpenAI chat completions format (ChatCompletionMessageParam[])
    ///   Each message has properties like: role ('user', 'assistant', 'system'), content (string), etc.
    /// - `now`: Current timestamp in milliseconds (built-in Liquid variable)
    /// - Any assistant variable values (e.g., `userName`, `accountStatus`)
    ///
    /// Useful Liquid filters for messages:
    /// - `messages | last: 5` - Get the 5 most recent messages
    /// - `messages | where: 'role', 'user'` - Filter to only user messages
    /// - `messages | reverse` - Reverse the order of messages
    /// </summary>
    [JsonPropertyName("liquid")]
    public required string Liquid { get; set; }

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
