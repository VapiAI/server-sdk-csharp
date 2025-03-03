using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<OpenAiVoiceId>))]
public enum OpenAiVoiceId
{
    [EnumMember(Value = "alloy")]
    Alloy,

    [EnumMember(Value = "echo")]
    Echo,

    [EnumMember(Value = "fable")]
    Fable,

    [EnumMember(Value = "onyx")]
    Onyx,

    [EnumMember(Value = "nova")]
    Nova,

    [EnumMember(Value = "shimmer")]
    Shimmer,

    [EnumMember(Value = "ash")]
    Ash,

    [EnumMember(Value = "ballad")]
    Ballad,

    [EnumMember(Value = "coral")]
    Coral,

    [EnumMember(Value = "sage")]
    Sage,

    [EnumMember(Value = "verse")]
    Verse,
}
