using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ExportSessionDtoFormatSerializer))]
public enum ExportSessionDtoFormat
{
    [EnumMember(Value = "csv")]
    Csv,

    [EnumMember(Value = "json")]
    Json,
}

internal class ExportSessionDtoFormatSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ExportSessionDtoFormat>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ExportSessionDtoFormat
    > _stringToEnum = new()
    {
        { "csv", ExportSessionDtoFormat.Csv },
        { "json", ExportSessionDtoFormat.Json },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ExportSessionDtoFormat,
        string
    > _enumToString = new()
    {
        { ExportSessionDtoFormat.Csv, "csv" },
        { ExportSessionDtoFormat.Json, "json" },
    };

    public override ExportSessionDtoFormat Read(
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
        ExportSessionDtoFormat value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ExportSessionDtoFormat ReadAsPropertyName(
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
        ExportSessionDtoFormat value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
