using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(RegexSecurityFilterTypeSerializer))]
public enum RegexSecurityFilterType
{
    [EnumMember(Value = "regex")]
    Regex,
}

internal class RegexSecurityFilterTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<RegexSecurityFilterType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        RegexSecurityFilterType
    > _stringToEnum = new() { { "regex", RegexSecurityFilterType.Regex } };

    private static readonly global::System.Collections.Generic.Dictionary<
        RegexSecurityFilterType,
        string
    > _enumToString = new() { { RegexSecurityFilterType.Regex, "regex" } };

    public override RegexSecurityFilterType Read(
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
        RegexSecurityFilterType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override RegexSecurityFilterType ReadAsPropertyName(
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
        RegexSecurityFilterType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
