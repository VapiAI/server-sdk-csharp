using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(PhoneNumberCallEndingHookFilterKeySerializer))]
public enum PhoneNumberCallEndingHookFilterKey
{
    [EnumMember(Value = "call.endedReason")]
    CallEndedReason,
}

internal class PhoneNumberCallEndingHookFilterKeySerializer
    : global::System.Text.Json.Serialization.JsonConverter<PhoneNumberCallEndingHookFilterKey>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PhoneNumberCallEndingHookFilterKey
    > _stringToEnum = new()
    {
        { "call.endedReason", PhoneNumberCallEndingHookFilterKey.CallEndedReason },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        PhoneNumberCallEndingHookFilterKey,
        string
    > _enumToString = new()
    {
        { PhoneNumberCallEndingHookFilterKey.CallEndedReason, "call.endedReason" },
    };

    public override PhoneNumberCallEndingHookFilterKey Read(
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
        PhoneNumberCallEndingHookFilterKey value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PhoneNumberCallEndingHookFilterKey ReadAsPropertyName(
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
        PhoneNumberCallEndingHookFilterKey value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
