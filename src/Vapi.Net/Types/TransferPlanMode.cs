using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TransferPlanMode>))]
public enum TransferPlanMode
{
    [EnumMember(Value = "blind-transfer")]
    BlindTransfer,

    [EnumMember(Value = "blind-transfer-add-summary-to-sip-header")]
    BlindTransferAddSummaryToSipHeader,

    [EnumMember(Value = "warm-transfer-say-message")]
    WarmTransferSayMessage,

    [EnumMember(Value = "warm-transfer-say-summary")]
    WarmTransferSaySummary,

    [EnumMember(Value = "warm-transfer-twiml")]
    WarmTransferTwiml,

    [EnumMember(Value = "warm-transfer-wait-for-operator-to-speak-first-and-then-say-message")]
    WarmTransferWaitForOperatorToSpeakFirstAndThenSayMessage,

    [EnumMember(Value = "warm-transfer-wait-for-operator-to-speak-first-and-then-say-summary")]
    WarmTransferWaitForOperatorToSpeakFirstAndThenSaySummary,

    [EnumMember(Value = "warm-transfer-experimental")]
    WarmTransferExperimental,
}
