using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(JsonQueryOnCallTableWithStructuredOutputColumnTableSerializer))]
public enum JsonQueryOnCallTableWithStructuredOutputColumnTable
{
    [EnumMember(Value = "call")]
    Call,
}

internal class JsonQueryOnCallTableWithStructuredOutputColumnTableSerializer
    : global::System.Text.Json.Serialization.JsonConverter<JsonQueryOnCallTableWithStructuredOutputColumnTable>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        JsonQueryOnCallTableWithStructuredOutputColumnTable
    > _stringToEnum = new()
    {
        { "call", JsonQueryOnCallTableWithStructuredOutputColumnTable.Call },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        JsonQueryOnCallTableWithStructuredOutputColumnTable,
        string
    > _enumToString = new()
    {
        { JsonQueryOnCallTableWithStructuredOutputColumnTable.Call, "call" },
    };

    public override JsonQueryOnCallTableWithStructuredOutputColumnTable Read(
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
        JsonQueryOnCallTableWithStructuredOutputColumnTable value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override JsonQueryOnCallTableWithStructuredOutputColumnTable ReadAsPropertyName(
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
        JsonQueryOnCallTableWithStructuredOutputColumnTable value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
