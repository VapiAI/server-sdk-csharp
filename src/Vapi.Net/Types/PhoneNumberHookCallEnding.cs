using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record PhoneNumberHookCallEnding
{
    /// <summary>
    /// Optional filters to decide when to trigger - restricted to assistant-request related ended reasons
    /// </summary>
    [JsonPropertyName("filters")]
    public IEnumerable<PhoneNumberCallEndingHookFilter>? Filters { get; set; }

    /// <summary>
    /// This is the action to perform when the hook triggers
    /// </summary>
    [JsonPropertyName("do")]
    public object? Do { get; set; }

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
