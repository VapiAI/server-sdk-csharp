using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ToolPinnedConflictResponseDtoErrorSerializer))]
public enum ToolPinnedConflictResponseDtoError
{
    [EnumMember(Value = "tool_pinned")]
    ToolPinned,
}

internal class ToolPinnedConflictResponseDtoErrorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ToolPinnedConflictResponseDtoError>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ToolPinnedConflictResponseDtoError
    > _stringToEnum = new() { { "tool_pinned", ToolPinnedConflictResponseDtoError.ToolPinned } };

    private static readonly global::System.Collections.Generic.Dictionary<
        ToolPinnedConflictResponseDtoError,
        string
    > _enumToString = new() { { ToolPinnedConflictResponseDtoError.ToolPinned, "tool_pinned" } };

    public override ToolPinnedConflictResponseDtoError Read(
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
        ToolPinnedConflictResponseDtoError value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ToolPinnedConflictResponseDtoError ReadAsPropertyName(
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
        ToolPinnedConflictResponseDtoError value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
