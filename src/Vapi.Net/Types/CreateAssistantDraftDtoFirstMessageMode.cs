using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CreateAssistantDraftDtoFirstMessageModeSerializer))]
public enum CreateAssistantDraftDtoFirstMessageMode
{
    [EnumMember(Value = "assistant-speaks-first")]
    AssistantSpeaksFirst,

    [EnumMember(Value = "assistant-speaks-first-with-model-generated-message")]
    AssistantSpeaksFirstWithModelGeneratedMessage,

    [EnumMember(Value = "assistant-waits-for-user")]
    AssistantWaitsForUser,
}

internal class CreateAssistantDraftDtoFirstMessageModeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CreateAssistantDraftDtoFirstMessageMode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CreateAssistantDraftDtoFirstMessageMode
    > _stringToEnum = new()
    {
        { "assistant-speaks-first", CreateAssistantDraftDtoFirstMessageMode.AssistantSpeaksFirst },
        {
            "assistant-speaks-first-with-model-generated-message",
            CreateAssistantDraftDtoFirstMessageMode.AssistantSpeaksFirstWithModelGeneratedMessage
        },
        {
            "assistant-waits-for-user",
            CreateAssistantDraftDtoFirstMessageMode.AssistantWaitsForUser
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CreateAssistantDraftDtoFirstMessageMode,
        string
    > _enumToString = new()
    {
        { CreateAssistantDraftDtoFirstMessageMode.AssistantSpeaksFirst, "assistant-speaks-first" },
        {
            CreateAssistantDraftDtoFirstMessageMode.AssistantSpeaksFirstWithModelGeneratedMessage,
            "assistant-speaks-first-with-model-generated-message"
        },
        {
            CreateAssistantDraftDtoFirstMessageMode.AssistantWaitsForUser,
            "assistant-waits-for-user"
        },
    };

    public override CreateAssistantDraftDtoFirstMessageMode Read(
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
        CreateAssistantDraftDtoFirstMessageMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CreateAssistantDraftDtoFirstMessageMode ReadAsPropertyName(
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
        CreateAssistantDraftDtoFirstMessageMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
