using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<HumeVoiceModel>))]
public enum HumeVoiceModel
{
    [EnumMember(Value = "octave")]
    Octave,

    [EnumMember(Value = "octave2")]
    Octave2,
}
