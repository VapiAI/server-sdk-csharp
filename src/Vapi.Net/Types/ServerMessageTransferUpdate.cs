using System.Text.Json;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

public record ServerMessageTransferUpdate
{
    /// <summary>
    /// This is the phone number that the message is associated with.
    /// </summary>
    [JsonPropertyName("phoneNumber")]
    public object? PhoneNumber { get; set; }

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
    /// This is the timestamp of the message.
    /// </summary>
    [JsonPropertyName("timestamp")]
    public double? Timestamp { get; set; }

    /// <summary>
    /// This is a live version of the `call.artifact`.
    ///
    /// This matches what is stored on `call.artifact` after the call.
    /// </summary>
    [JsonPropertyName("artifact")]
    public Artifact? Artifact { get; set; }

    /// <summary>
    /// This is the assistant that the message is associated with.
    /// </summary>
    [JsonPropertyName("assistant")]
    public CreateAssistantDto? Assistant { get; set; }

    /// <summary>
    /// This is the customer that the message is associated with.
    /// </summary>
    [JsonPropertyName("customer")]
    public CreateCustomerDto? Customer { get; set; }

    /// <summary>
    /// This is the call that the message is associated with.
    /// </summary>
    [JsonPropertyName("call")]
    public Call? Call { get; set; }

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

    /// <summary>
    /// Additional properties received from the response, if any.
    /// </summary>
    /// <remarks>
    /// [EXPERIMENTAL] This API is experimental and may change in future releases.
    /// </remarks>
    [JsonExtensionData]
    public IDictionary<string, JsonElement> AdditionalProperties { get; internal set; } =
        new Dictionary<string, JsonElement>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
