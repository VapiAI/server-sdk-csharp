using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ResponseOutputMessageStatusSerializer))]
public enum ResponseOutputMessageStatus
{
    [EnumMember(Value = "in_progress")]
    InProgress,

    [EnumMember(Value = "completed")]
    Completed,

    [EnumMember(Value = "incomplete")]
    Incomplete,
}

internal class ResponseOutputMessageStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ResponseOutputMessageStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ResponseOutputMessageStatus
    > _stringToEnum = new()
    {
        { "in_progress", ResponseOutputMessageStatus.InProgress },
        { "completed", ResponseOutputMessageStatus.Completed },
        { "incomplete", ResponseOutputMessageStatus.Incomplete },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ResponseOutputMessageStatus,
        string
    > _enumToString = new()
    {
        { ResponseOutputMessageStatus.InProgress, "in_progress" },
        { ResponseOutputMessageStatus.Completed, "completed" },
        { ResponseOutputMessageStatus.Incomplete, "incomplete" },
    };

    public override ResponseOutputMessageStatus Read(
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
        ResponseOutputMessageStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ResponseOutputMessageStatus ReadAsPropertyName(
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
        ResponseOutputMessageStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
