using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientMessageChatDeletedTypeSerializer))]
public enum ClientMessageChatDeletedType
{
    [EnumMember(Value = "chat.deleted")]
    ChatDeleted,
}

internal class ClientMessageChatDeletedTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientMessageChatDeletedType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientMessageChatDeletedType
    > _stringToEnum = new() { { "chat.deleted", ClientMessageChatDeletedType.ChatDeleted } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientMessageChatDeletedType,
        string
    > _enumToString = new() { { ClientMessageChatDeletedType.ChatDeleted, "chat.deleted" } };

    public override ClientMessageChatDeletedType Read(
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
        ClientMessageChatDeletedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientMessageChatDeletedType ReadAsPropertyName(
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
        ClientMessageChatDeletedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
