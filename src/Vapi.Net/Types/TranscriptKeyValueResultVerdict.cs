using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(TranscriptKeyValueResultVerdictSerializer))]
public enum TranscriptKeyValueResultVerdict
{
    [EnumMember(Value = "exact")]
    Exact,

    [EnumMember(Value = "near")]
    Near,

    [EnumMember(Value = "missed")]
    Missed,
}

internal class TranscriptKeyValueResultVerdictSerializer
    : global::System.Text.Json.Serialization.JsonConverter<TranscriptKeyValueResultVerdict>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        TranscriptKeyValueResultVerdict
    > _stringToEnum = new()
    {
        { "exact", TranscriptKeyValueResultVerdict.Exact },
        { "near", TranscriptKeyValueResultVerdict.Near },
        { "missed", TranscriptKeyValueResultVerdict.Missed },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        TranscriptKeyValueResultVerdict,
        string
    > _enumToString = new()
    {
        { TranscriptKeyValueResultVerdict.Exact, "exact" },
        { TranscriptKeyValueResultVerdict.Near, "near" },
        { TranscriptKeyValueResultVerdict.Missed, "missed" },
    };

    public override TranscriptKeyValueResultVerdict Read(
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
        TranscriptKeyValueResultVerdict value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override TranscriptKeyValueResultVerdict ReadAsPropertyName(
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
        TranscriptKeyValueResultVerdict value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
