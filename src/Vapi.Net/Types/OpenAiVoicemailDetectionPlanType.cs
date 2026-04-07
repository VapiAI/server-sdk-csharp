using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(OpenAiVoicemailDetectionPlanTypeSerializer))]
public enum OpenAiVoicemailDetectionPlanType
{
    [EnumMember(Value = "audio")]
    Audio,

    [EnumMember(Value = "transcript")]
    Transcript,
}

internal class OpenAiVoicemailDetectionPlanTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<OpenAiVoicemailDetectionPlanType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        OpenAiVoicemailDetectionPlanType
    > _stringToEnum = new()
    {
        { "audio", OpenAiVoicemailDetectionPlanType.Audio },
        { "transcript", OpenAiVoicemailDetectionPlanType.Transcript },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        OpenAiVoicemailDetectionPlanType,
        string
    > _enumToString = new()
    {
        { OpenAiVoicemailDetectionPlanType.Audio, "audio" },
        { OpenAiVoicemailDetectionPlanType.Transcript, "transcript" },
    };

    public override OpenAiVoicemailDetectionPlanType Read(
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
        OpenAiVoicemailDetectionPlanType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override OpenAiVoicemailDetectionPlanType ReadAsPropertyName(
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
        OpenAiVoicemailDetectionPlanType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
