using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record LogicEdgeCondition
{
    [JsonPropertyName("liquid")]
    public required string Liquid { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
