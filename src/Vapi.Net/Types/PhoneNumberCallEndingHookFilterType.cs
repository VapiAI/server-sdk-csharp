using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(PhoneNumberCallEndingHookFilterTypeSerializer))]
public enum PhoneNumberCallEndingHookFilterType
{
    [EnumMember(Value = "oneOf")]
    OneOf,
}

internal class PhoneNumberCallEndingHookFilterTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<PhoneNumberCallEndingHookFilterType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PhoneNumberCallEndingHookFilterType
    > _stringToEnum = new() { { "oneOf", PhoneNumberCallEndingHookFilterType.OneOf } };

    private static readonly global::System.Collections.Generic.Dictionary<
        PhoneNumberCallEndingHookFilterType,
        string
    > _enumToString = new() { { PhoneNumberCallEndingHookFilterType.OneOf, "oneOf" } };

    public override PhoneNumberCallEndingHookFilterType Read(
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
        PhoneNumberCallEndingHookFilterType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PhoneNumberCallEndingHookFilterType ReadAsPropertyName(
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
        PhoneNumberCallEndingHookFilterType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
