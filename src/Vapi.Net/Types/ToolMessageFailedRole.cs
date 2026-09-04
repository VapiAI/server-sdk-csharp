using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ToolMessageFailedRoleSerializer))]
public enum ToolMessageFailedRole
{
    [EnumMember(Value = "assistant")]
    Assistant,

    [EnumMember(Value = "system")]
    System,
}

internal class ToolMessageFailedRoleSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ToolMessageFailedRole>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ToolMessageFailedRole
    > _stringToEnum = new()
    {
        { "assistant", ToolMessageFailedRole.Assistant },
        { "system", ToolMessageFailedRole.System },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ToolMessageFailedRole,
        string
    > _enumToString = new()
    {
        { ToolMessageFailedRole.Assistant, "assistant" },
        { ToolMessageFailedRole.System, "system" },
    };

    public override ToolMessageFailedRole Read(
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
        ToolMessageFailedRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ToolMessageFailedRole ReadAsPropertyName(
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
        ToolMessageFailedRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
