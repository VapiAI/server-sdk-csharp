using System.Text.Json.Serialization;
using OneOf;
using Vapi.Net.Core;

namespace Vapi.Net;

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
    ///
    /// @default 'blind-transfer'
    /// </summary>
    [JsonPropertyName("mode")]
    public required TransferPlanMode Mode { get; set; }

    /// <summary>
    /// This is the message the assistant will deliver to the destination party before connecting the customer.
    ///
    /// Usage:
    /// - Used only when `mode` is `blind-transfer-add-summary-to-sip-header`, `warm-transfer-say-message` or `warm-transfer-wait-for-operator-to-speak-first-and-then-say-message`.
    /// </summary>
    [JsonPropertyName("message")]
    public OneOf<string, CustomMessage>? Message { get; set; }

    /// <summary>
    /// This specifies the SIP verb to use while transferring the call.
    /// - 'refer': Uses SIP REFER to transfer the call (default)
    /// - 'bye': Ends current call with SIP BYE
    /// </summary>
    [JsonPropertyName("sipVerb")]
    public object? SipVerb { get; set; }

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
    /// - Used only when `mode` is `blind-transfer-add-summary-to-sip-header` or `warm-transfer-say-summary` or `warm-transfer-wait-for-operator-to-speak-first-and-then-say-summary`.
    /// </summary>
    [JsonPropertyName("summaryPlan")]
    public SummaryPlan? SummaryPlan { get; set; }

    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
