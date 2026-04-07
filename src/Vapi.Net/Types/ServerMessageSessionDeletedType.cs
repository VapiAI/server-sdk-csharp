using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageSessionDeletedTypeSerializer))]
public enum ServerMessageSessionDeletedType
{
    [EnumMember(Value = "session.deleted")]
    SessionDeleted,
}

internal class ServerMessageSessionDeletedTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageSessionDeletedType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageSessionDeletedType
    > _stringToEnum = new()
    {
        { "session.deleted", ServerMessageSessionDeletedType.SessionDeleted },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageSessionDeletedType,
        string
    > _enumToString = new()
    {
        { ServerMessageSessionDeletedType.SessionDeleted, "session.deleted" },
    };

    public override ServerMessageSessionDeletedType Read(
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
        ServerMessageSessionDeletedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageSessionDeletedType ReadAsPropertyName(
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
        ServerMessageSessionDeletedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
