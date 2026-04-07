using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(JsonQueryOnCallTableWithNumberTypeColumnOperationSerializer))]
public enum JsonQueryOnCallTableWithNumberTypeColumnOperation
{
    [EnumMember(Value = "average")]
    Average,

    [EnumMember(Value = "sum")]
    Sum,

    [EnumMember(Value = "min")]
    Min,

    [EnumMember(Value = "max")]
    Max,
}

internal class JsonQueryOnCallTableWithNumberTypeColumnOperationSerializer
    : global::System.Text.Json.Serialization.JsonConverter<JsonQueryOnCallTableWithNumberTypeColumnOperation>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        JsonQueryOnCallTableWithNumberTypeColumnOperation
    > _stringToEnum = new()
    {
        { "average", JsonQueryOnCallTableWithNumberTypeColumnOperation.Average },
        { "sum", JsonQueryOnCallTableWithNumberTypeColumnOperation.Sum },
        { "min", JsonQueryOnCallTableWithNumberTypeColumnOperation.Min },
        { "max", JsonQueryOnCallTableWithNumberTypeColumnOperation.Max },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        JsonQueryOnCallTableWithNumberTypeColumnOperation,
        string
    > _enumToString = new()
    {
        { JsonQueryOnCallTableWithNumberTypeColumnOperation.Average, "average" },
        { JsonQueryOnCallTableWithNumberTypeColumnOperation.Sum, "sum" },
        { JsonQueryOnCallTableWithNumberTypeColumnOperation.Min, "min" },
        { JsonQueryOnCallTableWithNumberTypeColumnOperation.Max, "max" },
    };

    public override JsonQueryOnCallTableWithNumberTypeColumnOperation Read(
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
        JsonQueryOnCallTableWithNumberTypeColumnOperation value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override JsonQueryOnCallTableWithNumberTypeColumnOperation ReadAsPropertyName(
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
        JsonQueryOnCallTableWithNumberTypeColumnOperation value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
