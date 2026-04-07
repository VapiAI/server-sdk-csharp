using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(ArtifactPlanRecordingFormatSerializer))]
public enum ArtifactPlanRecordingFormat
{
    [EnumMember(Value = "wav;l16")]
    WavL16,

    [EnumMember(Value = "mp3")]
    Mp3,
}

internal class ArtifactPlanRecordingFormatSerializer
    : global::System.Text.Json.Serialization.JsonConverter<ArtifactPlanRecordingFormat>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        ArtifactPlanRecordingFormat
    > _stringToEnum = new()
    {
        { "wav;l16", ArtifactPlanRecordingFormat.WavL16 },
        { "mp3", ArtifactPlanRecordingFormat.Mp3 },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        ArtifactPlanRecordingFormat,
        string
    > _enumToString = new()
    {
        { ArtifactPlanRecordingFormat.WavL16, "wav;l16" },
        { ArtifactPlanRecordingFormat.Mp3, "mp3" },
    };

    public override ArtifactPlanRecordingFormat Read(
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
        ArtifactPlanRecordingFormat value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override ArtifactPlanRecordingFormat ReadAsPropertyName(
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
        ArtifactPlanRecordingFormat value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
