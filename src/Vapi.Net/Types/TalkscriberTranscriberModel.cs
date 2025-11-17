using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<TalkscriberTranscriberModel>))]
public enum TalkscriberTranscriberModel
{
    [EnumMember(Value = "whisper")]
    Whisper,
}
