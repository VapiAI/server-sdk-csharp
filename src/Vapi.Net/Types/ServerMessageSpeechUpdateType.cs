using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageSpeechUpdateTypeSerializer))]
public enum ServerMessageSpeechUpdateType
{
    [EnumMember(Value = "speech-update")]
    SpeechUpdate,
}

internal class ServerMessageSpeechUpdateTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageSpeechUpdateType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageSpeechUpdateType
    > _stringToEnum = new() { { "speech-update", ServerMessageSpeechUpdateType.SpeechUpdate } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageSpeechUpdateType,
        string
    > _enumToString = new() { { ServerMessageSpeechUpdateType.SpeechUpdate, "speech-update" } };

    public override ServerMessageSpeechUpdateType Read(
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
        ServerMessageSpeechUpdateType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageSpeechUpdateType ReadAsPropertyName(
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
        ServerMessageSpeechUpdateType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
