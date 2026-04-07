using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageVoiceRequestTypeSerializer))]
public enum ServerMessageVoiceRequestType
{
    [EnumMember(Value = "voice-request")]
    VoiceRequest,
}

internal class ServerMessageVoiceRequestTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageVoiceRequestType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageVoiceRequestType
    > _stringToEnum = new() { { "voice-request", ServerMessageVoiceRequestType.VoiceRequest } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageVoiceRequestType,
        string
    > _enumToString = new() { { ServerMessageVoiceRequestType.VoiceRequest, "voice-request" } };

    public override ServerMessageVoiceRequestType Read(
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
        ServerMessageVoiceRequestType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageVoiceRequestType ReadAsPropertyName(
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
        ServerMessageVoiceRequestType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
