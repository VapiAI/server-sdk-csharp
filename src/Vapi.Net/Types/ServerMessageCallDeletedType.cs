using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageCallDeletedTypeSerializer))]
public enum ServerMessageCallDeletedType
{
    [EnumMember(Value = "call.deleted")]
    CallDeleted,
}

internal class ServerMessageCallDeletedTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageCallDeletedType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageCallDeletedType
    > _stringToEnum = new() { { "call.deleted", ServerMessageCallDeletedType.CallDeleted } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageCallDeletedType,
        string
    > _enumToString = new() { { ServerMessageCallDeletedType.CallDeleted, "call.deleted" } };

    public override ServerMessageCallDeletedType Read(
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
        ServerMessageCallDeletedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageCallDeletedType ReadAsPropertyName(
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
        ServerMessageCallDeletedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
