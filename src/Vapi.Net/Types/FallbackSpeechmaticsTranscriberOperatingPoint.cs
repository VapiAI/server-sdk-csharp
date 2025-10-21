using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackSpeechmaticsTranscriberOperatingPoint>))]
public enum FallbackSpeechmaticsTranscriberOperatingPoint
{
    [EnumMember(Value = "standard")]
    Standard,

    [EnumMember(Value = "enhanced")]
    Enhanced,
}
