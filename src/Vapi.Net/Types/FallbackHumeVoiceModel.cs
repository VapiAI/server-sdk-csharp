using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackHumeVoiceModel>))]
public enum FallbackHumeVoiceModel
{
    [EnumMember(Value = "octave")]
    Octave,

    [EnumMember(Value = "octave2")]
    Octave2,
}
