using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(BoardInsightItemTypeSerializer))]
public enum BoardInsightItemType
{
    [EnumMember(Value = "insight")]
    Insight,
}

internal class BoardInsightItemTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<BoardInsightItemType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        BoardInsightItemType
    > _stringToEnum = new() { { "insight", BoardInsightItemType.Insight } };

    private static readonly global::System.Collections.Generic.Dictionary<
        BoardInsightItemType,
        string
    > _enumToString = new() { { BoardInsightItemType.Insight, "insight" } };

    public override BoardInsightItemType Read(
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
        BoardInsightItemType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override BoardInsightItemType ReadAsPropertyName(
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
        BoardInsightItemType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
