using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientMessageSessionUpdatedTypeSerializer))]
public enum ClientMessageSessionUpdatedType
{
    [EnumMember(Value = "session.updated")]
    SessionUpdated,
}

internal class ClientMessageSessionUpdatedTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientMessageSessionUpdatedType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientMessageSessionUpdatedType
    > _stringToEnum = new()
    {
        { "session.updated", ClientMessageSessionUpdatedType.SessionUpdated },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientMessageSessionUpdatedType,
        string
    > _enumToString = new()
    {
        { ClientMessageSessionUpdatedType.SessionUpdated, "session.updated" },
    };

    public override ClientMessageSessionUpdatedType Read(
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
        ClientMessageSessionUpdatedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientMessageSessionUpdatedType ReadAsPropertyName(
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
        ClientMessageSessionUpdatedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
