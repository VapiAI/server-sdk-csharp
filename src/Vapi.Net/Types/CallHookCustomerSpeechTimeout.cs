using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallHookCustomerSpeechTimeout
{
    /// <summary>
    /// Must be either "customer.speech.timeout" or match the pattern "customer.speech.timeout[property=value]"
    /// </summary>
    [JsonPropertyName("on")]
    public required string On { get; set; }

    /// <summary>
    /// This is the set of actions to perform when the hook triggers
    /// </summary>
    [JsonPropertyName("do")]
    public IEnumerable<object> Do { get; set; } = new List<object>();

    /// <summary>
    /// This is the set of filters that must match for the hook to trigger
    /// </summary>
    [JsonPropertyName("options")]
    public CustomerSpeechTimeoutOptions? Options { get; set; }

    /// <summary>
    /// This is the name of the hook, it can be set by the user to identify the hook.
    /// If no name is provided, the hook will be auto generated as UUID.
    ///
    /// @default UUID
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

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
