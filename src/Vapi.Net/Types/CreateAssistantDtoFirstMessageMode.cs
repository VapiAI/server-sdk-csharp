using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateAssistantDtoFirstMessageModeSerializer))]
public enum CreateAssistantDtoFirstMessageMode
{
    [EnumMember(Value = "assistant-speaks-first")]
    AssistantSpeaksFirst,

    [EnumMember(Value = "assistant-speaks-first-with-model-generated-message")]
    AssistantSpeaksFirstWithModelGeneratedMessage,

    [EnumMember(Value = "assistant-waits-for-user")]
    AssistantWaitsForUser,
}

internal class CreateAssistantDtoFirstMessageModeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateAssistantDtoFirstMessageMode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateAssistantDtoFirstMessageMode
    > _stringToEnum = new()
    {
        { "assistant-speaks-first", CreateAssistantDtoFirstMessageMode.AssistantSpeaksFirst },
        {
            "assistant-speaks-first-with-model-generated-message",
            CreateAssistantDtoFirstMessageMode.AssistantSpeaksFirstWithModelGeneratedMessage
        },
        { "assistant-waits-for-user", CreateAssistantDtoFirstMessageMode.AssistantWaitsForUser },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateAssistantDtoFirstMessageMode,
        string
    > _enumToString = new()
    {
        { CreateAssistantDtoFirstMessageMode.AssistantSpeaksFirst, "assistant-speaks-first" },
        {
            CreateAssistantDtoFirstMessageMode.AssistantSpeaksFirstWithModelGeneratedMessage,
            "assistant-speaks-first-with-model-generated-message"
        },
        { CreateAssistantDtoFirstMessageMode.AssistantWaitsForUser, "assistant-waits-for-user" },
    };

    public override CreateAssistantDtoFirstMessageMode Read(
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
        CreateAssistantDtoFirstMessageMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateAssistantDtoFirstMessageMode ReadAsPropertyName(
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
        CreateAssistantDtoFirstMessageMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
