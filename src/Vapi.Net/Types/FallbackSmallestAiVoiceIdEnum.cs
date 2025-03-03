using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackSmallestAiVoiceIdEnum>))]
public enum FallbackSmallestAiVoiceIdEnum
{
    [EnumMember(Value = "emily")]
    Emily,

    [EnumMember(Value = "jasmine")]
    Jasmine,

    [EnumMember(Value = "arman")]
    Arman,

    [EnumMember(Value = "james")]
    James,

    [EnumMember(Value = "mithali")]
    Mithali,

    [EnumMember(Value = "aravind")]
    Aravind,

    [EnumMember(Value = "raj")]
    Raj,

    [EnumMember(Value = "diya")]
    Diya,

    [EnumMember(Value = "raman")]
    Raman,

    [EnumMember(Value = "ananya")]
    Ananya,

    [EnumMember(Value = "isha")]
    Isha,

    [EnumMember(Value = "william")]
    William,

    [EnumMember(Value = "aarav")]
    Aarav,

    [EnumMember(Value = "monika")]
    Monika,

    [EnumMember(Value = "niharika")]
    Niharika,

    [EnumMember(Value = "deepika")]
    Deepika,

    [EnumMember(Value = "raghav")]
    Raghav,

    [EnumMember(Value = "kajal")]
    Kajal,

    [EnumMember(Value = "radhika")]
    Radhika,

    [EnumMember(Value = "mansi")]
    Mansi,

    [EnumMember(Value = "nisha")]
    Nisha,

    [EnumMember(Value = "saurabh")]
    Saurabh,

    [EnumMember(Value = "pooja")]
    Pooja,

    [EnumMember(Value = "saina")]
    Saina,

    [EnumMember(Value = "sanya")]
    Sanya,
}
