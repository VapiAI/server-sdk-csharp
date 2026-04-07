using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CallStatusSerializer))]
public enum CallStatus
{
    [EnumMember(Value = "scheduled")]
    Scheduled,

    [EnumMember(Value = "queued")]
    Queued,

    [EnumMember(Value = "ringing")]
    Ringing,

    [EnumMember(Value = "in-progress")]
    InProgress,

    [EnumMember(Value = "forwarding")]
    Forwarding,

    [EnumMember(Value = "ended")]
    Ended,

    [EnumMember(Value = "not-found")]
    NotFound,

    [EnumMember(Value = "deletion-failed")]
    DeletionFailed,
}

internal class CallStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CallStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CallStatus
    > _stringToEnum = new()
    {
        { "scheduled", CallStatus.Scheduled },
        { "queued", CallStatus.Queued },
        { "ringing", CallStatus.Ringing },
        { "in-progress", CallStatus.InProgress },
        { "forwarding", CallStatus.Forwarding },
        { "ended", CallStatus.Ended },
        { "not-found", CallStatus.NotFound },
        { "deletion-failed", CallStatus.DeletionFailed },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CallStatus,
        string
    > _enumToString = new()
    {
        { CallStatus.Scheduled, "scheduled" },
        { CallStatus.Queued, "queued" },
        { CallStatus.Ringing, "ringing" },
        { CallStatus.InProgress, "in-progress" },
        { CallStatus.Forwarding, "forwarding" },
        { CallStatus.Ended, "ended" },
        { CallStatus.NotFound, "not-found" },
        { CallStatus.DeletionFailed, "deletion-failed" },
    };

    public override CallStatus Read(
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
        CallStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CallStatus ReadAsPropertyName(
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
        CallStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
