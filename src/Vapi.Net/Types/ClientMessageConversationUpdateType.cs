using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientMessageConversationUpdateTypeSerializer))]
public enum ClientMessageConversationUpdateType
{
    [EnumMember(Value = "conversation-update")]
    ConversationUpdate,
}

internal class ClientMessageConversationUpdateTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientMessageConversationUpdateType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientMessageConversationUpdateType
    > _stringToEnum = new()
    {
        { "conversation-update", ClientMessageConversationUpdateType.ConversationUpdate },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientMessageConversationUpdateType,
        string
    > _enumToString = new()
    {
        { ClientMessageConversationUpdateType.ConversationUpdate, "conversation-update" },
    };

    public override ClientMessageConversationUpdateType Read(
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
        ClientMessageConversationUpdateType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientMessageConversationUpdateType ReadAsPropertyName(
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
        ClientMessageConversationUpdateType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
