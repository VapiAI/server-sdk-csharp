using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ToolMessageCompleteRoleSerializer))]
public enum ToolMessageCompleteRole
{
    [EnumMember(Value = "assistant")]
    Assistant,

    [EnumMember(Value = "system")]
    System,
}

internal class ToolMessageCompleteRoleSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ToolMessageCompleteRole>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ToolMessageCompleteRole
    > _stringToEnum = new()
    {
        { "assistant", ToolMessageCompleteRole.Assistant },
        { "system", ToolMessageCompleteRole.System },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ToolMessageCompleteRole,
        string
    > _enumToString = new()
    {
        { ToolMessageCompleteRole.Assistant, "assistant" },
        { ToolMessageCompleteRole.System, "system" },
    };

    public override ToolMessageCompleteRole Read(
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
        ToolMessageCompleteRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ToolMessageCompleteRole ReadAsPropertyName(
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
        ToolMessageCompleteRole value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
