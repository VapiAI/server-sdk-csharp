using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record Error
{
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
