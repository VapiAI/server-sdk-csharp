using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(MessageTargetRoleSerializer))]
public enum MessageTargetRole
{
    [EnumMember(Value = "user")]
    User,

    [EnumMember(Value = "assistant")]
    Assistant,
}

internal class MessageTargetRoleSerializer
    : global::System.Text.Json.Serialization.JsonConverter<MessageTargetRole>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        MessageTargetRole
    > _stringToEnum = new()
    {
        { "user", MessageTargetRole.User },
        { "assistant", MessageTargetRole.Assistant },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        MessageTargetRole,
        string
    > _enumToString = new()
    {
        { MessageTargetRole.User, "user" },
        { MessageTargetRole.Assistant, "assistant" },
    };

    public override MessageTargetRole Read(
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
        MessageTargetRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override MessageTargetRole ReadAsPropertyName(
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
        MessageTargetRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
