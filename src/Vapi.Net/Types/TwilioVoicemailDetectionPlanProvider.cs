using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TwilioVoicemailDetectionPlanProviderSerializer))]
public enum TwilioVoicemailDetectionPlanProvider
{
    [EnumMember(Value = "twilio")]
    Twilio,
}

internal class TwilioVoicemailDetectionPlanProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TwilioVoicemailDetectionPlanProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TwilioVoicemailDetectionPlanProvider
    > _stringToEnum = new() { { "twilio", TwilioVoicemailDetectionPlanProvider.Twilio } };

    private static readonly global::System.Collections.Generic.Dictionary<
        TwilioVoicemailDetectionPlanProvider,
        string
    > _enumToString = new() { { TwilioVoicemailDetectionPlanProvider.Twilio, "twilio" } };

    public override TwilioVoicemailDetectionPlanProvider Read(
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
        TwilioVoicemailDetectionPlanProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TwilioVoicemailDetectionPlanProvider ReadAsPropertyName(
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
        TwilioVoicemailDetectionPlanProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
