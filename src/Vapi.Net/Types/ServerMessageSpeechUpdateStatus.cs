using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageSpeechUpdateStatusSerializer))]
public enum ServerMessageSpeechUpdateStatus
{
    [EnumMember(Value = "started")]
    Started,

    [EnumMember(Value = "stopped")]
    Stopped,
}

internal class ServerMessageSpeechUpdateStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageSpeechUpdateStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageSpeechUpdateStatus
    > _stringToEnum = new()
    {
        { "started", ServerMessageSpeechUpdateStatus.Started },
        { "stopped", ServerMessageSpeechUpdateStatus.Stopped },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageSpeechUpdateStatus,
        string
    > _enumToString = new()
    {
        { ServerMessageSpeechUpdateStatus.Started, "started" },
        { ServerMessageSpeechUpdateStatus.Stopped, "stopped" },
    };

    public override ServerMessageSpeechUpdateStatus Read(
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
        ServerMessageSpeechUpdateStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageSpeechUpdateStatus ReadAsPropertyName(
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
        ServerMessageSpeechUpdateStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
