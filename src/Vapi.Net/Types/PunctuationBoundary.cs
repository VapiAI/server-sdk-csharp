using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(PunctuationBoundarySerializer))]
public enum PunctuationBoundary
{
    [EnumMember(Value = "。")]
    Circle,

    [EnumMember(Value = "，")]
    FullWidthComma,

    [EnumMember(Value = ".")]
    Dot,

    [EnumMember(Value = "!")]
    Exclamation,

    [EnumMember(Value = "?")]
    Question,

    [EnumMember(Value = ";")]
    Semicolon,

    [EnumMember(Value = ")")]
    Parenthesis,

    [EnumMember(Value = "،")]
    ArabicComma,

    [EnumMember(Value = "۔")]
    UrduFullStop,

    [EnumMember(Value = "।")]
    BengaliFullStop,

    [EnumMember(Value = "॥")]
    DoubleDanda,

    [EnumMember(Value = "|")]
    Pipe,

    [EnumMember(Value = "||")]
    DoublePipe,

    [EnumMember(Value = ",")]
    HalfWidthComma,

    [EnumMember(Value = ":")]
    Colon,
}

internal class PunctuationBoundarySerializer
    : global::System.Text.Json.Serialization.JsonConverter<PunctuationBoundary>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        PunctuationBoundary
    > _stringToEnum = new()
    {
        { "。", PunctuationBoundary.Circle },
        { "，", PunctuationBoundary.FullWidthComma },
        { ".", PunctuationBoundary.Dot },
        { "!", PunctuationBoundary.Exclamation },
        { "?", PunctuationBoundary.Question },
        { ";", PunctuationBoundary.Semicolon },
        { ")", PunctuationBoundary.Parenthesis },
        { "،", PunctuationBoundary.ArabicComma },
        { "۔", PunctuationBoundary.UrduFullStop },
        { "।", PunctuationBoundary.BengaliFullStop },
        { "॥", PunctuationBoundary.DoubleDanda },
        { "|", PunctuationBoundary.Pipe },
        { "||", PunctuationBoundary.DoublePipe },
        { ",", PunctuationBoundary.HalfWidthComma },
        { ":", PunctuationBoundary.Colon },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        PunctuationBoundary,
        string
    > _enumToString = new()
    {
        { PunctuationBoundary.Circle, "。" },
        { PunctuationBoundary.FullWidthComma, "，" },
        { PunctuationBoundary.Dot, "." },
        { PunctuationBoundary.Exclamation, "!" },
        { PunctuationBoundary.Question, "?" },
        { PunctuationBoundary.Semicolon, ";" },
        { PunctuationBoundary.Parenthesis, ")" },
        { PunctuationBoundary.ArabicComma, "،" },
        { PunctuationBoundary.UrduFullStop, "۔" },
        { PunctuationBoundary.BengaliFullStop, "।" },
        { PunctuationBoundary.DoubleDanda, "॥" },
        { PunctuationBoundary.Pipe, "|" },
        { PunctuationBoundary.DoublePipe, "||" },
        { PunctuationBoundary.HalfWidthComma, "," },
        { PunctuationBoundary.Colon, ":" },
    };

    public override PunctuationBoundary Read(
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
        PunctuationBoundary value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override PunctuationBoundary ReadAsPropertyName(
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
        PunctuationBoundary value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
