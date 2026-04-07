using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TransportConfigurationTwilioProviderSerializer))]
public enum TransportConfigurationTwilioProvider
{
    [EnumMember(Value = "twilio")]
    Twilio,
}

internal class TransportConfigurationTwilioProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TransportConfigurationTwilioProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TransportConfigurationTwilioProvider
    > _stringToEnum = new() { { "twilio", TransportConfigurationTwilioProvider.Twilio } };

    private static readonly global::System.Collections.Generic.Dictionary<
        TransportConfigurationTwilioProvider,
        string
    > _enumToString = new() { { TransportConfigurationTwilioProvider.Twilio, "twilio" } };

    public override TransportConfigurationTwilioProvider Read(
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
        TransportConfigurationTwilioProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TransportConfigurationTwilioProvider ReadAsPropertyName(
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
        TransportConfigurationTwilioProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
