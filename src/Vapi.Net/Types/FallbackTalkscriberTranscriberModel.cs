using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackTalkscriberTranscriberModel>))]
public enum FallbackTalkscriberTranscriberModel
{
    [EnumMember(Value = "whisper")]
    Whisper,
}
