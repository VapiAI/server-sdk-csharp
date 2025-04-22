using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using Vapi.Net.Core;

namespace Vapi.Net;

[JsonConverter(typeof(EnumSerializer<FallbackDeepgramVoiceModel>))]
public enum FallbackDeepgramVoiceModel
{
    [EnumMember(Value = "aura")]
    Aura,

    [EnumMember(Value = "aura-2")]
    Aura2,
}
