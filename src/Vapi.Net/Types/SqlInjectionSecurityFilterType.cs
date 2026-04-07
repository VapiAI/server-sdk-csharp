using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SqlInjectionSecurityFilterTypeSerializer))]
public enum SqlInjectionSecurityFilterType
{
    [EnumMember(Value = "sql-injection")]
    SqlInjection,
}

internal class SqlInjectionSecurityFilterTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SqlInjectionSecurityFilterType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SqlInjectionSecurityFilterType
    > _stringToEnum = new() { { "sql-injection", SqlInjectionSecurityFilterType.SqlInjection } };

    private static readonly global::System.Collections.Generic.Dictionary<
        SqlInjectionSecurityFilterType,
        string
    > _enumToString = new() { { SqlInjectionSecurityFilterType.SqlInjection, "sql-injection" } };

    public override SqlInjectionSecurityFilterType Read(
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
        SqlInjectionSecurityFilterType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SqlInjectionSecurityFilterType ReadAsPropertyName(
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
        SqlInjectionSecurityFilterType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
