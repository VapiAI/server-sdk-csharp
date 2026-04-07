using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CallHookAssistantSpeechInterruptedOnSerializer))]
public enum CallHookAssistantSpeechInterruptedOn
{
    [EnumMember(Value = "assistant.speech.interrupted")]
    AssistantSpeechInterrupted,
}

internal class CallHookAssistantSpeechInterruptedOnSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CallHookAssistantSpeechInterruptedOn>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CallHookAssistantSpeechInterruptedOn
    > _stringToEnum = new()
    {
        {
            "assistant.speech.interrupted",
            CallHookAssistantSpeechInterruptedOn.AssistantSpeechInterrupted
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CallHookAssistantSpeechInterruptedOn,
        string
    > _enumToString = new()
    {
        {
            CallHookAssistantSpeechInterruptedOn.AssistantSpeechInterrupted,
            "assistant.speech.interrupted"
        },
    };

    public override CallHookAssistantSpeechInterruptedOn Read(
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
        CallHookAssistantSpeechInterruptedOn value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CallHookAssistantSpeechInterruptedOn ReadAsPropertyName(
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
        CallHookAssistantSpeechInterruptedOn value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
