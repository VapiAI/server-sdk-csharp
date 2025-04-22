using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackOpenAiVoiceIdEnum>))]
public enum FallbackOpenAiVoiceIdEnum
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
}
