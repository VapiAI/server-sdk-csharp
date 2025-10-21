using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<SpeechmaticsTranscriberNumeralStyle>))]
public enum SpeechmaticsTranscriberNumeralStyle
{
    [EnumMember(Value = "written")]
    Written,

    [EnumMember(Value = "spoken")]
    Spoken,
}
