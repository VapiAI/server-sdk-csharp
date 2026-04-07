using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CallPhoneCallProviderSerializer))]
public enum CallPhoneCallProvider
{
    [EnumMember(Value = "twilio")]
    Twilio,

    [EnumMember(Value = "vonage")]
    Vonage,

    [EnumMember(Value = "vapi")]
    Vapi,

    [EnumMember(Value = "telnyx")]
    Telnyx,
}

internal class CallPhoneCallProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CallPhoneCallProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CallPhoneCallProvider
    > _stringToEnum = new()
    {
        { "twilio", CallPhoneCallProvider.Twilio },
        { "vonage", CallPhoneCallProvider.Vonage },
        { "vapi", CallPhoneCallProvider.Vapi },
        { "telnyx", CallPhoneCallProvider.Telnyx },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CallPhoneCallProvider,
        string
    > _enumToString = new()
    {
        { CallPhoneCallProvider.Twilio, "twilio" },
        { CallPhoneCallProvider.Vonage, "vonage" },
        { CallPhoneCallProvider.Vapi, "vapi" },
        { CallPhoneCallProvider.Telnyx, "telnyx" },
    };

    public override CallPhoneCallProvider Read(
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
        CallPhoneCallProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CallPhoneCallProvider ReadAsPropertyName(
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
        CallPhoneCallProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
