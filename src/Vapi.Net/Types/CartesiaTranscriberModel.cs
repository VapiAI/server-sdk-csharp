using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<CartesiaTranscriberModel>))]
public enum CartesiaTranscriberModel
{
    [EnumMember(Value = "ink-whisper")]
    InkWhisper,
}
