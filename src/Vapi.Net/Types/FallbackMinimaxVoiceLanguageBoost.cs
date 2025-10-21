using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackMinimaxVoiceLanguageBoost>))]
public enum FallbackMinimaxVoiceLanguageBoost
{
    [EnumMember(Value = "Chinese")]
    Chinese,

    [EnumMember(Value = "Chinese,Yue")]
    ChineseYue,

    [EnumMember(Value = "English")]
    English,

    [EnumMember(Value = "Arabic")]
    Arabic,

    [EnumMember(Value = "Russian")]
    Russian,

    [EnumMember(Value = "Spanish")]
    Spanish,

    [EnumMember(Value = "French")]
    French,

    [EnumMember(Value = "Portuguese")]
    Portuguese,

    [EnumMember(Value = "German")]
    German,

    [EnumMember(Value = "Turkish")]
    Turkish,

    [EnumMember(Value = "Dutch")]
    Dutch,

    [EnumMember(Value = "Ukrainian")]
    Ukrainian,

    [EnumMember(Value = "Vietnamese")]
    Vietnamese,

    [EnumMember(Value = "Indonesian")]
    Indonesian,

    [EnumMember(Value = "Japanese")]
    Japanese,

    [EnumMember(Value = "Italian")]
    Italian,

    [EnumMember(Value = "Korean")]
    Korean,

    [EnumMember(Value = "Thai")]
    Thai,

    [EnumMember(Value = "Polish")]
    Polish,

    [EnumMember(Value = "Romanian")]
    Romanian,

    [EnumMember(Value = "Greek")]
    Greek,

    [EnumMember(Value = "Czech")]
    Czech,

    [EnumMember(Value = "Finnish")]
    Finnish,

    [EnumMember(Value = "Hindi")]
    Hindi,

    [EnumMember(Value = "Bulgarian")]
    Bulgarian,

    [EnumMember(Value = "Danish")]
    Danish,

    [EnumMember(Value = "Hebrew")]
    Hebrew,

    [EnumMember(Value = "Malay")]
    Malay,

    [EnumMember(Value = "Persian")]
    Persian,

    [EnumMember(Value = "Slovak")]
    Slovak,

    [EnumMember(Value = "Swedish")]
    Swedish,

    [EnumMember(Value = "Croatian")]
    Croatian,

    [EnumMember(Value = "Filipino")]
    Filipino,

    [EnumMember(Value = "Hungarian")]
    Hungarian,

    [EnumMember(Value = "Norwegian")]
    Norwegian,

    [EnumMember(Value = "Slovenian")]
    Slovenian,

    [EnumMember(Value = "Catalan")]
    Catalan,

    [EnumMember(Value = "Nynorsk")]
    Nynorsk,

    [EnumMember(Value = "Tamil")]
    Tamil,

    [EnumMember(Value = "Afrikaans")]
    Afrikaans,

    [EnumMember(Value = "auto")]
    Auto,
}
