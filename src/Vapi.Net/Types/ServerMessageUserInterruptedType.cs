using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageUserInterruptedTypeSerializer))]
public enum ServerMessageUserInterruptedType
{
    [EnumMember(Value = "user-interrupted")]
    UserInterrupted,
}

internal class ServerMessageUserInterruptedTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageUserInterruptedType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageUserInterruptedType
    > _stringToEnum = new()
    {
        { "user-interrupted", ServerMessageUserInterruptedType.UserInterrupted },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageUserInterruptedType,
        string
    > _enumToString = new()
    {
        { ServerMessageUserInterruptedType.UserInterrupted, "user-interrupted" },
    };

    public override ServerMessageUserInterruptedType Read(
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
        ServerMessageUserInterruptedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageUserInterruptedType ReadAsPropertyName(
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
        ServerMessageUserInterruptedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
