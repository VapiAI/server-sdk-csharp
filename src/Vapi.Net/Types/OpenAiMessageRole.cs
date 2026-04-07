using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(OpenAiMessageRoleSerializer))]
public enum OpenAiMessageRole
{
    [EnumMember(Value = "assistant")]
    Assistant,

    [EnumMember(Value = "function")]
    Function,

    [EnumMember(Value = "user")]
    User,

    [EnumMember(Value = "system")]
    System,

    [EnumMember(Value = "tool")]
    Tool,
}

internal class OpenAiMessageRoleSerializer
    : global::System.Text.Json.Serialization.JsonConverter<OpenAiMessageRole>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        OpenAiMessageRole
    > _stringToEnum = new()
    {
        { "assistant", OpenAiMessageRole.Assistant },
        { "function", OpenAiMessageRole.Function },
        { "user", OpenAiMessageRole.User },
        { "system", OpenAiMessageRole.System },
        { "tool", OpenAiMessageRole.Tool },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        OpenAiMessageRole,
        string
    > _enumToString = new()
    {
        { OpenAiMessageRole.Assistant, "assistant" },
        { OpenAiMessageRole.Function, "function" },
        { OpenAiMessageRole.User, "user" },
        { OpenAiMessageRole.System, "system" },
        { OpenAiMessageRole.Tool, "tool" },
    };

    public override OpenAiMessageRole Read(
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
        OpenAiMessageRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override OpenAiMessageRole ReadAsPropertyName(
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
        OpenAiMessageRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
