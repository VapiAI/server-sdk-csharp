using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageSessionCreatedTypeSerializer))]
public enum ServerMessageSessionCreatedType
{
    [EnumMember(Value = "session.created")]
    SessionCreated,
}

internal class ServerMessageSessionCreatedTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageSessionCreatedType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageSessionCreatedType
    > _stringToEnum = new()
    {
        { "session.created", ServerMessageSessionCreatedType.SessionCreated },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageSessionCreatedType,
        string
    > _enumToString = new()
    {
        { ServerMessageSessionCreatedType.SessionCreated, "session.created" },
    };

    public override ServerMessageSessionCreatedType Read(
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
        ServerMessageSessionCreatedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageSessionCreatedType ReadAsPropertyName(
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
        ServerMessageSessionCreatedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
