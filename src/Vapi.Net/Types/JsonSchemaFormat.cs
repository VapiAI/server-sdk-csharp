using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(JsonSchemaFormatSerializer))]
public enum JsonSchemaFormat
{
    [EnumMember(Value = "date-time")]
    DateTime,

    [EnumMember(Value = "time")]
    Time,

    [EnumMember(Value = "date")]
    Date,

    [EnumMember(Value = "duration")]
    Duration,

    [EnumMember(Value = "email")]
    Email,

    [EnumMember(Value = "hostname")]
    Hostname,

    [EnumMember(Value = "ipv4")]
    Ipv4,

    [EnumMember(Value = "ipv6")]
    Ipv6,

    [EnumMember(Value = "uuid")]
    Uuid,
}

internal class JsonSchemaFormatSerializer
    : global::System.Text.Json.Serialization.JsonConverter<JsonSchemaFormat>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        JsonSchemaFormat
    > _stringToEnum = new()
    {
        { "date-time", JsonSchemaFormat.DateTime },
        { "time", JsonSchemaFormat.Time },
        { "date", JsonSchemaFormat.Date },
        { "duration", JsonSchemaFormat.Duration },
        { "email", JsonSchemaFormat.Email },
        { "hostname", JsonSchemaFormat.Hostname },
        { "ipv4", JsonSchemaFormat.Ipv4 },
        { "ipv6", JsonSchemaFormat.Ipv6 },
        { "uuid", JsonSchemaFormat.Uuid },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        JsonSchemaFormat,
        string
    > _enumToString = new()
    {
        { JsonSchemaFormat.DateTime, "date-time" },
        { JsonSchemaFormat.Time, "time" },
        { JsonSchemaFormat.Date, "date" },
        { JsonSchemaFormat.Duration, "duration" },
        { JsonSchemaFormat.Email, "email" },
        { JsonSchemaFormat.Hostname, "hostname" },
        { JsonSchemaFormat.Ipv4, "ipv4" },
        { JsonSchemaFormat.Ipv6, "ipv6" },
        { JsonSchemaFormat.Uuid, "uuid" },
    };

    public override JsonSchemaFormat Read(
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
        JsonSchemaFormat value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override JsonSchemaFormat ReadAsPropertyName(
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
        JsonSchemaFormat value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
