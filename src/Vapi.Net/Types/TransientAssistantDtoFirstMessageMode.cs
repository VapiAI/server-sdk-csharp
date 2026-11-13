using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TransientAssistantDtoFirstMessageModeSerializer))]
public enum TransientAssistantDtoFirstMessageMode
{
    [EnumMember(Value = "assistant-speaks-first")]
    AssistantSpeaksFirst,

    [EnumMember(Value = "assistant-speaks-first-with-model-generated-message")]
    AssistantSpeaksFirstWithModelGeneratedMessage,

    [EnumMember(Value = "assistant-waits-for-user")]
    AssistantWaitsForUser,
}

internal class TransientAssistantDtoFirstMessageModeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TransientAssistantDtoFirstMessageMode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TransientAssistantDtoFirstMessageMode
    > _stringToEnum = new()
    {
        { "assistant-speaks-first", TransientAssistantDtoFirstMessageMode.AssistantSpeaksFirst },
        {
            "assistant-speaks-first-with-model-generated-message",
            TransientAssistantDtoFirstMessageMode.AssistantSpeaksFirstWithModelGeneratedMessage
        },
        { "assistant-waits-for-user", TransientAssistantDtoFirstMessageMode.AssistantWaitsForUser },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TransientAssistantDtoFirstMessageMode,
        string
    > _enumToString = new()
    {
        { TransientAssistantDtoFirstMessageMode.AssistantSpeaksFirst, "assistant-speaks-first" },
        {
            TransientAssistantDtoFirstMessageMode.AssistantSpeaksFirstWithModelGeneratedMessage,
            "assistant-speaks-first-with-model-generated-message"
        },
        { TransientAssistantDtoFirstMessageMode.AssistantWaitsForUser, "assistant-waits-for-user" },
    };

    public override TransientAssistantDtoFirstMessageMode Read(
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
        TransientAssistantDtoFirstMessageMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TransientAssistantDtoFirstMessageMode ReadAsPropertyName(
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
        TransientAssistantDtoFirstMessageMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
