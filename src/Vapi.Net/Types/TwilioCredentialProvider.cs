using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TwilioCredentialProviderSerializer))]
public enum TwilioCredentialProvider
{
    [EnumMember(Value = "twilio")]
    Twilio,
}

internal class TwilioCredentialProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TwilioCredentialProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TwilioCredentialProvider
    > _stringToEnum = new() { { "twilio", TwilioCredentialProvider.Twilio } };

    private static readonly global::System.Collections.Generic.Dictionary<
        TwilioCredentialProvider,
        string
    > _enumToString = new() { { TwilioCredentialProvider.Twilio, "twilio" } };

    public override TwilioCredentialProvider Read(
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
        TwilioCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TwilioCredentialProvider ReadAsPropertyName(
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
        TwilioCredentialProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
