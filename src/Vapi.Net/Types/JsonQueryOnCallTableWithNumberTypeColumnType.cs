using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(JsonQueryOnCallTableWithNumberTypeColumnTypeSerializer))]
public enum JsonQueryOnCallTableWithNumberTypeColumnType
{
    [EnumMember(Value = "vapiql-json")]
    VapiqlJson,
}

internal class JsonQueryOnCallTableWithNumberTypeColumnTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<JsonQueryOnCallTableWithNumberTypeColumnType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        JsonQueryOnCallTableWithNumberTypeColumnType
    > _stringToEnum = new()
    {
        { "vapiql-json", JsonQueryOnCallTableWithNumberTypeColumnType.VapiqlJson },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        JsonQueryOnCallTableWithNumberTypeColumnType,
        string
    > _enumToString = new()
    {
        { JsonQueryOnCallTableWithNumberTypeColumnType.VapiqlJson, "vapiql-json" },
    };

    public override JsonQueryOnCallTableWithNumberTypeColumnType Read(
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
        JsonQueryOnCallTableWithNumberTypeColumnType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override JsonQueryOnCallTableWithNumberTypeColumnType ReadAsPropertyName(
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
        JsonQueryOnCallTableWithNumberTypeColumnType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
