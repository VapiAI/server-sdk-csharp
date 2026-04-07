using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(PieInsightFromCallTableTypeSerializer))]
public enum PieInsightFromCallTableType
{
    [EnumMember(Value = "pie")]
    Pie,
}

internal class PieInsightFromCallTableTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<PieInsightFromCallTableType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PieInsightFromCallTableType
    > _stringToEnum = new() { { "pie", PieInsightFromCallTableType.Pie } };

    private static readonly global::System.Collections.Generic.Dictionary<
        PieInsightFromCallTableType,
        string
    > _enumToString = new() { { PieInsightFromCallTableType.Pie, "pie" } };

    public override PieInsightFromCallTableType Read(
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
        PieInsightFromCallTableType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PieInsightFromCallTableType ReadAsPropertyName(
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
        PieInsightFromCallTableType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
