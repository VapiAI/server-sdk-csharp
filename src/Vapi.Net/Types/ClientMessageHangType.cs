using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientMessageHangTypeSerializer))]
public enum ClientMessageHangType
{
    [EnumMember(Value = "hang")]
    Hang,
}

internal class ClientMessageHangTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientMessageHangType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientMessageHangType
    > _stringToEnum = new() { { "hang", ClientMessageHangType.Hang } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientMessageHangType,
        string
    > _enumToString = new() { { ClientMessageHangType.Hang, "hang" } };

    public override ClientMessageHangType Read(
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
        ClientMessageHangType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientMessageHangType ReadAsPropertyName(
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
        ClientMessageHangType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
