using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<LmntVoiceIdEnum>))]
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
