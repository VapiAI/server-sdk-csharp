using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record AssistantHooks
{
    /// <summary>
    /// This is the event that triggers this hook
    /// </summary>
    [JsonPropertyName("on")]
    public string On { get; set; } = "call.ending";

    /// <summary>
    /// This is the set of filters that must match for the hook to trigger
    /// </summary>
    [JsonPropertyName("filters")]
    public IEnumerable<AssistantHookFilter>? Filters { get; set; }

    /// <summary>
    /// This is the set of actions to perform when the hook triggers
    /// </summary>
    [JsonPropertyName("do")]
    public IEnumerable<AssistantHookActionBase> Do { get; set; } =
        new List<AssistantHookActionBase>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
