using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TransferArtifactModeSerializer))]
public enum TransferArtifactMode
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

internal class TransferArtifactModeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TransferArtifactMode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TransferArtifactMode
    > _stringToEnum = new()
    {
        { "blind-transfer", TransferArtifactMode.BlindTransfer },
        {
            "blind-transfer-add-summary-to-sip-header",
            TransferArtifactMode.BlindTransferAddSummaryToSipHeader
        },
        { "warm-transfer-say-message", TransferArtifactMode.WarmTransferSayMessage },
        { "warm-transfer-say-summary", TransferArtifactMode.WarmTransferSaySummary },
        { "warm-transfer-twiml", TransferArtifactMode.WarmTransferTwiml },
        {
            "warm-transfer-wait-for-operator-to-speak-first-and-then-say-message",
            TransferArtifactMode.WarmTransferWaitForOperatorToSpeakFirstAndThenSayMessage
        },
        {
            "warm-transfer-wait-for-operator-to-speak-first-and-then-say-summary",
            TransferArtifactMode.WarmTransferWaitForOperatorToSpeakFirstAndThenSaySummary
        },
        { "warm-transfer-experimental", TransferArtifactMode.WarmTransferExperimental },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TransferArtifactMode,
        string
    > _enumToString = new()
    {
        { TransferArtifactMode.BlindTransfer, "blind-transfer" },
        {
            TransferArtifactMode.BlindTransferAddSummaryToSipHeader,
            "blind-transfer-add-summary-to-sip-header"
        },
        { TransferArtifactMode.WarmTransferSayMessage, "warm-transfer-say-message" },
        { TransferArtifactMode.WarmTransferSaySummary, "warm-transfer-say-summary" },
        { TransferArtifactMode.WarmTransferTwiml, "warm-transfer-twiml" },
        {
            TransferArtifactMode.WarmTransferWaitForOperatorToSpeakFirstAndThenSayMessage,
            "warm-transfer-wait-for-operator-to-speak-first-and-then-say-message"
        },
        {
            TransferArtifactMode.WarmTransferWaitForOperatorToSpeakFirstAndThenSaySummary,
            "warm-transfer-wait-for-operator-to-speak-first-and-then-say-summary"
        },
        { TransferArtifactMode.WarmTransferExperimental, "warm-transfer-experimental" },
    };

    public override TransferArtifactMode Read(
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
        TransferArtifactMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TransferArtifactMode ReadAsPropertyName(
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
        TransferArtifactMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
