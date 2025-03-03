using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ClientMessageTransferUpdate
{
    /// <summary>
    /// This is the type of the message. "transfer-update" is sent whenever a transfer happens.
    /// </summary>
    [JsonPropertyName("type")]
    public string Type { get; set; } = "transfer-update";

    /// <summary>
    /// This is the destination of the transfer.
    /// </summary>
    [JsonPropertyName("destination")]
    public object? Destination { get; set; }

    /// <summary>
    /// This is the assistant that the call is being transferred to. This is only sent if `destination.type` is "assistant".
    /// </summary>
    [JsonPropertyName("toAssistant")]
    public CreateAssistantDto? ToAssistant { get; set; }

    /// <summary>
    /// This is the assistant that the call is being transferred from. This is only sent if `destination.type` is "assistant".
    /// </summary>
    [JsonPropertyName("fromAssistant")]
    public CreateAssistantDto? FromAssistant { get; set; }

    /// <summary>
    /// This is the step that the conversation moved to.
    /// </summary>
    [JsonPropertyName("toStepRecord")]
    public object? ToStepRecord { get; set; }

    /// <summary>
    /// This is the step that the conversation moved from. =
    /// </summary>
    [JsonPropertyName("fromStepRecord")]
    public object? FromStepRecord { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
