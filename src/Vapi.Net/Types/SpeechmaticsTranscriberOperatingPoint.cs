using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<SpeechmaticsTranscriberOperatingPoint>))]
public enum SpeechmaticsTranscriberOperatingPoint
{
    [EnumMember(Value = "standard")]
    Standard,

    [EnumMember(Value = "enhanced")]
    Enhanced,
}
