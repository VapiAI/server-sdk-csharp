using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageAssistantSpeechSourceSerializer))]
public enum ServerMessageAssistantSpeechSource
{
    [EnumMember(Value = "model")]
    Model,

    [EnumMember(Value = "force-say")]
    ForceSay,

    [EnumMember(Value = "custom-voice")]
    CustomVoice,
}

internal class ServerMessageAssistantSpeechSourceSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageAssistantSpeechSource>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageAssistantSpeechSource
    > _stringToEnum = new()
    {
        { "model", ServerMessageAssistantSpeechSource.Model },
        { "force-say", ServerMessageAssistantSpeechSource.ForceSay },
        { "custom-voice", ServerMessageAssistantSpeechSource.CustomVoice },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageAssistantSpeechSource,
        string
    > _enumToString = new()
    {
        { ServerMessageAssistantSpeechSource.Model, "model" },
        { ServerMessageAssistantSpeechSource.ForceSay, "force-say" },
        { ServerMessageAssistantSpeechSource.CustomVoice, "custom-voice" },
    };

    public override ServerMessageAssistantSpeechSource Read(
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
        ServerMessageAssistantSpeechSource value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageAssistantSpeechSource ReadAsPropertyName(
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
        ServerMessageAssistantSpeechSource value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
