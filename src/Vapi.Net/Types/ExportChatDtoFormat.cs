using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ExportChatDtoFormatSerializer))]
public enum ExportChatDtoFormat
{
    [EnumMember(Value = "csv")]
    Csv,

    [EnumMember(Value = "json")]
    Json,
}

internal class ExportChatDtoFormatSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ExportChatDtoFormat>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ExportChatDtoFormat
    > _stringToEnum = new()
    {
        { "csv", ExportChatDtoFormat.Csv },
        { "json", ExportChatDtoFormat.Json },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ExportChatDtoFormat,
        string
    > _enumToString = new()
    {
        { ExportChatDtoFormat.Csv, "csv" },
        { ExportChatDtoFormat.Json, "json" },
    };

    public override ExportChatDtoFormat Read(
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
        ExportChatDtoFormat value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ExportChatDtoFormat ReadAsPropertyName(
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
        ExportChatDtoFormat value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
