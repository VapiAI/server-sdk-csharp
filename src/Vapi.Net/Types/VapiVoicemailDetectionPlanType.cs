using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(VapiVoicemailDetectionPlanTypeSerializer))]
public enum VapiVoicemailDetectionPlanType
{
    [EnumMember(Value = "audio")]
    Audio,

    [EnumMember(Value = "transcript")]
    Transcript,
}

internal class VapiVoicemailDetectionPlanTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<VapiVoicemailDetectionPlanType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        VapiVoicemailDetectionPlanType
    > _stringToEnum = new()
    {
        { "audio", VapiVoicemailDetectionPlanType.Audio },
        { "transcript", VapiVoicemailDetectionPlanType.Transcript },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        VapiVoicemailDetectionPlanType,
        string
    > _enumToString = new()
    {
        { VapiVoicemailDetectionPlanType.Audio, "audio" },
        { VapiVoicemailDetectionPlanType.Transcript, "transcript" },
    };

    public override VapiVoicemailDetectionPlanType Read(
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
        VapiVoicemailDetectionPlanType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override VapiVoicemailDetectionPlanType ReadAsPropertyName(
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
        VapiVoicemailDetectionPlanType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
