using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(JsonQueryOnCallTableWithStructuredOutputColumnTypeSerializer))]
public enum JsonQueryOnCallTableWithStructuredOutputColumnType
{
    [EnumMember(Value = "vapiql-json")]
    VapiqlJson,
}

internal class JsonQueryOnCallTableWithStructuredOutputColumnTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<JsonQueryOnCallTableWithStructuredOutputColumnType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        JsonQueryOnCallTableWithStructuredOutputColumnType
    > _stringToEnum = new()
    {
        { "vapiql-json", JsonQueryOnCallTableWithStructuredOutputColumnType.VapiqlJson },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        JsonQueryOnCallTableWithStructuredOutputColumnType,
        string
    > _enumToString = new()
    {
        { JsonQueryOnCallTableWithStructuredOutputColumnType.VapiqlJson, "vapiql-json" },
    };

    public override JsonQueryOnCallTableWithStructuredOutputColumnType Read(
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
        JsonQueryOnCallTableWithStructuredOutputColumnType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override JsonQueryOnCallTableWithStructuredOutputColumnType ReadAsPropertyName(
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
        JsonQueryOnCallTableWithStructuredOutputColumnType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
