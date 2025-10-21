using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<SpeechmaticsTranscriberRegion>))]
public enum SpeechmaticsTranscriberRegion
{
    [EnumMember(Value = "eu")]
    Eu,

    [EnumMember(Value = "us")]
    Us,
}
