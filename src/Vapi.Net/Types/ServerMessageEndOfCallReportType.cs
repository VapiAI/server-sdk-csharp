using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ServerMessageEndOfCallReportTypeSerializer))]
public enum ServerMessageEndOfCallReportType
{
    [EnumMember(Value = "end-of-call-report")]
    EndOfCallReport,
}

internal class ServerMessageEndOfCallReportTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ServerMessageEndOfCallReportType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ServerMessageEndOfCallReportType
    > _stringToEnum = new()
    {
        { "end-of-call-report", ServerMessageEndOfCallReportType.EndOfCallReport },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ServerMessageEndOfCallReportType,
        string
    > _enumToString = new()
    {
        { ServerMessageEndOfCallReportType.EndOfCallReport, "end-of-call-report" },
    };

    public override ServerMessageEndOfCallReportType Read(
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
        ServerMessageEndOfCallReportType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ServerMessageEndOfCallReportType ReadAsPropertyName(
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
        ServerMessageEndOfCallReportType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
