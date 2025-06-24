using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record AssistantHookFilter
{
    /// <summary>
    /// This is the type of filter - currently only "oneOf" is supported
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "oneOf";

    /// <summary>
    /// This is the key to filter on (e.g. "call.endedReason")
    /// </summary>
    [JsonPropertyName("key")]
    public required string Key { get; set; }

    /// <summary>
    /// This is the array of possible values to match against
    /// </summary>
    [JsonPropertyName("oneOf")]
    public IEnumerable<string> OneOf { get; set; } = new List<string>();

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
