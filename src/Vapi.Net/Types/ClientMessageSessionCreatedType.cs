using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientMessageSessionCreatedTypeSerializer))]
public enum ClientMessageSessionCreatedType
{
    [EnumMember(Value = "session.created")]
    SessionCreated,
}

internal class ClientMessageSessionCreatedTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientMessageSessionCreatedType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientMessageSessionCreatedType
    > _stringToEnum = new()
    {
        { "session.created", ClientMessageSessionCreatedType.SessionCreated },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientMessageSessionCreatedType,
        string
    > _enumToString = new()
    {
        { ClientMessageSessionCreatedType.SessionCreated, "session.created" },
    };

    public override ClientMessageSessionCreatedType Read(
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
        ClientMessageSessionCreatedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientMessageSessionCreatedType ReadAsPropertyName(
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
        ClientMessageSessionCreatedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
