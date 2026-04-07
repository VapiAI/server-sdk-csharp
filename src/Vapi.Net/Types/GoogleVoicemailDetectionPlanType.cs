using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(GoogleVoicemailDetectionPlanTypeSerializer))]
public enum GoogleVoicemailDetectionPlanType
{
    [EnumMember(Value = "audio")]
    Audio,

    [EnumMember(Value = "transcript")]
    Transcript,
}

internal class GoogleVoicemailDetectionPlanTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<GoogleVoicemailDetectionPlanType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        GoogleVoicemailDetectionPlanType
    > _stringToEnum = new()
    {
        { "audio", GoogleVoicemailDetectionPlanType.Audio },
        { "transcript", GoogleVoicemailDetectionPlanType.Transcript },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        GoogleVoicemailDetectionPlanType,
        string
    > _enumToString = new()
    {
        { GoogleVoicemailDetectionPlanType.Audio, "audio" },
        { GoogleVoicemailDetectionPlanType.Transcript, "transcript" },
    };

    public override GoogleVoicemailDetectionPlanType Read(
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
        GoogleVoicemailDetectionPlanType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override GoogleVoicemailDetectionPlanType ReadAsPropertyName(
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
        GoogleVoicemailDetectionPlanType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
