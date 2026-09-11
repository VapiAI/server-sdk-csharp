using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(RecordingConsentTypeSerializer))]
public enum RecordingConsentType
{
    [EnumMember(Value = "stay-on-line")]
    StayOnLine,

    [EnumMember(Value = "verbal")]
    Verbal,
}

internal class RecordingConsentTypeSerializer
    : global::System.Text.Json.Serialization.JsonConverter<RecordingConsentType>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        RecordingConsentType
    > _stringToEnum = new()
    {
        { "stay-on-line", RecordingConsentType.StayOnLine },
        { "verbal", RecordingConsentType.Verbal },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        RecordingConsentType,
        string
    > _enumToString = new()
    {
        { RecordingConsentType.StayOnLine, "stay-on-line" },
        { RecordingConsentType.Verbal, "verbal" },
    };

    public override RecordingConsentType Read(
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
        RecordingConsentType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override RecordingConsentType ReadAsPropertyName(
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
        RecordingConsentType value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
