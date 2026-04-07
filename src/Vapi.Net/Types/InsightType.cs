using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(InsightTypeSerializer))]
public enum InsightType
{
    [EnumMember(Value = "bar")]
    Bar,

    [EnumMember(Value = "line")]
    Line,

    [EnumMember(Value = "pie")]
    Pie,

    [EnumMember(Value = "text")]
    Text,
}

internal class InsightTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<InsightType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        InsightType
    > _stringToEnum = new()
    {
        { "bar", InsightType.Bar },
        { "line", InsightType.Line },
        { "pie", InsightType.Pie },
        { "text", InsightType.Text },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        InsightType,
        string
    > _enumToString = new()
    {
        { InsightType.Bar, "bar" },
        { InsightType.Line, "line" },
        { InsightType.Pie, "pie" },
        { InsightType.Text, "text" },
    };

    public override InsightType Read(
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
        InsightType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override InsightType ReadAsPropertyName(
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
        InsightType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
