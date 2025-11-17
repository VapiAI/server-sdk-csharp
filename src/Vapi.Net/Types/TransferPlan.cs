using System.Text.Json;
using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

[Serializable]
public record TransferPlan
{
    /// <summary>
    /// This configures how transfer is executed and the experience of the destination party receiving the call.
    ///
    /// Usage:
    /// - `blind-transfer`: The assistant forwards the call to the destination without any message or summary.
    /// - `blind-transfer-add-summary-to-sip-header`: The assistant forwards the call to the destination and adds a SIP header X-Transfer-Summary to the call to include the summary.
    /// - `warm-transfer-say-message`: The assistant dials the destination, delivers the `message` to the destination party, connects the customer, and leaves the call.
    /// - `warm-transfer-say-summary`: The assistant dials the destination, provides a summary of the call to the destination party, connects the customer, and leaves the call.
    /// - `warm-transfer-wait-for-operator-to-speak-first-and-then-say-message`: The assistant dials the destination, waits for the operator to speak, delivers the `message` to the destination party, and then connects the customer.
    /// - `warm-transfer-wait-for-operator-to-speak-first-and-then-say-summary`: The assistant dials the destination, waits for the operator to speak, provides a summary of the call to the destination party, and then connects the customer.
    /// - `warm-transfer-twiml`: The assistant dials the destination, executes the twiml instructions on the destination call leg, connects the customer, and leaves the call.
    /// - `warm-transfer-experimental`: The assistant puts the customer on hold, dials the destination, and if the destination answers (and is human), delivers a message or summary before connecting the customer. If the destination is unreachable or not human (e.g., with voicemail detection), the assistant delivers the `fallbackMessage` to the customer and optionally ends the call.
    ///
    /// @default 'blind-transfer'
    /// </summary>
    [JsonPropertyName("mode")]
    public required TransferPlanMode Mode { get; set; }

    /// <summary>
    /// This is the message the assistant will deliver to the destination party before connecting the customer.
    ///
    /// Usage:
    /// - Used only when `mode` is `blind-transfer-add-summary-to-sip-header`, `warm-transfer-say-message`, `warm-transfer-wait-for-operator-to-speak-first-and-then-say-message`, or `warm-transfer-experimental`.
    /// </summary>
    [JsonPropertyName("message")]
    public OneOf<string, CustomMessage>? Message { get; set; }

    /// <summary>
    /// This is the timeout in seconds for the warm-transfer-wait-for-operator-to-speak-first-and-then-say-message/summary
    ///
    /// @default 60
    /// </summary>
    [JsonPropertyName("timeout")]
    public double? Timeout { get; set; }

    /// <summary>
    /// This specifies the SIP verb to use while transferring the call.
    /// - 'refer': Uses SIP REFER to transfer the call (default)
    /// - 'bye': Ends current call with SIP BYE
    /// - 'dial': Uses SIP DIAL to transfer the call
    /// </summary>
    [JsonPropertyName("sipVerb")]
    public object? SipVerb { get; set; }

    /// <summary>
    /// This is the URL to an audio file played while the customer is on hold during transfer.
    ///
    /// Usage:
    /// - Used only when `mode` is `warm-transfer-experimental`.
    /// - Used when transferring calls to play hold audio for the customer.
    /// - Must be a publicly accessible URL to an audio file.
    /// - Supported formats: MP3 and WAV.
    /// - If not provided, the default hold audio will be used.
    /// </summary>
    [JsonPropertyName("holdAudioUrl")]
    public string? HoldAudioUrl { get; set; }

    /// <summary>
    /// This is the URL to an audio file played after the warm transfer message or summary is delivered to the destination party.
    /// It can be used to play a custom sound like 'beep' to notify that the transfer is complete.
    ///
    /// Usage:
    /// - Used only when `mode` is `warm-transfer-experimental`.
    /// - Used when transferring calls to play hold audio for the destination party.
    /// - Must be a publicly accessible URL to an audio file.
    /// - Supported formats: MP3 and WAV.
    /// </summary>
    [JsonPropertyName("transferCompleteAudioUrl")]
    public string? TransferCompleteAudioUrl { get; set; }

    /// <summary>
    /// This is the plan for manipulating the message context before initiating the warm transfer.
    /// Usage:
    /// - Used only when `mode` is `warm-transfer-experimental`.
    /// - These messages will automatically be added to the transferAssistant's system message.
    /// - If 'none', we will not add any transcript to the transferAssistant's system message.
    /// - If you want to provide your own messages, use transferAssistant.model.messages instead.
    ///
    /// @default { type: 'all' }
    /// </summary>
    [JsonPropertyName("contextEngineeringPlan")]
    public object? ContextEngineeringPlan { get; set; }

    /// <summary>
    /// This is the TwiML instructions to execute on the destination call leg before connecting the customer.
    ///
    /// Usage:
    /// - Used only when `mode` is `warm-transfer-twiml`.
    /// - Supports only `Play`, `Say`, `Gather`, `Hangup` and `Pause` verbs.
    /// - Maximum length is 4096 characters.
    ///
    /// Example:
    /// ```
    /// &lt;Say voice="alice" language="en-US"&gt;Hello, transferring a customer to you.&lt;/Say&gt;
    /// &lt;Pause length="2"/&gt;
    /// &lt;Say&gt;They called about billing questions.&lt;/Say&gt;
    /// ```
    /// </summary>
    [JsonPropertyName("twiml")]
    public string? Twiml { get; set; }

    /// <summary>
    /// This is the plan for generating a summary of the call to present to the destination party.
    ///
    /// Usage:
    /// - Used only when `mode` is `blind-transfer-add-summary-to-sip-header` or `warm-transfer-say-summary` or `warm-transfer-wait-for-operator-to-speak-first-and-then-say-summary` or `warm-transfer-experimental`.
    /// </summary>
    [JsonPropertyName("summaryPlan")]
    public SummaryPlan? SummaryPlan { get; set; }

    /// <summary>
    /// This flag includes the sipHeaders from above in the refer to sip uri as url encoded query params.
    ///
    /// @default false
    /// </summary>
    [JsonPropertyName("sipHeadersInReferToEnabled")]
    public bool? SipHeadersInReferToEnabled { get; set; }

    /// <summary>
    /// This configures the fallback plan when the transfer fails (destination unreachable, busy, or not human).
    ///
    /// Usage:
    /// - Used only when `mode` is `warm-transfer-experimental`.
    /// - If not provided when using `warm-transfer-experimental`, a default message will be used.
    /// </summary>
    [JsonPropertyName("fallbackPlan")]
    public TransferFallbackPlan? FallbackPlan { get; set; }

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
