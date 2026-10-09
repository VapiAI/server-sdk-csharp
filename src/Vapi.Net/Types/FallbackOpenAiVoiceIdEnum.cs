using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackOpenAiVoiceIdEnumSerializer))]
public enum FallbackOpenAiVoiceIdEnum
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

internal class FallbackOpenAiVoiceIdEnumSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackOpenAiVoiceIdEnum>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackOpenAiVoiceIdEnum
    > _stringToEnum = new()
    {
        { "alloy", FallbackOpenAiVoiceIdEnum.Alloy },
        { "echo", FallbackOpenAiVoiceIdEnum.Echo },
        { "fable", FallbackOpenAiVoiceIdEnum.Fable },
        { "onyx", FallbackOpenAiVoiceIdEnum.Onyx },
        { "nova", FallbackOpenAiVoiceIdEnum.Nova },
        { "shimmer", FallbackOpenAiVoiceIdEnum.Shimmer },
        { "marin", FallbackOpenAiVoiceIdEnum.Marin },
        { "cedar", FallbackOpenAiVoiceIdEnum.Cedar },
        { "ash", FallbackOpenAiVoiceIdEnum.Ash },
        { "ballad", FallbackOpenAiVoiceIdEnum.Ballad },
        { "beacon", FallbackOpenAiVoiceIdEnum.Beacon },
        { "bossa", FallbackOpenAiVoiceIdEnum.Bossa },
        { "cinder", FallbackOpenAiVoiceIdEnum.Cinder },
        { "coral", FallbackOpenAiVoiceIdEnum.Coral },
        { "delta", FallbackOpenAiVoiceIdEnum.Delta },
        { "gleam", FallbackOpenAiVoiceIdEnum.Gleam },
        { "meridian", FallbackOpenAiVoiceIdEnum.Meridian },
        { "quartz", FallbackOpenAiVoiceIdEnum.Quartz },
        { "ripple", FallbackOpenAiVoiceIdEnum.Ripple },
        { "sage", FallbackOpenAiVoiceIdEnum.Sage },
        { "stone", FallbackOpenAiVoiceIdEnum.Stone },
        { "tempo", FallbackOpenAiVoiceIdEnum.Tempo },
        { "verse", FallbackOpenAiVoiceIdEnum.Verse },
        { "vesper", FallbackOpenAiVoiceIdEnum.Vesper },
        { "willow", FallbackOpenAiVoiceIdEnum.Willow },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackOpenAiVoiceIdEnum,
        string
    > _enumToString = new()
    {
        { FallbackOpenAiVoiceIdEnum.Alloy, "alloy" },
        { FallbackOpenAiVoiceIdEnum.Echo, "echo" },
        { FallbackOpenAiVoiceIdEnum.Fable, "fable" },
        { FallbackOpenAiVoiceIdEnum.Onyx, "onyx" },
        { FallbackOpenAiVoiceIdEnum.Nova, "nova" },
        { FallbackOpenAiVoiceIdEnum.Shimmer, "shimmer" },
        { FallbackOpenAiVoiceIdEnum.Marin, "marin" },
        { FallbackOpenAiVoiceIdEnum.Cedar, "cedar" },
        { FallbackOpenAiVoiceIdEnum.Ash, "ash" },
        { FallbackOpenAiVoiceIdEnum.Ballad, "ballad" },
        { FallbackOpenAiVoiceIdEnum.Beacon, "beacon" },
        { FallbackOpenAiVoiceIdEnum.Bossa, "bossa" },
        { FallbackOpenAiVoiceIdEnum.Cinder, "cinder" },
        { FallbackOpenAiVoiceIdEnum.Coral, "coral" },
        { FallbackOpenAiVoiceIdEnum.Delta, "delta" },
        { FallbackOpenAiVoiceIdEnum.Gleam, "gleam" },
        { FallbackOpenAiVoiceIdEnum.Meridian, "meridian" },
        { FallbackOpenAiVoiceIdEnum.Quartz, "quartz" },
        { FallbackOpenAiVoiceIdEnum.Ripple, "ripple" },
        { FallbackOpenAiVoiceIdEnum.Sage, "sage" },
        { FallbackOpenAiVoiceIdEnum.Stone, "stone" },
        { FallbackOpenAiVoiceIdEnum.Tempo, "tempo" },
        { FallbackOpenAiVoiceIdEnum.Verse, "verse" },
        { FallbackOpenAiVoiceIdEnum.Vesper, "vesper" },
        { FallbackOpenAiVoiceIdEnum.Willow, "willow" },
    };

    public override FallbackOpenAiVoiceIdEnum Read(
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
        FallbackOpenAiVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackOpenAiVoiceIdEnum ReadAsPropertyName(
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
        FallbackOpenAiVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
