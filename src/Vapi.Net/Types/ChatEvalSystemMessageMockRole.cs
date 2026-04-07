using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ChatEvalSystemMessageMockRoleSerializer))]
public enum ChatEvalSystemMessageMockRole
{
    [EnumMember(Value = "system")]
    System,
}

internal class ChatEvalSystemMessageMockRoleSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ChatEvalSystemMessageMockRole>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ChatEvalSystemMessageMockRole
    > _stringToEnum = new() { { "system", ChatEvalSystemMessageMockRole.System } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ChatEvalSystemMessageMockRole,
        string
    > _enumToString = new() { { ChatEvalSystemMessageMockRole.System, "system" } };

    public override ChatEvalSystemMessageMockRole Read(
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
        ChatEvalSystemMessageMockRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ChatEvalSystemMessageMockRole ReadAsPropertyName(
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
        ChatEvalSystemMessageMockRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
