using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageSpeechUpdateRoleSerializer))]
public enum ServerMessageSpeechUpdateRole
{
    [EnumMember(Value = "assistant")]
    Assistant,

    [EnumMember(Value = "user")]
    User,
}

internal class ServerMessageSpeechUpdateRoleSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageSpeechUpdateRole>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageSpeechUpdateRole
    > _stringToEnum = new()
    {
        { "assistant", ServerMessageSpeechUpdateRole.Assistant },
        { "user", ServerMessageSpeechUpdateRole.User },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageSpeechUpdateRole,
        string
    > _enumToString = new()
    {
        { ServerMessageSpeechUpdateRole.Assistant, "assistant" },
        { ServerMessageSpeechUpdateRole.User, "user" },
    };

    public override ServerMessageSpeechUpdateRole Read(
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
        ServerMessageSpeechUpdateRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageSpeechUpdateRole ReadAsPropertyName(
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
        ServerMessageSpeechUpdateRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
