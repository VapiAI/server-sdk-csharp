using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageConversationUpdateTypeSerializer))]
public enum ServerMessageConversationUpdateType
{
    [EnumMember(Value = "conversation-update")]
    ConversationUpdate,
}

internal class ServerMessageConversationUpdateTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageConversationUpdateType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageConversationUpdateType
    > _stringToEnum = new()
    {
        { "conversation-update", ServerMessageConversationUpdateType.ConversationUpdate },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageConversationUpdateType,
        string
    > _enumToString = new()
    {
        { ServerMessageConversationUpdateType.ConversationUpdate, "conversation-update" },
    };

    public override ServerMessageConversationUpdateType Read(
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
        ServerMessageConversationUpdateType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageConversationUpdateType ReadAsPropertyName(
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
        ServerMessageConversationUpdateType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
