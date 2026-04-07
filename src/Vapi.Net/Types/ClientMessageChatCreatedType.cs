using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientMessageChatCreatedTypeSerializer))]
public enum ClientMessageChatCreatedType
{
    [EnumMember(Value = "chat.created")]
    ChatCreated,
}

internal class ClientMessageChatCreatedTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientMessageChatCreatedType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientMessageChatCreatedType
    > _stringToEnum = new() { { "chat.created", ClientMessageChatCreatedType.ChatCreated } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientMessageChatCreatedType,
        string
    > _enumToString = new() { { ClientMessageChatCreatedType.ChatCreated, "chat.created" } };

    public override ClientMessageChatCreatedType Read(
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
        ClientMessageChatCreatedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientMessageChatCreatedType ReadAsPropertyName(
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
        ClientMessageChatCreatedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
