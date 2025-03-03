using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record AiEdgeCondition
{
    [JsonPropertyName("matches")]
    public IEnumerable<string> Matches { get; set; } = new List<string>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
