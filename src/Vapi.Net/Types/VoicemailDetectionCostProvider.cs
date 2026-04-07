using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(VoicemailDetectionCostProviderSerializer))]
public enum VoicemailDetectionCostProvider
{
    [EnumMember(Value = "twilio")]
    Twilio,

    [EnumMember(Value = "google")]
    Google,

    [EnumMember(Value = "openai")]
    Openai,

    [EnumMember(Value = "vapi")]
    Vapi,
}

internal class VoicemailDetectionCostProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VoicemailDetectionCostProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VoicemailDetectionCostProvider
    > _stringToEnum = new()
    {
        { "twilio", VoicemailDetectionCostProvider.Twilio },
        { "google", VoicemailDetectionCostProvider.Google },
        { "openai", VoicemailDetectionCostProvider.Openai },
        { "vapi", VoicemailDetectionCostProvider.Vapi },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VoicemailDetectionCostProvider,
        string
    > _enumToString = new()
    {
        { VoicemailDetectionCostProvider.Twilio, "twilio" },
        { VoicemailDetectionCostProvider.Google, "google" },
        { VoicemailDetectionCostProvider.Openai, "openai" },
        { VoicemailDetectionCostProvider.Vapi, "vapi" },
    };

    public override VoicemailDetectionCostProvider Read(
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
        VoicemailDetectionCostProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VoicemailDetectionCostProvider ReadAsPropertyName(
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
        VoicemailDetectionCostProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
