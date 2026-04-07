using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(LineInsightFromCallTableTypeSerializer))]
public enum LineInsightFromCallTableType
{
    [EnumMember(Value = "line")]
    Line,
}

internal class LineInsightFromCallTableTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<LineInsightFromCallTableType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        LineInsightFromCallTableType
    > _stringToEnum = new() { { "line", LineInsightFromCallTableType.Line } };

    private static readonly global::System.Collections.Generic.Dictionary<
        LineInsightFromCallTableType,
        string
    > _enumToString = new() { { LineInsightFromCallTableType.Line, "line" } };

    public override LineInsightFromCallTableType Read(
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
        LineInsightFromCallTableType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override LineInsightFromCallTableType ReadAsPropertyName(
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
        LineInsightFromCallTableType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
