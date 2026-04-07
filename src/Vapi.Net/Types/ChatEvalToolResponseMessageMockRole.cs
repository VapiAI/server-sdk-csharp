using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ChatEvalToolResponseMessageMockRoleSerializer))]
public enum ChatEvalToolResponseMessageMockRole
{
    [EnumMember(Value = "tool")]
    Tool,
}

internal class ChatEvalToolResponseMessageMockRoleSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ChatEvalToolResponseMessageMockRole>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ChatEvalToolResponseMessageMockRole
    > _stringToEnum = new() { { "tool", ChatEvalToolResponseMessageMockRole.Tool } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ChatEvalToolResponseMessageMockRole,
        string
    > _enumToString = new() { { ChatEvalToolResponseMessageMockRole.Tool, "tool" } };

    public override ChatEvalToolResponseMessageMockRole Read(
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
        ChatEvalToolResponseMessageMockRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ChatEvalToolResponseMessageMockRole ReadAsPropertyName(
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
        ChatEvalToolResponseMessageMockRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
