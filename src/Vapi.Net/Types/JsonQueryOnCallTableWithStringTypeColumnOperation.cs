using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(JsonQueryOnCallTableWithStringTypeColumnOperationSerializer))]
public enum JsonQueryOnCallTableWithStringTypeColumnOperation
{
    [EnumMember(Value = "count")]
    Count,
}

internal class JsonQueryOnCallTableWithStringTypeColumnOperationSerializer
    : global::System.Text.Json.Serialization.JsonConverter<JsonQueryOnCallTableWithStringTypeColumnOperation>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        JsonQueryOnCallTableWithStringTypeColumnOperation
    > _stringToEnum = new()
    {
        { "count", JsonQueryOnCallTableWithStringTypeColumnOperation.Count },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        JsonQueryOnCallTableWithStringTypeColumnOperation,
        string
    > _enumToString = new()
    {
        { JsonQueryOnCallTableWithStringTypeColumnOperation.Count, "count" },
    };

    public override JsonQueryOnCallTableWithStringTypeColumnOperation Read(
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
        JsonQueryOnCallTableWithStringTypeColumnOperation value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override JsonQueryOnCallTableWithStringTypeColumnOperation ReadAsPropertyName(
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
        JsonQueryOnCallTableWithStringTypeColumnOperation value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
