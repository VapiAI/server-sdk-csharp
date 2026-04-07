using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ChatEvalUserMessageMockRoleSerializer))]
public enum ChatEvalUserMessageMockRole
{
    [EnumMember(Value = "user")]
    User,
}

internal class ChatEvalUserMessageMockRoleSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ChatEvalUserMessageMockRole>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ChatEvalUserMessageMockRole
    > _stringToEnum = new() { { "user", ChatEvalUserMessageMockRole.User } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ChatEvalUserMessageMockRole,
        string
    > _enumToString = new() { { ChatEvalUserMessageMockRole.User, "user" } };

    public override ChatEvalUserMessageMockRole Read(
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
        ChatEvalUserMessageMockRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ChatEvalUserMessageMockRole ReadAsPropertyName(
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
        ChatEvalUserMessageMockRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
