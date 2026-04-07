using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageChatCreatedTypeSerializer))]
public enum ServerMessageChatCreatedType
{
    [EnumMember(Value = "chat.created")]
    ChatCreated,
}

internal class ServerMessageChatCreatedTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageChatCreatedType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageChatCreatedType
    > _stringToEnum = new() { { "chat.created", ServerMessageChatCreatedType.ChatCreated } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageChatCreatedType,
        string
    > _enumToString = new() { { ServerMessageChatCreatedType.ChatCreated, "chat.created" } };

    public override ServerMessageChatCreatedType Read(
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
        ServerMessageChatCreatedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageChatCreatedType ReadAsPropertyName(
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
        ServerMessageChatCreatedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
