using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<GoogleTranscriberLanguage>))]
public enum GoogleTranscriberLanguage
{
    [EnumMember(Value = "Multilingual")]
    Multilingual,

    [EnumMember(Value = "Arabic")]
    Arabic,

    [EnumMember(Value = "Bengali")]
    Bengali,

    [EnumMember(Value = "Bulgarian")]
    Bulgarian,

    [EnumMember(Value = "Chinese")]
    Chinese,

    [EnumMember(Value = "Croatian")]
    Croatian,

    [EnumMember(Value = "Czech")]
    Czech,

    [EnumMember(Value = "Danish")]
    Danish,

    [EnumMember(Value = "Dutch")]
    Dutch,

    [EnumMember(Value = "English")]
    English,

    [EnumMember(Value = "Estonian")]
    Estonian,

    [EnumMember(Value = "Finnish")]
    Finnish,

    [EnumMember(Value = "French")]
    French,

    [EnumMember(Value = "German")]
    German,

    [EnumMember(Value = "Greek")]
    Greek,

    [EnumMember(Value = "Hebrew")]
    Hebrew,

    [EnumMember(Value = "Hindi")]
    Hindi,

    [EnumMember(Value = "Hungarian")]
    Hungarian,

    [EnumMember(Value = "Indonesian")]
    Indonesian,

    [EnumMember(Value = "Italian")]
    Italian,

    [EnumMember(Value = "Japanese")]
    Japanese,

    [EnumMember(Value = "Korean")]
    Korean,

    [EnumMember(Value = "Latvian")]
    Latvian,

    [EnumMember(Value = "Lithuanian")]
    Lithuanian,

    [EnumMember(Value = "Norwegian")]
    Norwegian,

    [EnumMember(Value = "Polish")]
    Polish,

    [EnumMember(Value = "Portuguese")]
    Portuguese,

    [EnumMember(Value = "Romanian")]
    Romanian,

    [EnumMember(Value = "Russian")]
    Russian,

    [EnumMember(Value = "Serbian")]
    Serbian,

    [EnumMember(Value = "Slovak")]
    Slovak,

    [EnumMember(Value = "Slovenian")]
    Slovenian,

    [EnumMember(Value = "Spanish")]
    Spanish,

    [EnumMember(Value = "Swahili")]
    Swahili,

    [EnumMember(Value = "Swedish")]
    Swedish,

    [EnumMember(Value = "Thai")]
    Thai,

    [EnumMember(Value = "Turkish")]
    Turkish,

    [EnumMember(Value = "Ukrainian")]
    Ukrainian,

    [EnumMember(Value = "Vietnamese")]
    Vietnamese,
}
