using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GoogleSheetsRowAppendToolWithToolCallTypeSerializer))]
public enum GoogleSheetsRowAppendToolWithToolCallType
{
    [EnumMember(Value = "google.sheets.row.append")]
    GoogleSheetsRowAppend,
}

internal class GoogleSheetsRowAppendToolWithToolCallTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GoogleSheetsRowAppendToolWithToolCallType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GoogleSheetsRowAppendToolWithToolCallType
    > _stringToEnum = new()
    {
        {
            "google.sheets.row.append",
            GoogleSheetsRowAppendToolWithToolCallType.GoogleSheetsRowAppend
        },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GoogleSheetsRowAppendToolWithToolCallType,
        string
    > _enumToString = new()
    {
        {
            GoogleSheetsRowAppendToolWithToolCallType.GoogleSheetsRowAppend,
            "google.sheets.row.append"
        },
    };

    public override GoogleSheetsRowAppendToolWithToolCallType Read(
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
        GoogleSheetsRowAppendToolWithToolCallType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GoogleSheetsRowAppendToolWithToolCallType ReadAsPropertyName(
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
        GoogleSheetsRowAppendToolWithToolCallType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
