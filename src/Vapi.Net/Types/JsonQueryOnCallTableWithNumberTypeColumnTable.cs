using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(JsonQueryOnCallTableWithNumberTypeColumnTableSerializer))]
public enum JsonQueryOnCallTableWithNumberTypeColumnTable
{
    [EnumMember(Value = "call")]
    Call,
}

internal class JsonQueryOnCallTableWithNumberTypeColumnTableSerializer
    : global::System.Text.Json.Serialization.JsonConverter<JsonQueryOnCallTableWithNumberTypeColumnTable>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        JsonQueryOnCallTableWithNumberTypeColumnTable
    > _stringToEnum = new() { { "call", JsonQueryOnCallTableWithNumberTypeColumnTable.Call } };

    private static readonly global::System.Collections.Generic.Dictionary<
        JsonQueryOnCallTableWithNumberTypeColumnTable,
        string
    > _enumToString = new() { { JsonQueryOnCallTableWithNumberTypeColumnTable.Call, "call" } };

    public override JsonQueryOnCallTableWithNumberTypeColumnTable Read(
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
        JsonQueryOnCallTableWithNumberTypeColumnTable value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override JsonQueryOnCallTableWithNumberTypeColumnTable ReadAsPropertyName(
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
        JsonQueryOnCallTableWithNumberTypeColumnTable value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
