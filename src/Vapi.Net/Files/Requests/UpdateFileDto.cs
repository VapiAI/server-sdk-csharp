using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record UpdateFileDto
{
    /// <summary>
    /// This is the name of the file. This is just for your own reference.
    /// </summary>
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
