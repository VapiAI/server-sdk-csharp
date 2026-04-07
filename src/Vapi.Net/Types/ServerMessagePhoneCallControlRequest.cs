using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessagePhoneCallControlRequestSerializer))]
public enum ServerMessagePhoneCallControlRequest
{
    [EnumMember(Value = "forward")]
    Forward,

    [EnumMember(Value = "hang-up")]
    HangUp,
}

internal class ServerMessagePhoneCallControlRequestSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessagePhoneCallControlRequest>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessagePhoneCallControlRequest
    > _stringToEnum = new()
    {
        { "forward", ServerMessagePhoneCallControlRequest.Forward },
        { "hang-up", ServerMessagePhoneCallControlRequest.HangUp },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessagePhoneCallControlRequest,
        string
    > _enumToString = new()
    {
        { ServerMessagePhoneCallControlRequest.Forward, "forward" },
        { ServerMessagePhoneCallControlRequest.HangUp, "hang-up" },
    };

    public override ServerMessagePhoneCallControlRequest Read(
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
        ServerMessagePhoneCallControlRequest value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessagePhoneCallControlRequest ReadAsPropertyName(
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
        ServerMessagePhoneCallControlRequest value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
