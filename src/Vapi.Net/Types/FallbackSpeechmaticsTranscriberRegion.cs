using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackSpeechmaticsTranscriberRegion>))]
public enum FallbackSpeechmaticsTranscriberRegion
{
    [EnumMember(Value = "eu")]
    Eu,

    [EnumMember(Value = "us")]
    Us,
}
