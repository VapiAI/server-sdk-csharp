using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TransferPlanModeSerializer))]
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

internal class TransferPlanModeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TransferPlanMode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TransferPlanMode
    > _stringToEnum = new()
    {
        { "blind-transfer", TransferPlanMode.BlindTransfer },
        {
            "blind-transfer-add-summary-to-sip-header",
            TransferPlanMode.BlindTransferAddSummaryToSipHeader
        },
        { "warm-transfer-say-message", TransferPlanMode.WarmTransferSayMessage },
        { "warm-transfer-say-summary", TransferPlanMode.WarmTransferSaySummary },
        { "warm-transfer-twiml", TransferPlanMode.WarmTransferTwiml },
        {
            "warm-transfer-wait-for-operator-to-speak-first-and-then-say-message",
            TransferPlanMode.WarmTransferWaitForOperatorToSpeakFirstAndThenSayMessage
        },
        {
            "warm-transfer-wait-for-operator-to-speak-first-and-then-say-summary",
            TransferPlanMode.WarmTransferWaitForOperatorToSpeakFirstAndThenSaySummary
        },
        { "warm-transfer-experimental", TransferPlanMode.WarmTransferExperimental },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TransferPlanMode,
        string
    > _enumToString = new()
    {
        { TransferPlanMode.BlindTransfer, "blind-transfer" },
        {
            TransferPlanMode.BlindTransferAddSummaryToSipHeader,
            "blind-transfer-add-summary-to-sip-header"
        },
        { TransferPlanMode.WarmTransferSayMessage, "warm-transfer-say-message" },
        { TransferPlanMode.WarmTransferSaySummary, "warm-transfer-say-summary" },
        { TransferPlanMode.WarmTransferTwiml, "warm-transfer-twiml" },
        {
            TransferPlanMode.WarmTransferWaitForOperatorToSpeakFirstAndThenSayMessage,
            "warm-transfer-wait-for-operator-to-speak-first-and-then-say-message"
        },
        {
            TransferPlanMode.WarmTransferWaitForOperatorToSpeakFirstAndThenSaySummary,
            "warm-transfer-wait-for-operator-to-speak-first-and-then-say-summary"
        },
        { TransferPlanMode.WarmTransferExperimental, "warm-transfer-experimental" },
    };

    public override TransferPlanMode Read(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        var stringValue =
            reader.GetString()
            ?? throw new global::System.Exception("The JSON value could not be read as a string.");
        return _stringToEnum.TryGetValue(stringValue, out var enumValue) ? enumValue : default;
    }

    public override void Write(
        global::System.Text.Json.Utf8JsonWriter writer,
        TransferPlanMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TransferPlanMode ReadAsPropertyName(
        ref global::System.Text.Json.Utf8JsonReader reader,
        global::System.Type typeToConvert,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        var stringValue =
            reader.GetString()
            ?? throw new global::System.Exception(
                "The JSON property name could not be read as a string."
            );
        return _stringToEnum.TryGetValue(stringValue, out var enumValue) ? enumValue : default;
    }

    public override void WriteAsPropertyName(
        global::System.Text.Json.Utf8JsonWriter writer,
        TransferPlanMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
