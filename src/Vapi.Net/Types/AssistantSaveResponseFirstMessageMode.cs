using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssistantSaveResponseFirstMessageModeSerializer))]
public enum AssistantSaveResponseFirstMessageMode
{
    [EnumMember(Value = "assistant-speaks-first")]
    AssistantSpeaksFirst,

    [EnumMember(Value = "assistant-speaks-first-with-model-generated-message")]
    AssistantSpeaksFirstWithModelGeneratedMessage,

    [EnumMember(Value = "assistant-waits-for-user")]
    AssistantWaitsForUser,
}

internal class AssistantSaveResponseFirstMessageModeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssistantSaveResponseFirstMessageMode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssistantSaveResponseFirstMessageMode
    > _stringToEnum = new()
    {
        { "assistant-speaks-first", AssistantSaveResponseFirstMessageMode.AssistantSpeaksFirst },
        {
            "assistant-speaks-first-with-model-generated-message",
            AssistantSaveResponseFirstMessageMode.AssistantSpeaksFirstWithModelGeneratedMessage
        },
        { "assistant-waits-for-user", AssistantSaveResponseFirstMessageMode.AssistantWaitsForUser },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssistantSaveResponseFirstMessageMode,
        string
    > _enumToString = new()
    {
        { AssistantSaveResponseFirstMessageMode.AssistantSpeaksFirst, "assistant-speaks-first" },
        {
            AssistantSaveResponseFirstMessageMode.AssistantSpeaksFirstWithModelGeneratedMessage,
            "assistant-speaks-first-with-model-generated-message"
        },
        { AssistantSaveResponseFirstMessageMode.AssistantWaitsForUser, "assistant-waits-for-user" },
    };

    public override AssistantSaveResponseFirstMessageMode Read(
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
        AssistantSaveResponseFirstMessageMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssistantSaveResponseFirstMessageMode ReadAsPropertyName(
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
        AssistantSaveResponseFirstMessageMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
