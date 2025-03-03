using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

public record TransferDestinationNumber
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
    /// This is the flag to toggle the E164 check for the `number` field. This is an advanced property which should be used if you know your use case requires it.
    ///
    /// Use cases:
    /// - `false`: To allow non-E164 numbers like `+001234567890`, `1234`, or `abc`. This is useful for dialing out to non-E164 numbers on your SIP trunks.
    /// - `true` (default): To allow only E164 numbers like `+14155551234`. This is standard for PSTN calls.
    ///
    /// If `false`, the `number` is still required to only contain alphanumeric characters (regex: `/^\+?[a-zA-Z0-9]+$/`).
    ///
    /// @default true (E164 check is enabled)
    /// </summary>
    [JsonPropertyName("numberE164CheckEnabled")]
    public bool? NumberE164CheckEnabled { get; set; }

    /// <summary>
    /// This is the phone number to transfer the call to.
    /// </summary>
    [JsonPropertyName("number")]
    public required string Number { get; set; }

    /// <summary>
    /// This is the extension to dial after transferring the call to the `number`.
    /// </summary>
    [JsonPropertyName("extension")]
    public string? Extension { get; set; }

    /// <summary>
    /// This is the caller ID to use when transferring the call to the `number`.
    ///
    /// Usage:
    /// - If not provided, the caller ID will be the number the call is coming from. Example, +14151111111 calls in to and the assistant transfers out to +16470000000. +16470000000 will see +14151111111 as the caller.
    /// - To change this behavior, provide a `callerId`.
    /// - Set to '{{customer.number}}' to always use the customer's number as the caller ID.
    /// - Set to '{{phoneNumber.number}}' to always use the phone number of the assistant as the caller ID.
    /// - Set to any E164 number to always use that number as the caller ID. This needs to be a number that is owned or verified by your Transport provider like Twilio.
    ///
    /// For Twilio, you can read up more here: https://www.twilio.com/docs/voice/twiml/dial#callerid
    /// </summary>
    [JsonPropertyName("callerId")]
    public string? CallerId { get; set; }

    /// <summary>
    /// This configures how transfer is executed and the experience of the destination party receiving the call. Defaults to `blind-transfer`.
    ///
    /// @default `transferPlan.mode='blind-transfer'`
    /// </summary>
    [JsonPropertyName("transferPlan")]
    public TransferPlan? TransferPlan { get; set; }

    /// <summary>
    /// This is the description of the destination, used by the AI to choose when and how to transfer the call.
    /// </summary>
    [JsonPropertyName("description")]
    public string? Description { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
