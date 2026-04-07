using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ChatEvalAssistantMessageEvaluationRoleSerializer))]
public enum ChatEvalAssistantMessageEvaluationRole
{
    [EnumMember(Value = "assistant")]
    Assistant,
}

internal class ChatEvalAssistantMessageEvaluationRoleSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ChatEvalAssistantMessageEvaluationRole>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ChatEvalAssistantMessageEvaluationRole
    > _stringToEnum = new() { { "assistant", ChatEvalAssistantMessageEvaluationRole.Assistant } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ChatEvalAssistantMessageEvaluationRole,
        string
    > _enumToString = new() { { ChatEvalAssistantMessageEvaluationRole.Assistant, "assistant" } };

    public override ChatEvalAssistantMessageEvaluationRole Read(
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
        ChatEvalAssistantMessageEvaluationRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ChatEvalAssistantMessageEvaluationRole ReadAsPropertyName(
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
        ChatEvalAssistantMessageEvaluationRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
