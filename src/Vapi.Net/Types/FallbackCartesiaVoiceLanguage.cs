using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackCartesiaVoiceLanguage>))]
public enum FallbackCartesiaVoiceLanguage
{
    [EnumMember(Value = "en")]
    En,

    [EnumMember(Value = "de")]
    De,

    [EnumMember(Value = "es")]
    Es,

    [EnumMember(Value = "fr")]
    Fr,

    [EnumMember(Value = "ja")]
    Ja,

    [EnumMember(Value = "pt")]
    Pt,

    [EnumMember(Value = "zh")]
    Zh,

    [EnumMember(Value = "hi")]
    Hi,

    [EnumMember(Value = "it")]
    It,

    [EnumMember(Value = "ko")]
    Ko,

    [EnumMember(Value = "nl")]
    Nl,

    [EnumMember(Value = "pl")]
    Pl,

    [EnumMember(Value = "ru")]
    Ru,

    [EnumMember(Value = "sv")]
    Sv,

    [EnumMember(Value = "tr")]
    Tr,
}
