using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TransferArtifactStatusSerializer))]
public enum TransferArtifactStatus
{
    [EnumMember(Value = "connected")]
    Connected,

    [EnumMember(Value = "no-answer")]
    NoAnswer,

    [EnumMember(Value = "busy")]
    Busy,

    [EnumMember(Value = "voicemail")]
    Voicemail,

    [EnumMember(Value = "failed")]
    Failed,

    [EnumMember(Value = "completed")]
    Completed,

    [EnumMember(Value = "cancelled")]
    Cancelled,
}

internal class TransferArtifactStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TransferArtifactStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TransferArtifactStatus
    > _stringToEnum = new()
    {
        { "connected", TransferArtifactStatus.Connected },
        { "no-answer", TransferArtifactStatus.NoAnswer },
        { "busy", TransferArtifactStatus.Busy },
        { "voicemail", TransferArtifactStatus.Voicemail },
        { "failed", TransferArtifactStatus.Failed },
        { "completed", TransferArtifactStatus.Completed },
        { "cancelled", TransferArtifactStatus.Cancelled },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TransferArtifactStatus,
        string
    > _enumToString = new()
    {
        { TransferArtifactStatus.Connected, "connected" },
        { TransferArtifactStatus.NoAnswer, "no-answer" },
        { TransferArtifactStatus.Busy, "busy" },
        { TransferArtifactStatus.Voicemail, "voicemail" },
        { TransferArtifactStatus.Failed, "failed" },
        { TransferArtifactStatus.Completed, "completed" },
        { TransferArtifactStatus.Cancelled, "cancelled" },
    };

    public override TransferArtifactStatus Read(
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
        TransferArtifactStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TransferArtifactStatus ReadAsPropertyName(
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
        TransferArtifactStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
