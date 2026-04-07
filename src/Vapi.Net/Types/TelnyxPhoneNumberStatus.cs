using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TelnyxPhoneNumberStatusSerializer))]
public enum TelnyxPhoneNumberStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "activating")]
    Activating,

    [EnumMember(Value = "blocked")]
    Blocked,
}

internal class TelnyxPhoneNumberStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TelnyxPhoneNumberStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TelnyxPhoneNumberStatus
    > _stringToEnum = new()
    {
        { "active", TelnyxPhoneNumberStatus.Active },
        { "activating", TelnyxPhoneNumberStatus.Activating },
        { "blocked", TelnyxPhoneNumberStatus.Blocked },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TelnyxPhoneNumberStatus,
        string
    > _enumToString = new()
    {
        { TelnyxPhoneNumberStatus.Active, "active" },
        { TelnyxPhoneNumberStatus.Activating, "activating" },
        { TelnyxPhoneNumberStatus.Blocked, "blocked" },
    };

    public override TelnyxPhoneNumberStatus Read(
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
        TelnyxPhoneNumberStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TelnyxPhoneNumberStatus ReadAsPropertyName(
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
        TelnyxPhoneNumberStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
