using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageTranscriptRoleSerializer))]
public enum ServerMessageTranscriptRole
{
    [EnumMember(Value = "assistant")]
    Assistant,

    [EnumMember(Value = "user")]
    User,
}

internal class ServerMessageTranscriptRoleSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageTranscriptRole>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageTranscriptRole
    > _stringToEnum = new()
    {
        { "assistant", ServerMessageTranscriptRole.Assistant },
        { "user", ServerMessageTranscriptRole.User },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageTranscriptRole,
        string
    > _enumToString = new()
    {
        { ServerMessageTranscriptRole.Assistant, "assistant" },
        { ServerMessageTranscriptRole.User, "user" },
    };

    public override ServerMessageTranscriptRole Read(
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
        ServerMessageTranscriptRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageTranscriptRole ReadAsPropertyName(
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
        ServerMessageTranscriptRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
