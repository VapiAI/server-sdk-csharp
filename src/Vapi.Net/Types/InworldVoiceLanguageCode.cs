using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<InworldVoiceLanguageCode>))]
public enum InworldVoiceLanguageCode
{
    [EnumMember(Value = "en")]
    En,

    [EnumMember(Value = "zh")]
    Zh,

    [EnumMember(Value = "ko")]
    Ko,

    [EnumMember(Value = "nl")]
    Nl,

    [EnumMember(Value = "fr")]
    Fr,

    [EnumMember(Value = "es")]
    Es,

    [EnumMember(Value = "ja")]
    Ja,

    [EnumMember(Value = "de")]
    De,

    [EnumMember(Value = "it")]
    It,

    [EnumMember(Value = "pl")]
    Pl,

    [EnumMember(Value = "pt")]
    Pt,
}
