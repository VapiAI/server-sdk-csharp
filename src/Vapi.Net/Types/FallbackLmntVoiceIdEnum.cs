using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(FallbackLmntVoiceIdEnumSerializer))]
public enum FallbackLmntVoiceIdEnum
{
    [EnumMember(Value = "amy")]
    Amy,

    [EnumMember(Value = "ansel")]
    Ansel,

    [EnumMember(Value = "autumn")]
    Autumn,

    [EnumMember(Value = "ava")]
    Ava,

    [EnumMember(Value = "brandon")]
    Brandon,

    [EnumMember(Value = "caleb")]
    Caleb,

    [EnumMember(Value = "cassian")]
    Cassian,

    [EnumMember(Value = "chloe")]
    Chloe,

    [EnumMember(Value = "dalton")]
    Dalton,

    [EnumMember(Value = "daniel")]
    Daniel,

    [EnumMember(Value = "dustin")]
    Dustin,

    [EnumMember(Value = "elowen")]
    Elowen,

    [EnumMember(Value = "evander")]
    Evander,

    [EnumMember(Value = "huxley")]
    Huxley,

    [EnumMember(Value = "james")]
    James,

    [EnumMember(Value = "juniper")]
    Juniper,

    [EnumMember(Value = "kennedy")]
    Kennedy,

    [EnumMember(Value = "lauren")]
    Lauren,

    [EnumMember(Value = "leah")]
    Leah,

    [EnumMember(Value = "lily")]
    Lily,

    [EnumMember(Value = "lucas")]
    Lucas,

    [EnumMember(Value = "magnus")]
    Magnus,

    [EnumMember(Value = "miles")]
    Miles,

    [EnumMember(Value = "morgan")]
    Morgan,

    [EnumMember(Value = "natalie")]
    Natalie,

    [EnumMember(Value = "nathan")]
    Nathan,

    [EnumMember(Value = "noah")]
    Noah,

    [EnumMember(Value = "nyssa")]
    Nyssa,

    [EnumMember(Value = "oliver")]
    Oliver,

    [EnumMember(Value = "paige")]
    Paige,

    [EnumMember(Value = "ryan")]
    Ryan,

    [EnumMember(Value = "sadie")]
    Sadie,

    [EnumMember(Value = "sophie")]
    Sophie,

    [EnumMember(Value = "stella")]
    Stella,

    [EnumMember(Value = "terrence")]
    Terrence,

    [EnumMember(Value = "tyler")]
    Tyler,

    [EnumMember(Value = "vesper")]
    Vesper,

    [EnumMember(Value = "violet")]
    Violet,

    [EnumMember(Value = "warrick")]
    Warrick,

    [EnumMember(Value = "zain")]
    Zain,

    [EnumMember(Value = "zeke")]
    Zeke,

    [EnumMember(Value = "zoe")]
    Zoe,
}

internal class FallbackLmntVoiceIdEnumSerializer
    : global::System.Text.Json.Serialization.JsonConverter<FallbackLmntVoiceIdEnum>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        FallbackLmntVoiceIdEnum
    > _stringToEnum = new()
    {
        { "amy", FallbackLmntVoiceIdEnum.Amy },
        { "ansel", FallbackLmntVoiceIdEnum.Ansel },
        { "autumn", FallbackLmntVoiceIdEnum.Autumn },
        { "ava", FallbackLmntVoiceIdEnum.Ava },
        { "brandon", FallbackLmntVoiceIdEnum.Brandon },
        { "caleb", FallbackLmntVoiceIdEnum.Caleb },
        { "cassian", FallbackLmntVoiceIdEnum.Cassian },
        { "chloe", FallbackLmntVoiceIdEnum.Chloe },
        { "dalton", FallbackLmntVoiceIdEnum.Dalton },
        { "daniel", FallbackLmntVoiceIdEnum.Daniel },
        { "dustin", FallbackLmntVoiceIdEnum.Dustin },
        { "elowen", FallbackLmntVoiceIdEnum.Elowen },
        { "evander", FallbackLmntVoiceIdEnum.Evander },
        { "huxley", FallbackLmntVoiceIdEnum.Huxley },
        { "james", FallbackLmntVoiceIdEnum.James },
        { "juniper", FallbackLmntVoiceIdEnum.Juniper },
        { "kennedy", FallbackLmntVoiceIdEnum.Kennedy },
        { "lauren", FallbackLmntVoiceIdEnum.Lauren },
        { "leah", FallbackLmntVoiceIdEnum.Leah },
        { "lily", FallbackLmntVoiceIdEnum.Lily },
        { "lucas", FallbackLmntVoiceIdEnum.Lucas },
        { "magnus", FallbackLmntVoiceIdEnum.Magnus },
        { "miles", FallbackLmntVoiceIdEnum.Miles },
        { "morgan", FallbackLmntVoiceIdEnum.Morgan },
        { "natalie", FallbackLmntVoiceIdEnum.Natalie },
        { "nathan", FallbackLmntVoiceIdEnum.Nathan },
        { "noah", FallbackLmntVoiceIdEnum.Noah },
        { "nyssa", FallbackLmntVoiceIdEnum.Nyssa },
        { "oliver", FallbackLmntVoiceIdEnum.Oliver },
        { "paige", FallbackLmntVoiceIdEnum.Paige },
        { "ryan", FallbackLmntVoiceIdEnum.Ryan },
        { "sadie", FallbackLmntVoiceIdEnum.Sadie },
        { "sophie", FallbackLmntVoiceIdEnum.Sophie },
        { "stella", FallbackLmntVoiceIdEnum.Stella },
        { "terrence", FallbackLmntVoiceIdEnum.Terrence },
        { "tyler", FallbackLmntVoiceIdEnum.Tyler },
        { "vesper", FallbackLmntVoiceIdEnum.Vesper },
        { "violet", FallbackLmntVoiceIdEnum.Violet },
        { "warrick", FallbackLmntVoiceIdEnum.Warrick },
        { "zain", FallbackLmntVoiceIdEnum.Zain },
        { "zeke", FallbackLmntVoiceIdEnum.Zeke },
        { "zoe", FallbackLmntVoiceIdEnum.Zoe },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        FallbackLmntVoiceIdEnum,
        string
    > _enumToString = new()
    {
        { FallbackLmntVoiceIdEnum.Amy, "amy" },
        { FallbackLmntVoiceIdEnum.Ansel, "ansel" },
        { FallbackLmntVoiceIdEnum.Autumn, "autumn" },
        { FallbackLmntVoiceIdEnum.Ava, "ava" },
        { FallbackLmntVoiceIdEnum.Brandon, "brandon" },
        { FallbackLmntVoiceIdEnum.Caleb, "caleb" },
        { FallbackLmntVoiceIdEnum.Cassian, "cassian" },
        { FallbackLmntVoiceIdEnum.Chloe, "chloe" },
        { FallbackLmntVoiceIdEnum.Dalton, "dalton" },
        { FallbackLmntVoiceIdEnum.Daniel, "daniel" },
        { FallbackLmntVoiceIdEnum.Dustin, "dustin" },
        { FallbackLmntVoiceIdEnum.Elowen, "elowen" },
        { FallbackLmntVoiceIdEnum.Evander, "evander" },
        { FallbackLmntVoiceIdEnum.Huxley, "huxley" },
        { FallbackLmntVoiceIdEnum.James, "james" },
        { FallbackLmntVoiceIdEnum.Juniper, "juniper" },
        { FallbackLmntVoiceIdEnum.Kennedy, "kennedy" },
        { FallbackLmntVoiceIdEnum.Lauren, "lauren" },
        { FallbackLmntVoiceIdEnum.Leah, "leah" },
        { FallbackLmntVoiceIdEnum.Lily, "lily" },
        { FallbackLmntVoiceIdEnum.Lucas, "lucas" },
        { FallbackLmntVoiceIdEnum.Magnus, "magnus" },
        { FallbackLmntVoiceIdEnum.Miles, "miles" },
        { FallbackLmntVoiceIdEnum.Morgan, "morgan" },
        { FallbackLmntVoiceIdEnum.Natalie, "natalie" },
        { FallbackLmntVoiceIdEnum.Nathan, "nathan" },
        { FallbackLmntVoiceIdEnum.Noah, "noah" },
        { FallbackLmntVoiceIdEnum.Nyssa, "nyssa" },
        { FallbackLmntVoiceIdEnum.Oliver, "oliver" },
        { FallbackLmntVoiceIdEnum.Paige, "paige" },
        { FallbackLmntVoiceIdEnum.Ryan, "ryan" },
        { FallbackLmntVoiceIdEnum.Sadie, "sadie" },
        { FallbackLmntVoiceIdEnum.Sophie, "sophie" },
        { FallbackLmntVoiceIdEnum.Stella, "stella" },
        { FallbackLmntVoiceIdEnum.Terrence, "terrence" },
        { FallbackLmntVoiceIdEnum.Tyler, "tyler" },
        { FallbackLmntVoiceIdEnum.Vesper, "vesper" },
        { FallbackLmntVoiceIdEnum.Violet, "violet" },
        { FallbackLmntVoiceIdEnum.Warrick, "warrick" },
        { FallbackLmntVoiceIdEnum.Zain, "zain" },
        { FallbackLmntVoiceIdEnum.Zeke, "zeke" },
        { FallbackLmntVoiceIdEnum.Zoe, "zoe" },
    };

    public override FallbackLmntVoiceIdEnum Read(
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
        FallbackLmntVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override FallbackLmntVoiceIdEnum ReadAsPropertyName(
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
        FallbackLmntVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
