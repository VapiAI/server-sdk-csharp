using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssistantDraftFirstMessageModeSerializer))]
public enum AssistantDraftFirstMessageMode
{
    [EnumMember(Value = "assistant-speaks-first")]
    AssistantSpeaksFirst,

    [EnumMember(Value = "assistant-speaks-first-with-model-generated-message")]
    AssistantSpeaksFirstWithModelGeneratedMessage,

    [EnumMember(Value = "assistant-waits-for-user")]
    AssistantWaitsForUser,
}

internal class AssistantDraftFirstMessageModeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssistantDraftFirstMessageMode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssistantDraftFirstMessageMode
    > _stringToEnum = new()
    {
        { "assistant-speaks-first", AssistantDraftFirstMessageMode.AssistantSpeaksFirst },
        {
            "assistant-speaks-first-with-model-generated-message",
            AssistantDraftFirstMessageMode.AssistantSpeaksFirstWithModelGeneratedMessage
        },
        { "assistant-waits-for-user", AssistantDraftFirstMessageMode.AssistantWaitsForUser },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssistantDraftFirstMessageMode,
        string
    > _enumToString = new()
    {
        { AssistantDraftFirstMessageMode.AssistantSpeaksFirst, "assistant-speaks-first" },
        {
            AssistantDraftFirstMessageMode.AssistantSpeaksFirstWithModelGeneratedMessage,
            "assistant-speaks-first-with-model-generated-message"
        },
        { AssistantDraftFirstMessageMode.AssistantWaitsForUser, "assistant-waits-for-user" },
    };

    public override AssistantDraftFirstMessageMode Read(
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
        AssistantDraftFirstMessageMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssistantDraftFirstMessageMode ReadAsPropertyName(
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
        AssistantDraftFirstMessageMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
