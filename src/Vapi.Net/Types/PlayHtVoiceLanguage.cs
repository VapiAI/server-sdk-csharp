using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<PlayHtVoiceLanguage>))]
public enum PlayHtVoiceLanguage
{
    [EnumMember(Value = "afrikaans")]
    Afrikaans,

    [EnumMember(Value = "albanian")]
    Albanian,

    [EnumMember(Value = "amharic")]
    Amharic,

    [EnumMember(Value = "arabic")]
    Arabic,

    [EnumMember(Value = "bengali")]
    Bengali,

    [EnumMember(Value = "bulgarian")]
    Bulgarian,

    [EnumMember(Value = "catalan")]
    Catalan,

    [EnumMember(Value = "croatian")]
    Croatian,

    [EnumMember(Value = "czech")]
    Czech,

    [EnumMember(Value = "danish")]
    Danish,

    [EnumMember(Value = "dutch")]
    Dutch,

    [EnumMember(Value = "english")]
    English,

    [EnumMember(Value = "french")]
    French,

    [EnumMember(Value = "galician")]
    Galician,

    [EnumMember(Value = "german")]
    German,

    [EnumMember(Value = "greek")]
    Greek,

    [EnumMember(Value = "hebrew")]
    Hebrew,

    [EnumMember(Value = "hindi")]
    Hindi,

    [EnumMember(Value = "hungarian")]
    Hungarian,

    [EnumMember(Value = "indonesian")]
    Indonesian,

    [EnumMember(Value = "italian")]
    Italian,

    [EnumMember(Value = "japanese")]
    Japanese,

    [EnumMember(Value = "korean")]
    Korean,

    [EnumMember(Value = "malay")]
    Malay,

    [EnumMember(Value = "mandarin")]
    Mandarin,

    [EnumMember(Value = "polish")]
    Polish,

    [EnumMember(Value = "portuguese")]
    Portuguese,

    [EnumMember(Value = "russian")]
    Russian,

    [EnumMember(Value = "serbian")]
    Serbian,

    [EnumMember(Value = "spanish")]
    Spanish,

    [EnumMember(Value = "swedish")]
    Swedish,

    [EnumMember(Value = "tagalog")]
    Tagalog,

    [EnumMember(Value = "thai")]
    Thai,

    [EnumMember(Value = "turkish")]
    Turkish,

    [EnumMember(Value = "ukrainian")]
    Ukrainian,

    [EnumMember(Value = "urdu")]
    Urdu,

    [EnumMember(Value = "xhosa")]
    Xhosa,
}
