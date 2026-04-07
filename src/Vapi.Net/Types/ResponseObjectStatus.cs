using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ResponseObjectStatusSerializer))]
public enum ResponseObjectStatus
{
    [EnumMember(Value = "completed")]
    Completed,

    [EnumMember(Value = "failed")]
    Failed,

    [EnumMember(Value = "in_progress")]
    InProgress,

    [EnumMember(Value = "incomplete")]
    Incomplete,
}

internal class ResponseObjectStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ResponseObjectStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ResponseObjectStatus
    > _stringToEnum = new()
    {
        { "completed", ResponseObjectStatus.Completed },
        { "failed", ResponseObjectStatus.Failed },
        { "in_progress", ResponseObjectStatus.InProgress },
        { "incomplete", ResponseObjectStatus.Incomplete },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ResponseObjectStatus,
        string
    > _enumToString = new()
    {
        { ResponseObjectStatus.Completed, "completed" },
        { ResponseObjectStatus.Failed, "failed" },
        { ResponseObjectStatus.InProgress, "in_progress" },
        { ResponseObjectStatus.Incomplete, "incomplete" },
    };

    public override ResponseObjectStatus Read(
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
        ResponseObjectStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ResponseObjectStatus ReadAsPropertyName(
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
        ResponseObjectStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
