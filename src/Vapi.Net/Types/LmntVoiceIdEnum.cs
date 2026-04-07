using global::System.Runtime.Serialization;
using global::System.Text.Json.Serialization;

namespace Vapi.Net;

[JsonConverter(typeof(LmntVoiceIdEnumSerializer))]
public enum LmntVoiceIdEnum
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

internal class LmntVoiceIdEnumSerializer
    : global::System.Text.Json.Serialization.JsonConverter<LmntVoiceIdEnum>
{
    private static readonly global::System.Collections.Generic.Dictionary<
        string,
        LmntVoiceIdEnum
    > _stringToEnum = new()
    {
        { "amy", LmntVoiceIdEnum.Amy },
        { "ansel", LmntVoiceIdEnum.Ansel },
        { "autumn", LmntVoiceIdEnum.Autumn },
        { "ava", LmntVoiceIdEnum.Ava },
        { "brandon", LmntVoiceIdEnum.Brandon },
        { "caleb", LmntVoiceIdEnum.Caleb },
        { "cassian", LmntVoiceIdEnum.Cassian },
        { "chloe", LmntVoiceIdEnum.Chloe },
        { "dalton", LmntVoiceIdEnum.Dalton },
        { "daniel", LmntVoiceIdEnum.Daniel },
        { "dustin", LmntVoiceIdEnum.Dustin },
        { "elowen", LmntVoiceIdEnum.Elowen },
        { "evander", LmntVoiceIdEnum.Evander },
        { "huxley", LmntVoiceIdEnum.Huxley },
        { "james", LmntVoiceIdEnum.James },
        { "juniper", LmntVoiceIdEnum.Juniper },
        { "kennedy", LmntVoiceIdEnum.Kennedy },
        { "lauren", LmntVoiceIdEnum.Lauren },
        { "leah", LmntVoiceIdEnum.Leah },
        { "lily", LmntVoiceIdEnum.Lily },
        { "lucas", LmntVoiceIdEnum.Lucas },
        { "magnus", LmntVoiceIdEnum.Magnus },
        { "miles", LmntVoiceIdEnum.Miles },
        { "morgan", LmntVoiceIdEnum.Morgan },
        { "natalie", LmntVoiceIdEnum.Natalie },
        { "nathan", LmntVoiceIdEnum.Nathan },
        { "noah", LmntVoiceIdEnum.Noah },
        { "nyssa", LmntVoiceIdEnum.Nyssa },
        { "oliver", LmntVoiceIdEnum.Oliver },
        { "paige", LmntVoiceIdEnum.Paige },
        { "ryan", LmntVoiceIdEnum.Ryan },
        { "sadie", LmntVoiceIdEnum.Sadie },
        { "sophie", LmntVoiceIdEnum.Sophie },
        { "stella", LmntVoiceIdEnum.Stella },
        { "terrence", LmntVoiceIdEnum.Terrence },
        { "tyler", LmntVoiceIdEnum.Tyler },
        { "vesper", LmntVoiceIdEnum.Vesper },
        { "violet", LmntVoiceIdEnum.Violet },
        { "warrick", LmntVoiceIdEnum.Warrick },
        { "zain", LmntVoiceIdEnum.Zain },
        { "zeke", LmntVoiceIdEnum.Zeke },
        { "zoe", LmntVoiceIdEnum.Zoe },
    };

    private static readonly global::System.Collections.Generic.Dictionary<
        LmntVoiceIdEnum,
        string
    > _enumToString = new()
    {
        { LmntVoiceIdEnum.Amy, "amy" },
        { LmntVoiceIdEnum.Ansel, "ansel" },
        { LmntVoiceIdEnum.Autumn, "autumn" },
        { LmntVoiceIdEnum.Ava, "ava" },
        { LmntVoiceIdEnum.Brandon, "brandon" },
        { LmntVoiceIdEnum.Caleb, "caleb" },
        { LmntVoiceIdEnum.Cassian, "cassian" },
        { LmntVoiceIdEnum.Chloe, "chloe" },
        { LmntVoiceIdEnum.Dalton, "dalton" },
        { LmntVoiceIdEnum.Daniel, "daniel" },
        { LmntVoiceIdEnum.Dustin, "dustin" },
        { LmntVoiceIdEnum.Elowen, "elowen" },
        { LmntVoiceIdEnum.Evander, "evander" },
        { LmntVoiceIdEnum.Huxley, "huxley" },
        { LmntVoiceIdEnum.James, "james" },
        { LmntVoiceIdEnum.Juniper, "juniper" },
        { LmntVoiceIdEnum.Kennedy, "kennedy" },
        { LmntVoiceIdEnum.Lauren, "lauren" },
        { LmntVoiceIdEnum.Leah, "leah" },
        { LmntVoiceIdEnum.Lily, "lily" },
        { LmntVoiceIdEnum.Lucas, "lucas" },
        { LmntVoiceIdEnum.Magnus, "magnus" },
        { LmntVoiceIdEnum.Miles, "miles" },
        { LmntVoiceIdEnum.Morgan, "morgan" },
        { LmntVoiceIdEnum.Natalie, "natalie" },
        { LmntVoiceIdEnum.Nathan, "nathan" },
        { LmntVoiceIdEnum.Noah, "noah" },
        { LmntVoiceIdEnum.Nyssa, "nyssa" },
        { LmntVoiceIdEnum.Oliver, "oliver" },
        { LmntVoiceIdEnum.Paige, "paige" },
        { LmntVoiceIdEnum.Ryan, "ryan" },
        { LmntVoiceIdEnum.Sadie, "sadie" },
        { LmntVoiceIdEnum.Sophie, "sophie" },
        { LmntVoiceIdEnum.Stella, "stella" },
        { LmntVoiceIdEnum.Terrence, "terrence" },
        { LmntVoiceIdEnum.Tyler, "tyler" },
        { LmntVoiceIdEnum.Vesper, "vesper" },
        { LmntVoiceIdEnum.Violet, "violet" },
        { LmntVoiceIdEnum.Warrick, "warrick" },
        { LmntVoiceIdEnum.Zain, "zain" },
        { LmntVoiceIdEnum.Zeke, "zeke" },
        { LmntVoiceIdEnum.Zoe, "zoe" },
    };

    public override LmntVoiceIdEnum Read(
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
        LmntVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WriteStringValue(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : null
        );
    }

    public override LmntVoiceIdEnum ReadAsPropertyName(
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
        LmntVoiceIdEnum value,
        global::System.Text.Json.JsonSerializerOptions options
    )
    {
        writer.WritePropertyName(
            _enumToString.TryGetValue(value, out var stringValue) ? stringValue : value.ToString()
        );
    }
}
