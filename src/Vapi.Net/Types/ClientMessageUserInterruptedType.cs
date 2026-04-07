using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientMessageUserInterruptedTypeSerializer))]
public enum ClientMessageUserInterruptedType
{
    [EnumMember(Value = "user-interrupted")]
    UserInterrupted,
}

internal class ClientMessageUserInterruptedTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientMessageUserInterruptedType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientMessageUserInterruptedType
    > _stringToEnum = new()
    {
        { "user-interrupted", ClientMessageUserInterruptedType.UserInterrupted },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientMessageUserInterruptedType,
        string
    > _enumToString = new()
    {
        { ClientMessageUserInterruptedType.UserInterrupted, "user-interrupted" },
    };

    public override ClientMessageUserInterruptedType Read(
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
        ClientMessageUserInterruptedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientMessageUserInterruptedType ReadAsPropertyName(
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
        ClientMessageUserInterruptedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
