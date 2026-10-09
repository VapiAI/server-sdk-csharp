using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(OpenAiVoiceIdEnumSerializer))]
public enum OpenAiVoiceIdEnum
{
    [EnumMember(Value = "alloy")]
    Alloy,

    [EnumMember(Value = "echo")]
    Echo,

    [EnumMember(Value = "fable")]
    Fable,

    [EnumMember(Value = "onyx")]
    Onyx,

    [EnumMember(Value = "nova")]
    Nova,

    [EnumMember(Value = "shimmer")]
    Shimmer,

    [EnumMember(Value = "marin")]
    Marin,

    [EnumMember(Value = "cedar")]
    Cedar,

    [EnumMember(Value = "ash")]
    Ash,

    [EnumMember(Value = "ballad")]
    Ballad,

    [EnumMember(Value = "beacon")]
    Beacon,

    [EnumMember(Value = "bossa")]
    Bossa,

    [EnumMember(Value = "cinder")]
    Cinder,

    [EnumMember(Value = "coral")]
    Coral,

    [EnumMember(Value = "delta")]
    Delta,

    [EnumMember(Value = "gleam")]
    Gleam,

    [EnumMember(Value = "meridian")]
    Meridian,

    [EnumMember(Value = "quartz")]
    Quartz,

    [EnumMember(Value = "ripple")]
    Ripple,

    [EnumMember(Value = "sage")]
    Sage,

    [EnumMember(Value = "stone")]
    Stone,

    [EnumMember(Value = "tempo")]
    Tempo,

    [EnumMember(Value = "verse")]
    Verse,

    [EnumMember(Value = "vesper")]
    Vesper,

    [EnumMember(Value = "willow")]
    Willow,
}

internal class OpenAiVoiceIdEnumSerializer
    : global::System.Text.Json.Serialization.JsonConverter<OpenAiVoiceIdEnum>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        OpenAiVoiceIdEnum
    > _stringToEnum = new()
    {
        { "alloy", OpenAiVoiceIdEnum.Alloy },
        { "echo", OpenAiVoiceIdEnum.Echo },
        { "fable", OpenAiVoiceIdEnum.Fable },
        { "onyx", OpenAiVoiceIdEnum.Onyx },
        { "nova", OpenAiVoiceIdEnum.Nova },
        { "shimmer", OpenAiVoiceIdEnum.Shimmer },
        { "marin", OpenAiVoiceIdEnum.Marin },
        { "cedar", OpenAiVoiceIdEnum.Cedar },
        { "ash", OpenAiVoiceIdEnum.Ash },
        { "ballad", OpenAiVoiceIdEnum.Ballad },
        { "beacon", OpenAiVoiceIdEnum.Beacon },
        { "bossa", OpenAiVoiceIdEnum.Bossa },
        { "cinder", OpenAiVoiceIdEnum.Cinder },
        { "coral", OpenAiVoiceIdEnum.Coral },
        { "delta", OpenAiVoiceIdEnum.Delta },
        { "gleam", OpenAiVoiceIdEnum.Gleam },
        { "meridian", OpenAiVoiceIdEnum.Meridian },
        { "quartz", OpenAiVoiceIdEnum.Quartz },
        { "ripple", OpenAiVoiceIdEnum.Ripple },
        { "sage", OpenAiVoiceIdEnum.Sage },
        { "stone", OpenAiVoiceIdEnum.Stone },
        { "tempo", OpenAiVoiceIdEnum.Tempo },
        { "verse", OpenAiVoiceIdEnum.Verse },
        { "vesper", OpenAiVoiceIdEnum.Vesper },
        { "willow", OpenAiVoiceIdEnum.Willow },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        OpenAiVoiceIdEnum,
        string
    > _enumToString = new()
    {
        { OpenAiVoiceIdEnum.Alloy, "alloy" },
        { OpenAiVoiceIdEnum.Echo, "echo" },
        { OpenAiVoiceIdEnum.Fable, "fable" },
        { OpenAiVoiceIdEnum.Onyx, "onyx" },
        { OpenAiVoiceIdEnum.Nova, "nova" },
        { OpenAiVoiceIdEnum.Shimmer, "shimmer" },
        { OpenAiVoiceIdEnum.Marin, "marin" },
        { OpenAiVoiceIdEnum.Cedar, "cedar" },
        { OpenAiVoiceIdEnum.Ash, "ash" },
        { OpenAiVoiceIdEnum.Ballad, "ballad" },
        { OpenAiVoiceIdEnum.Beacon, "beacon" },
        { OpenAiVoiceIdEnum.Bossa, "bossa" },
        { OpenAiVoiceIdEnum.Cinder, "cinder" },
        { OpenAiVoiceIdEnum.Coral, "coral" },
        { OpenAiVoiceIdEnum.Delta, "delta" },
        { OpenAiVoiceIdEnum.Gleam, "gleam" },
        { OpenAiVoiceIdEnum.Meridian, "meridian" },
        { OpenAiVoiceIdEnum.Quartz, "quartz" },
        { OpenAiVoiceIdEnum.Ripple, "ripple" },
        { OpenAiVoiceIdEnum.Sage, "sage" },
        { OpenAiVoiceIdEnum.Stone, "stone" },
        { OpenAiVoiceIdEnum.Tempo, "tempo" },
        { OpenAiVoiceIdEnum.Verse, "verse" },
        { OpenAiVoiceIdEnum.Vesper, "vesper" },
        { OpenAiVoiceIdEnum.Willow, "willow" },
    };

    public override OpenAiVoiceIdEnum Read(
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
        OpenAiVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override OpenAiVoiceIdEnum ReadAsPropertyName(
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
        OpenAiVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
