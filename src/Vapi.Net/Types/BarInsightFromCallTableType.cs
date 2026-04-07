using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(BarInsightFromCallTableTypeSerializer))]
public enum BarInsightFromCallTableType
{
    [EnumMember(Value = "bar")]
    Bar,
}

internal class BarInsightFromCallTableTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<BarInsightFromCallTableType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        BarInsightFromCallTableType
    > _stringToEnum = new() { { "bar", BarInsightFromCallTableType.Bar } };

    private static readonly global::System.Collections.Generic.Dictionary<
        BarInsightFromCallTableType,
        string
    > _enumToString = new() { { BarInsightFromCallTableType.Bar, "bar" } };

    public override BarInsightFromCallTableType Read(
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
        BarInsightFromCallTableType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override BarInsightFromCallTableType ReadAsPropertyName(
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
        BarInsightFromCallTableType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
