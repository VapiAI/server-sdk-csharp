using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientMessageSessionDeletedTypeSerializer))]
public enum ClientMessageSessionDeletedType
{
    [EnumMember(Value = "session.deleted")]
    SessionDeleted,
}

internal class ClientMessageSessionDeletedTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientMessageSessionDeletedType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientMessageSessionDeletedType
    > _stringToEnum = new()
    {
        { "session.deleted", ClientMessageSessionDeletedType.SessionDeleted },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientMessageSessionDeletedType,
        string
    > _enumToString = new()
    {
        { ClientMessageSessionDeletedType.SessionDeleted, "session.deleted" },
    };

    public override ClientMessageSessionDeletedType Read(
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
        ClientMessageSessionDeletedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientMessageSessionDeletedType ReadAsPropertyName(
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
        ClientMessageSessionDeletedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
