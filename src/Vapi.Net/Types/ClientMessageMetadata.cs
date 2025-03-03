using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ClientMessageMetadata
{
    /// <summary>
    /// This is the type of the message. "metadata" is sent to forward metadata to the client.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "metadata";

    /// <summary>
    /// This is the metadata content
    /// </summary>
    [JsonPropertyName("metadata")]
    public required string Metadata { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
