using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientMessageCallDeleteFailedTypeSerializer))]
public enum ClientMessageCallDeleteFailedType
{
    [EnumMember(Value = "call.delete.failed")]
    CallDeleteFailed,
}

internal class ClientMessageCallDeleteFailedTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientMessageCallDeleteFailedType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientMessageCallDeleteFailedType
    > _stringToEnum = new()
    {
        { "call.delete.failed", ClientMessageCallDeleteFailedType.CallDeleteFailed },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientMessageCallDeleteFailedType,
        string
    > _enumToString = new()
    {
        { ClientMessageCallDeleteFailedType.CallDeleteFailed, "call.delete.failed" },
    };

    public override ClientMessageCallDeleteFailedType Read(
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
        ClientMessageCallDeleteFailedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientMessageCallDeleteFailedType ReadAsPropertyName(
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
        ClientMessageCallDeleteFailedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
