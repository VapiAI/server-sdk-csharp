using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageVoiceInputTypeSerializer))]
public enum ServerMessageVoiceInputType
{
    [EnumMember(Value = "voice-input")]
    VoiceInput,
}

internal class ServerMessageVoiceInputTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageVoiceInputType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageVoiceInputType
    > _stringToEnum = new() { { "voice-input", ServerMessageVoiceInputType.VoiceInput } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageVoiceInputType,
        string
    > _enumToString = new() { { ServerMessageVoiceInputType.VoiceInput, "voice-input" } };

    public override ServerMessageVoiceInputType Read(
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
        ServerMessageVoiceInputType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageVoiceInputType ReadAsPropertyName(
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
        ServerMessageVoiceInputType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
