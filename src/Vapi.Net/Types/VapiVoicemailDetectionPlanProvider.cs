using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(VapiVoicemailDetectionPlanProviderSerializer))]
public enum VapiVoicemailDetectionPlanProvider
{
    [EnumMember(Value = "vapi")]
    Vapi,
}

internal class VapiVoicemailDetectionPlanProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VapiVoicemailDetectionPlanProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VapiVoicemailDetectionPlanProvider
    > _stringToEnum = new() { { "vapi", VapiVoicemailDetectionPlanProvider.Vapi } };

    private static readonly global::System.Collections.Generic.Dictionary<
        VapiVoicemailDetectionPlanProvider,
        string
    > _enumToString = new() { { VapiVoicemailDetectionPlanProvider.Vapi, "vapi" } };

    public override VapiVoicemailDetectionPlanProvider Read(
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
        VapiVoicemailDetectionPlanProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VapiVoicemailDetectionPlanProvider ReadAsPropertyName(
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
        VapiVoicemailDetectionPlanProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
