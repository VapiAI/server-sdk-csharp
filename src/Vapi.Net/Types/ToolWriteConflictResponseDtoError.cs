using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ToolWriteConflictResponseDtoErrorSerializer))]
public enum ToolWriteConflictResponseDtoError
{
    [EnumMember(Value = "tool_write_conflict")]
    ToolWriteConflict,
}

internal class ToolWriteConflictResponseDtoErrorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ToolWriteConflictResponseDtoError>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ToolWriteConflictResponseDtoError
    > _stringToEnum = new()
    {
        { "tool_write_conflict", ToolWriteConflictResponseDtoError.ToolWriteConflict },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ToolWriteConflictResponseDtoError,
        string
    > _enumToString = new()
    {
        { ToolWriteConflictResponseDtoError.ToolWriteConflict, "tool_write_conflict" },
    };

    public override ToolWriteConflictResponseDtoError Read(
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
        ToolWriteConflictResponseDtoError value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ToolWriteConflictResponseDtoError ReadAsPropertyName(
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
        ToolWriteConflictResponseDtoError value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
