using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ChatEvalAssistantMessageMockRoleSerializer))]
public enum ChatEvalAssistantMessageMockRole
{
    [EnumMember(Value = "assistant")]
    Assistant,
}

internal class ChatEvalAssistantMessageMockRoleSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ChatEvalAssistantMessageMockRole>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ChatEvalAssistantMessageMockRole
    > _stringToEnum = new() { { "assistant", ChatEvalAssistantMessageMockRole.Assistant } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ChatEvalAssistantMessageMockRole,
        string
    > _enumToString = new() { { ChatEvalAssistantMessageMockRole.Assistant, "assistant" } };

    public override ChatEvalAssistantMessageMockRole Read(
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
        ChatEvalAssistantMessageMockRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ChatEvalAssistantMessageMockRole ReadAsPropertyName(
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
        ChatEvalAssistantMessageMockRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
