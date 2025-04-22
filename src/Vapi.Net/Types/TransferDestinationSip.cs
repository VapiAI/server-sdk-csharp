using System.Text.Json;
using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

public record TransferDestinationSip
{
    /// <summary>
    /// This is spoken to the customer before connecting them to the destination.
    ///
    /// Usage:
    /// - If this is not provided and transfer tool messages is not provided, default is "Transferring the call now".
    /// - If set to "", nothing is spoken. This is useful when you want to silently transfer. This is especially useful when transferring between assistants in a squad. In this scenario, you likely also want to set `assistant.firstMessageMode=assistant-speaks-first-with-model-generated-message` for the destination assistant.
    ///
    /// This accepts a string or a ToolMessageStart class. Latter is useful if you want to specify multiple messages for different languages through the `contents` field.
    /// </summary>
    [JsonPropertyName("message")]
    public OneOf<string, CustomMessage>? Message { get; set; }

    /// <summary>
    /// This is the SIP URI to transfer the call to.
    /// </summary>
    [JsonPropertyName("sipUri")]
    public required string SipUri { get; set; }

    /// <summary>
    /// This configures how transfer is executed and the experience of the destination party receiving the call. Defaults to `blind-transfer`.
    ///
    /// @default `transferPlan.mode='blind-transfer'`
    /// </summary>
    [JsonPropertyName("transferPlan")]
    public TransferPlan? TransferPlan { get; set; }

    /// <summary>
    /// These are custom headers to be added to SIP refer during transfer call.
    /// </summary>
    [JsonPropertyName("sipHeaders")]
    public object? SipHeaders { get; set; }

    /// <summary>
    /// This is the description of the destination, used by the AI to choose when and how to transfer the call.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

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
