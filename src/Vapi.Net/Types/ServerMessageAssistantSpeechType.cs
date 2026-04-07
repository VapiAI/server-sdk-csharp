using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageAssistantSpeechTypeSerializer))]
public enum ServerMessageAssistantSpeechType
{
    [EnumMember(Value = "assistant.speechStarted")]
    AssistantSpeechStarted,
}

internal class ServerMessageAssistantSpeechTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageAssistantSpeechType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageAssistantSpeechType
    > _stringToEnum = new()
    {
        { "assistant.speechStarted", ServerMessageAssistantSpeechType.AssistantSpeechStarted },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageAssistantSpeechType,
        string
    > _enumToString = new()
    {
        { ServerMessageAssistantSpeechType.AssistantSpeechStarted, "assistant.speechStarted" },
    };

    public override ServerMessageAssistantSpeechType Read(
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
        ServerMessageAssistantSpeechType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageAssistantSpeechType ReadAsPropertyName(
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
        ServerMessageAssistantSpeechType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
