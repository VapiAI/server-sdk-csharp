using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(OpenAiVoicemailDetectionPlanProviderSerializer))]
public enum OpenAiVoicemailDetectionPlanProvider
{
    [EnumMember(Value = "openai")]
    Openai,
}

internal class OpenAiVoicemailDetectionPlanProviderSerializer
    : global::System.Text.Json.Serialization.JsonConverter<OpenAiVoicemailDetectionPlanProvider>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        OpenAiVoicemailDetectionPlanProvider
    > _stringToEnum = new() { { "openai", OpenAiVoicemailDetectionPlanProvider.Openai } };

    private static readonly global::System.Collections.Generic.Dictionary<
        OpenAiVoicemailDetectionPlanProvider,
        string
    > _enumToString = new() { { OpenAiVoicemailDetectionPlanProvider.Openai, "openai" } };

    public override OpenAiVoicemailDetectionPlanProvider Read(
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
        OpenAiVoicemailDetectionPlanProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override OpenAiVoicemailDetectionPlanProvider ReadAsPropertyName(
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
        OpenAiVoicemailDetectionPlanProvider value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
