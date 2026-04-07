using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageCallDeleteFailedTypeSerializer))]
public enum ServerMessageCallDeleteFailedType
{
    [EnumMember(Value = "call.delete.failed")]
    CallDeleteFailed,
}

internal class ServerMessageCallDeleteFailedTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageCallDeleteFailedType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageCallDeleteFailedType
    > _stringToEnum = new()
    {
        { "call.delete.failed", ServerMessageCallDeleteFailedType.CallDeleteFailed },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageCallDeleteFailedType,
        string
    > _enumToString = new()
    {
        { ServerMessageCallDeleteFailedType.CallDeleteFailed, "call.delete.failed" },
    };

    public override ServerMessageCallDeleteFailedType Read(
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
        ServerMessageCallDeleteFailedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageCallDeleteFailedType ReadAsPropertyName(
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
        ServerMessageCallDeleteFailedType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
