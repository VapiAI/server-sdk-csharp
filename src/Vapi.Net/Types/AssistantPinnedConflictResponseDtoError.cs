using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(AssistantPinnedConflictResponseDtoErrorSerializer))]
public enum AssistantPinnedConflictResponseDtoError
{
    [EnumMember(Value = "assistant_pinned")]
    AssistantPinned,
}

internal class AssistantPinnedConflictResponseDtoErrorSerializer
    : global::System.Text.Json.Serialization.JsonConverter<AssistantPinnedConflictResponseDtoError>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        AssistantPinnedConflictResponseDtoError
    > _stringToEnum = new()
    {
        { "assistant_pinned", AssistantPinnedConflictResponseDtoError.AssistantPinned },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        AssistantPinnedConflictResponseDtoError,
        string
    > _enumToString = new()
    {
        { AssistantPinnedConflictResponseDtoError.AssistantPinned, "assistant_pinned" },
    };

    public override AssistantPinnedConflictResponseDtoError Read(
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
        AssistantPinnedConflictResponseDtoError value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override AssistantPinnedConflictResponseDtoError ReadAsPropertyName(
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
        AssistantPinnedConflictResponseDtoError value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
