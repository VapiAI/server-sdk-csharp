using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record CallHookCustomerSpeechInterrupted
{
    /// <summary>
    /// This is the event that triggers this hook
    /// </summary>
    [JsonPropertyName("on")]
    public string On { get; set; } = "customer.speech.interrupted";

    /// <summary>
    /// This is the set of actions to perform when the hook triggers
    /// </summary>
    [JsonPropertyName("do")]
    public IEnumerable<object> Do { get; set; } = new List<object>();

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
