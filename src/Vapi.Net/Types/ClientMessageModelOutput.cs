using System.Text.Json.Serialization;
using Vapi.Net.Core;

#nullable enable

namespace Vapi.Net;

public record ClientMessageModelOutput
{
    /// <summary>
    /// This is the output of the model. It can be a token or tool call.
    /// </summary>
    [JsonPropertyName("output")]
    public object Output { get; set; } = new Dictionary<string, object?>();

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
