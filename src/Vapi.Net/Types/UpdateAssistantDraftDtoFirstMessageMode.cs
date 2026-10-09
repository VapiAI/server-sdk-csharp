using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(UpdateAssistantDraftDtoFirstMessageModeSerializer))]
public enum UpdateAssistantDraftDtoFirstMessageMode
{
    [EnumMember(Value = "assistant-speaks-first")]
    AssistantSpeaksFirst,

    [EnumMember(Value = "assistant-speaks-first-with-model-generated-message")]
    AssistantSpeaksFirstWithModelGeneratedMessage,

    [EnumMember(Value = "assistant-waits-for-user")]
    AssistantWaitsForUser,
}

internal class UpdateAssistantDraftDtoFirstMessageModeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<UpdateAssistantDraftDtoFirstMessageMode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        UpdateAssistantDraftDtoFirstMessageMode
    > _stringToEnum = new()
    {
        { "assistant-speaks-first", UpdateAssistantDraftDtoFirstMessageMode.AssistantSpeaksFirst },
        {
            "assistant-speaks-first-with-model-generated-message",
            UpdateAssistantDraftDtoFirstMessageMode.AssistantSpeaksFirstWithModelGeneratedMessage
        },
        {
            "assistant-waits-for-user",
            UpdateAssistantDraftDtoFirstMessageMode.AssistantWaitsForUser
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        UpdateAssistantDraftDtoFirstMessageMode,
        string
    > _enumToString = new()
    {
        { UpdateAssistantDraftDtoFirstMessageMode.AssistantSpeaksFirst, "assistant-speaks-first" },
        {
            UpdateAssistantDraftDtoFirstMessageMode.AssistantSpeaksFirstWithModelGeneratedMessage,
            "assistant-speaks-first-with-model-generated-message"
        },
        {
            UpdateAssistantDraftDtoFirstMessageMode.AssistantWaitsForUser,
            "assistant-waits-for-user"
        },
    };

    public override UpdateAssistantDraftDtoFirstMessageMode Read(
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
        UpdateAssistantDraftDtoFirstMessageMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override UpdateAssistantDraftDtoFirstMessageMode ReadAsPropertyName(
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
        UpdateAssistantDraftDtoFirstMessageMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
