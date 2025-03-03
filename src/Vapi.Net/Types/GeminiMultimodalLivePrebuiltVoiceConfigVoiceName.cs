using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<GeminiMultimodalLivePrebuiltVoiceConfigVoiceName>))]
public enum GeminiMultimodalLivePrebuiltVoiceConfigVoiceName
{
    [EnumMember(Value = "Puck")]
    Puck,

    [EnumMember(Value = "Charon")]
    Charon,

    [EnumMember(Value = "Kore")]
    Kore,

    [EnumMember(Value = "Fenrir")]
    Fenrir,

    [EnumMember(Value = "Aoede")]
    Aoede,
}
