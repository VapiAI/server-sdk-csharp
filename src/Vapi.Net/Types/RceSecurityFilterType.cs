using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(RceSecurityFilterTypeSerializer))]
public enum RceSecurityFilterType
{
    [EnumMember(Value = "rce")]
    Rce,
}

internal class RceSecurityFilterTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<RceSecurityFilterType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        RceSecurityFilterType
    > _stringToEnum = new() { { "rce", RceSecurityFilterType.Rce } };

    private static readonly global::System.Collections.Generic.Dictionary<
        RceSecurityFilterType,
        string
    > _enumToString = new() { { RceSecurityFilterType.Rce, "rce" } };

    public override RceSecurityFilterType Read(
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
        RceSecurityFilterType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override RceSecurityFilterType ReadAsPropertyName(
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
        RceSecurityFilterType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
