using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ServerMessageResponseTransferDestinationRequest
{
    /// <summary>
    /// This is the destination you'd like the call to be transferred to.
    /// </summary>
    [JsonPropertyName("destination")]
    public object? Destination { get; set; }

    /// <summary>
    /// This is the error message if the transfer should not be made.
    /// </summary>
    [JsonPropertyName("error")]
    public string? Error { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
