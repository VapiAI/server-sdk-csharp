using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackSpeechmaticsTranscriberNumeralStyle>))]
public enum FallbackSpeechmaticsTranscriberNumeralStyle
{
    [EnumMember(Value = "written")]
    Written,

    [EnumMember(Value = "spoken")]
    Spoken,
}
