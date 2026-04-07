using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(SsrfSecurityFilterTypeSerializer))]
public enum SsrfSecurityFilterType
{
    [EnumMember(Value = "ssrf")]
    Ssrf,
}

internal class SsrfSecurityFilterTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<SsrfSecurityFilterType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        SsrfSecurityFilterType
    > _stringToEnum = new() { { "ssrf", SsrfSecurityFilterType.Ssrf } };

    private static readonly global::System.Collections.Generic.Dictionary<
        SsrfSecurityFilterType,
        string
    > _enumToString = new() { { SsrfSecurityFilterType.Ssrf, "ssrf" } };

    public override SsrfSecurityFilterType Read(
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
        SsrfSecurityFilterType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override SsrfSecurityFilterType ReadAsPropertyName(
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
        SsrfSecurityFilterType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
