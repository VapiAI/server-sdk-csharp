using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageSessionUpdatedTypeSerializer))]
public enum ServerMessageSessionUpdatedType
{
    [EnumMember(Value = "session.updated")]
    SessionUpdated,
}

internal class ServerMessageSessionUpdatedTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageSessionUpdatedType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageSessionUpdatedType
    > _stringToEnum = new()
    {
        { "session.updated", ServerMessageSessionUpdatedType.SessionUpdated },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageSessionUpdatedType,
        string
    > _enumToString = new()
    {
        { ServerMessageSessionUpdatedType.SessionUpdated, "session.updated" },
    };

    public override ServerMessageSessionUpdatedType Read(
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
        ServerMessageSessionUpdatedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageSessionUpdatedType ReadAsPropertyName(
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
        ServerMessageSessionUpdatedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
