using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record Hook
{
    [JsonPropertyName("on")]
    public required HookOn On { get; set; }

    [JsonPropertyName("do")]
    public IEnumerable<SayHook> Do { get; set; } = new List<SayHook>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
