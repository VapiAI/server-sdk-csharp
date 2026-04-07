using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FileStatusSerializer))]
public enum FileStatus
{
    [EnumMember(Value = "processing")]
    Processing,

    [EnumMember(Value = "done")]
    Done,

    [EnumMember(Value = "failed")]
    Failed,
}

internal class FileStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FileStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FileStatus
    > _stringToEnum = new()
    {
        { "processing", FileStatus.Processing },
        { "done", FileStatus.Done },
        { "failed", FileStatus.Failed },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FileStatus,
        string
    > _enumToString = new()
    {
        { FileStatus.Processing, "processing" },
        { FileStatus.Done, "done" },
        { FileStatus.Failed, "failed" },
    };

    public override FileStatus Read(
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
        FileStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FileStatus ReadAsPropertyName(
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
        FileStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
