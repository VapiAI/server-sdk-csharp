using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(JsonQueryOnCallTableWithStructuredOutputColumnOperationSerializer))]
public enum JsonQueryOnCallTableWithStructuredOutputColumnOperation
{
    [EnumMember(Value = "average")]
    Average,

    [EnumMember(Value = "count")]
    Count,

    [EnumMember(Value = "sum")]
    Sum,

    [EnumMember(Value = "min")]
    Min,

    [EnumMember(Value = "max")]
    Max,
}

internal class JsonQueryOnCallTableWithStructuredOutputColumnOperationSerializer
    : global::System.Text.Json.Serialization.JsonConverter<JsonQueryOnCallTableWithStructuredOutputColumnOperation>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        JsonQueryOnCallTableWithStructuredOutputColumnOperation
    > _stringToEnum = new()
    {
        { "average", JsonQueryOnCallTableWithStructuredOutputColumnOperation.Average },
        { "count", JsonQueryOnCallTableWithStructuredOutputColumnOperation.Count },
        { "sum", JsonQueryOnCallTableWithStructuredOutputColumnOperation.Sum },
        { "min", JsonQueryOnCallTableWithStructuredOutputColumnOperation.Min },
        { "max", JsonQueryOnCallTableWithStructuredOutputColumnOperation.Max },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        JsonQueryOnCallTableWithStructuredOutputColumnOperation,
        string
    > _enumToString = new()
    {
        { JsonQueryOnCallTableWithStructuredOutputColumnOperation.Average, "average" },
        { JsonQueryOnCallTableWithStructuredOutputColumnOperation.Count, "count" },
        { JsonQueryOnCallTableWithStructuredOutputColumnOperation.Sum, "sum" },
        { JsonQueryOnCallTableWithStructuredOutputColumnOperation.Min, "min" },
        { JsonQueryOnCallTableWithStructuredOutputColumnOperation.Max, "max" },
    };

    public override JsonQueryOnCallTableWithStructuredOutputColumnOperation Read(
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
        JsonQueryOnCallTableWithStructuredOutputColumnOperation value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override JsonQueryOnCallTableWithStructuredOutputColumnOperation ReadAsPropertyName(
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
        JsonQueryOnCallTableWithStructuredOutputColumnOperation value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
