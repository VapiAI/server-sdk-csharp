using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TwilioPhoneNumberStatusSerializer))]
public enum TwilioPhoneNumberStatus
{
    [EnumMember(Value = "active")]
    Active,

    [EnumMember(Value = "activating")]
    Activating,

    [EnumMember(Value = "blocked")]
    Blocked,
}

internal class TwilioPhoneNumberStatusSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TwilioPhoneNumberStatus>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TwilioPhoneNumberStatus
    > _stringToEnum = new()
    {
        { "active", TwilioPhoneNumberStatus.Active },
        { "activating", TwilioPhoneNumberStatus.Activating },
        { "blocked", TwilioPhoneNumberStatus.Blocked },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TwilioPhoneNumberStatus,
        string
    > _enumToString = new()
    {
        { TwilioPhoneNumberStatus.Active, "active" },
        { TwilioPhoneNumberStatus.Activating, "activating" },
        { TwilioPhoneNumberStatus.Blocked, "blocked" },
    };

    public override TwilioPhoneNumberStatus Read(
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
        TwilioPhoneNumberStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TwilioPhoneNumberStatus ReadAsPropertyName(
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
        TwilioPhoneNumberStatus value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
