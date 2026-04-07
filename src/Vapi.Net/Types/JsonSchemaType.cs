using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(JsonSchemaTypeSerializer))]
public enum JsonSchemaType
{
    [EnumMember(Value = "string")]
    String,

    [EnumMember(Value = "number")]
    Number,

    [EnumMember(Value = "integer")]
    Integer,

    [EnumMember(Value = "boolean")]
    Boolean,

    [EnumMember(Value = "array")]
    Array,

    [EnumMember(Value = "object")]
    Object,
}

internal class JsonSchemaTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<JsonSchemaType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        JsonSchemaType
    > _stringToEnum = new()
    {
        { "string", JsonSchemaType.String },
        { "number", JsonSchemaType.Number },
        { "integer", JsonSchemaType.Integer },
        { "boolean", JsonSchemaType.Boolean },
        { "array", JsonSchemaType.Array },
        { "object", JsonSchemaType.Object },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        JsonSchemaType,
        string
    > _enumToString = new()
    {
        { JsonSchemaType.String, "string" },
        { JsonSchemaType.Number, "number" },
        { JsonSchemaType.Integer, "integer" },
        { JsonSchemaType.Boolean, "boolean" },
        { JsonSchemaType.Array, "array" },
        { JsonSchemaType.Object, "object" },
    };

    public override JsonSchemaType Read(
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
        JsonSchemaType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override JsonSchemaType ReadAsPropertyName(
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
        JsonSchemaType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
