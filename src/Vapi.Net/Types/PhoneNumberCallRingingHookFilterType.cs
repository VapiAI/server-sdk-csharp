using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(PhoneNumberCallRingingHookFilterTypeSerializer))]
public enum PhoneNumberCallRingingHookFilterType
{
    [EnumMember(Value = "startsWith")]
    StartsWith,
}

internal class PhoneNumberCallRingingHookFilterTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<PhoneNumberCallRingingHookFilterType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PhoneNumberCallRingingHookFilterType
    > _stringToEnum = new() { { "startsWith", PhoneNumberCallRingingHookFilterType.StartsWith } };

    private static readonly global::System.Collections.Generic.Dictionary<
        PhoneNumberCallRingingHookFilterType,
        string
    > _enumToString = new() { { PhoneNumberCallRingingHookFilterType.StartsWith, "startsWith" } };

    public override PhoneNumberCallRingingHookFilterType Read(
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
        PhoneNumberCallRingingHookFilterType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PhoneNumberCallRingingHookFilterType ReadAsPropertyName(
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
        PhoneNumberCallRingingHookFilterType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
