using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageStatusUpdateStatusSerializer))]
public enum ServerMessageStatusUpdateStatus
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

internal class ServerMessageStatusUpdateStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageStatusUpdateStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageStatusUpdateStatus
    > _stringToEnum = new()
    {
        { "scheduled", ServerMessageStatusUpdateStatus.Scheduled },
        { "queued", ServerMessageStatusUpdateStatus.Queued },
        { "ringing", ServerMessageStatusUpdateStatus.Ringing },
        { "in-progress", ServerMessageStatusUpdateStatus.InProgress },
        { "forwarding", ServerMessageStatusUpdateStatus.Forwarding },
        { "ended", ServerMessageStatusUpdateStatus.Ended },
        { "not-found", ServerMessageStatusUpdateStatus.NotFound },
        { "deletion-failed", ServerMessageStatusUpdateStatus.DeletionFailed },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageStatusUpdateStatus,
        string
    > _enumToString = new()
    {
        { ServerMessageStatusUpdateStatus.Scheduled, "scheduled" },
        { ServerMessageStatusUpdateStatus.Queued, "queued" },
        { ServerMessageStatusUpdateStatus.Ringing, "ringing" },
        { ServerMessageStatusUpdateStatus.InProgress, "in-progress" },
        { ServerMessageStatusUpdateStatus.Forwarding, "forwarding" },
        { ServerMessageStatusUpdateStatus.Ended, "ended" },
        { ServerMessageStatusUpdateStatus.NotFound, "not-found" },
        { ServerMessageStatusUpdateStatus.DeletionFailed, "deletion-failed" },
    };

    public override ServerMessageStatusUpdateStatus Read(
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
        ServerMessageStatusUpdateStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageStatusUpdateStatus ReadAsPropertyName(
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
        ServerMessageStatusUpdateStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
