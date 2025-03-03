using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<ElevenLabsVoiceIdEnum>))]
public enum ElevenLabsVoiceIdEnum
{
    [EnumMember(Value = "burt")]
    Burt,

    [EnumMember(Value = "marissa")]
    Marissa,

    [EnumMember(Value = "andrea")]
    Andrea,

    [EnumMember(Value = "sarah")]
    Sarah,

    [EnumMember(Value = "phillip")]
    Phillip,

    [EnumMember(Value = "steve")]
    Steve,

    [EnumMember(Value = "joseph")]
    Joseph,

    [EnumMember(Value = "myra")]
    Myra,

    [EnumMember(Value = "paula")]
    Paula,

    [EnumMember(Value = "ryan")]
    Ryan,

    [EnumMember(Value = "drew")]
    Drew,

    [EnumMember(Value = "paul")]
    Paul,

    [EnumMember(Value = "mrb")]
    Mrb,

    [EnumMember(Value = "matilda")]
    Matilda,

    [EnumMember(Value = "mark")]
    Mark,
}
