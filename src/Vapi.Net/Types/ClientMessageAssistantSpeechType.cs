using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ClientMessageAssistantSpeechTypeSerializer))]
public enum ClientMessageAssistantSpeechType
{
    [EnumMember(Value = "assistant.speechStarted")]
    AssistantSpeechStarted,
}

internal class ClientMessageAssistantSpeechTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ClientMessageAssistantSpeechType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ClientMessageAssistantSpeechType
    > _stringToEnum = new()
    {
        { "assistant.speechStarted", ClientMessageAssistantSpeechType.AssistantSpeechStarted },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ClientMessageAssistantSpeechType,
        string
    > _enumToString = new()
    {
        { ClientMessageAssistantSpeechType.AssistantSpeechStarted, "assistant.speechStarted" },
    };

    public override ClientMessageAssistantSpeechType Read(
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
        ClientMessageAssistantSpeechType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ClientMessageAssistantSpeechType ReadAsPropertyName(
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
        ClientMessageAssistantSpeechType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
