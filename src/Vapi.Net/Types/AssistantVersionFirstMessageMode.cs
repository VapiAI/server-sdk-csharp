using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssistantVersionFirstMessageModeSerializer))]
public enum AssistantVersionFirstMessageMode
{
    [EnumMember(Value = "assistant-speaks-first")]
    AssistantSpeaksFirst,

    [EnumMember(Value = "assistant-speaks-first-with-model-generated-message")]
    AssistantSpeaksFirstWithModelGeneratedMessage,

    [EnumMember(Value = "assistant-waits-for-user")]
    AssistantWaitsForUser,
}

internal class AssistantVersionFirstMessageModeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssistantVersionFirstMessageMode>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssistantVersionFirstMessageMode
    > _stringToEnum = new()
    {
        { "assistant-speaks-first", AssistantVersionFirstMessageMode.AssistantSpeaksFirst },
        {
            "assistant-speaks-first-with-model-generated-message",
            AssistantVersionFirstMessageMode.AssistantSpeaksFirstWithModelGeneratedMessage
        },
        { "assistant-waits-for-user", AssistantVersionFirstMessageMode.AssistantWaitsForUser },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssistantVersionFirstMessageMode,
        string
    > _enumToString = new()
    {
        { AssistantVersionFirstMessageMode.AssistantSpeaksFirst, "assistant-speaks-first" },
        {
            AssistantVersionFirstMessageMode.AssistantSpeaksFirstWithModelGeneratedMessage,
            "assistant-speaks-first-with-model-generated-message"
        },
        { AssistantVersionFirstMessageMode.AssistantWaitsForUser, "assistant-waits-for-user" },
    };

    public override AssistantVersionFirstMessageMode Read(
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
        AssistantVersionFirstMessageMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssistantVersionFirstMessageMode ReadAsPropertyName(
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
        AssistantVersionFirstMessageMode value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
