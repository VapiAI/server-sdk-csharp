using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GoogleVoicemailDetectionPlanProviderSerializer))]
public enum GoogleVoicemailDetectionPlanProvider
{
    [EnumMember(Value = "google")]
    Google,
}

internal class GoogleVoicemailDetectionPlanProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GoogleVoicemailDetectionPlanProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GoogleVoicemailDetectionPlanProvider
    > _stringToEnum = new() { { "google", GoogleVoicemailDetectionPlanProvider.Google } };

    private static readonly global::System.Collections.Generic.Dictionary<
        GoogleVoicemailDetectionPlanProvider,
        string
    > _enumToString = new() { { GoogleVoicemailDetectionPlanProvider.Google, "google" } };

    public override GoogleVoicemailDetectionPlanProvider Read(
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
        GoogleVoicemailDetectionPlanProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GoogleVoicemailDetectionPlanProvider ReadAsPropertyName(
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
        GoogleVoicemailDetectionPlanProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
