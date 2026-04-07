using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessagePhoneCallControlTypeSerializer))]
public enum ServerMessagePhoneCallControlType
{
    [EnumMember(Value = "phone-call-control")]
    PhoneCallControl,
}

internal class ServerMessagePhoneCallControlTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessagePhoneCallControlType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessagePhoneCallControlType
    > _stringToEnum = new()
    {
        { "phone-call-control", ServerMessagePhoneCallControlType.PhoneCallControl },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessagePhoneCallControlType,
        string
    > _enumToString = new()
    {
        { ServerMessagePhoneCallControlType.PhoneCallControl, "phone-call-control" },
    };

    public override ServerMessagePhoneCallControlType Read(
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
        ServerMessagePhoneCallControlType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessagePhoneCallControlType ReadAsPropertyName(
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
        ServerMessagePhoneCallControlType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
