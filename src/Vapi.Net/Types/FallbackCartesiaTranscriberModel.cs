using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackCartesiaTranscriberModel>))]
public enum FallbackCartesiaTranscriberModel
{
    [EnumMember(Value = "ink-whisper")]
    InkWhisper,
}
