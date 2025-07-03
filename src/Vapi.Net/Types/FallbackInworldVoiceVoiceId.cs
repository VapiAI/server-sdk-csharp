using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackInworldVoiceVoiceId>))]
public enum FallbackInworldVoiceVoiceId
{
    [EnumMember(Value = "Alex")]
    Alex,

    [EnumMember(Value = "Ashley")]
    Ashley,

    [EnumMember(Value = "Craig")]
    Craig,

    [EnumMember(Value = "Deborah")]
    Deborah,

    [EnumMember(Value = "Dennis")]
    Dennis,

    [EnumMember(Value = "Edward")]
    Edward,

    [EnumMember(Value = "Elizabeth")]
    Elizabeth,

    [EnumMember(Value = "Hades")]
    Hades,

    [EnumMember(Value = "Julia")]
    Julia,

    [EnumMember(Value = "Pixie")]
    Pixie,

    [EnumMember(Value = "Mark")]
    Mark,

    [EnumMember(Value = "Olivia")]
    Olivia,

    [EnumMember(Value = "Priya")]
    Priya,

    [EnumMember(Value = "Ronald")]
    Ronald,

    [EnumMember(Value = "Sarah")]
    Sarah,

    [EnumMember(Value = "Shaun")]
    Shaun,

    [EnumMember(Value = "Theodore")]
    Theodore,

    [EnumMember(Value = "Timothy")]
    Timothy,

    [EnumMember(Value = "Wendy")]
    Wendy,

    [EnumMember(Value = "Dominus")]
    Dominus,

    [EnumMember(Value = "Yichen")]
    Yichen,

    [EnumMember(Value = "Xiaoyin")]
    Xiaoyin,

    [EnumMember(Value = "Xinyi")]
    Xinyi,

    [EnumMember(Value = "Jing")]
    Jing,

    [EnumMember(Value = "Erik")]
    Erik,

    [EnumMember(Value = "Katrien")]
    Katrien,

    [EnumMember(Value = "Lennart")]
    Lennart,

    [EnumMember(Value = "Lore")]
    Lore,

    [EnumMember(Value = "Alain")]
    Alain,

    [EnumMember(Value = "Hélène")]
    Helene,

    [EnumMember(Value = "Mathieu")]
    Mathieu,

    [EnumMember(Value = "Étienne")]
    Etienne,

    [EnumMember(Value = "Johanna")]
    Johanna,

    [EnumMember(Value = "Josef")]
    Josef,

    [EnumMember(Value = "Gianni")]
    Gianni,

    [EnumMember(Value = "Orietta")]
    Orietta,

    [EnumMember(Value = "Asuka")]
    Asuka,

    [EnumMember(Value = "Satoshi")]
    Satoshi,

    [EnumMember(Value = "Hyunwoo")]
    Hyunwoo,

    [EnumMember(Value = "Minji")]
    Minji,

    [EnumMember(Value = "Seojun")]
    Seojun,

    [EnumMember(Value = "Yoona")]
    Yoona,

    [EnumMember(Value = "Szymon")]
    Szymon,

    [EnumMember(Value = "Wojciech")]
    Wojciech,

    [EnumMember(Value = "Heitor")]
    Heitor,

    [EnumMember(Value = "Maitê")]
    Maite,

    [EnumMember(Value = "Diego")]
    Diego,

    [EnumMember(Value = "Lupita")]
    Lupita,

    [EnumMember(Value = "Miguel")]
    Miguel,

    [EnumMember(Value = "Rafael")]
    Rafael,
}
