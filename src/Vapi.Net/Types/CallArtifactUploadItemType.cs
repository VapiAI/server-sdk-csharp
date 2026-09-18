using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(CallArtifactUploadItemTypeSerializer))]
public enum CallArtifactUploadItemType
{
    [EnumMember(Value = "end-of-call-report")]
    EndOfCallReport,

    [EnumMember(Value = "recording-mono")]
    RecordingMono,

    [EnumMember(Value = "recording-stereo")]
    RecordingStereo,

    [EnumMember(Value = "recording-assistant")]
    RecordingAssistant,

    [EnumMember(Value = "recording-customer")]
    RecordingCustomer,

    [EnumMember(Value = "log")]
    Log,

    [EnumMember(Value = "pcap")]
    Pcap,
}

internal class CallArtifactUploadItemTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<CallArtifactUploadItemType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        CallArtifactUploadItemType
    > _stringToEnum = new()
    {
        { "end-of-call-report", CallArtifactUploadItemType.EndOfCallReport },
        { "recording-mono", CallArtifactUploadItemType.RecordingMono },
        { "recording-stereo", CallArtifactUploadItemType.RecordingStereo },
        { "recording-assistant", CallArtifactUploadItemType.RecordingAssistant },
        { "recording-customer", CallArtifactUploadItemType.RecordingCustomer },
        { "log", CallArtifactUploadItemType.Log },
        { "pcap", CallArtifactUploadItemType.Pcap },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        CallArtifactUploadItemType,
        string
    > _enumToString = new()
    {
        { CallArtifactUploadItemType.EndOfCallReport, "end-of-call-report" },
        { CallArtifactUploadItemType.RecordingMono, "recording-mono" },
        { CallArtifactUploadItemType.RecordingStereo, "recording-stereo" },
        { CallArtifactUploadItemType.RecordingAssistant, "recording-assistant" },
        { CallArtifactUploadItemType.RecordingCustomer, "recording-customer" },
        { CallArtifactUploadItemType.Log, "log" },
        { CallArtifactUploadItemType.Pcap, "pcap" },
    };

    public override CallArtifactUploadItemType Read(
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
        CallArtifactUploadItemType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override CallArtifactUploadItemType ReadAsPropertyName(
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
        CallArtifactUploadItemType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
